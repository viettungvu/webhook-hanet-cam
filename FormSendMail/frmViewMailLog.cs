using FormSendMail.Ext;
using Infra.EF;
using Infra.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace FormSendMail
{
    public partial class frmViewMailLog : Form
    {

        private readonly HRMDbContext _context;
        private readonly IConfiguration _configuration;
        public IEnumerable<string> Ids { get; set; }
        public DateTime? DataDate { get; set; }

        private IEnumerable<MailLog> _logs;
        private BackgroundWorker _workerSendMail;

        private const int MAX_ERROR = 5;
        public frmViewMailLog(HRMDbContext context, IConfiguration config)
        {
            _context = context;
            _configuration = config;
            InitializeComponent();
        }

        private void frmViewMailLog_Load(object sender, EventArgs e)
        {
            initGrid();
            reloadGrid();
        }

        void reloadGrid()
        {
            if (Ids != null && Ids.Count() > 0)
            {

                _logs = _context.MailLogs.Where(x => Ids.Contains(x.Id) && x.ErrorCount <= MAX_ERROR);
                setDataToGrid(_logs);
                activeBtnResend(_logs.Count() > 0);
            }
            else if (DataDate.HasValue)
            {
                _logs = _context.MailLogs.Where(x => x.DataDate == DataDate.Value && x.ErrorCount <= MAX_ERROR);
                setDataToGrid(_logs);
                activeBtnResend(_logs.Count() > 0);
            }
        }


        private void activeBtnResend(bool isActive)
        {
            btnResend.Enabled = isActive;
        }

        private StringBuilder _message = new StringBuilder();
        private void initGrid()
        {
            dgvMaiLog.AddColumn("UserId", "UserId");
            dgvMaiLog.AddColumn("Email", "Email");
            dgvMaiLog.AddColumn("DataDate", "DataDate");
            dgvMaiLog.AddColumn("Status", "Status");
        }

        private void setDataToGrid(IEnumerable<MailLog> logs)
        {
            dgvMaiLog.Rows.Clear();
            foreach (MailLog log in logs)
            {
                dgvMaiLog.Rows.Add(log.UserId,
                    log.Email,
                    log.DataDate,
                    log.Status
                    );
            }
        }
        private Dictionary<int, string> _dicTaskIncomeId = new Dictionary<int, string>();
        private ViewIncomeEmployee getIncome(DateTime dataDate, int userId)
        {
            return _context.ViewIncomeEmployees.FirstOrDefault(x => x.DataDate == dataDate && userId == x.UserId);
        }

        private void resend()
        {
            if (_logs != null && _logs.Count() > 0)
            {
                int port = _configuration.GetValue<int>("MailSettings:Port");
                string host = _configuration.GetValue<string>("MailSettings:Host");
                string sender_address = _configuration.GetValue<string>("MailSettings:SenderAddress");
                string sender_name = _configuration.GetValue<string>("MailSettings:SenderName");
                string password = _configuration.GetValue<string>("MailSettings:SenderSecret");

                MailAddress from = new MailAddress(sender_address, sender_name);
                string template = System.IO.File.ReadAllText(_configuration.GetValue<string>("MailSettings:Template"));

                IEnumerable<MailLog> logResend = _logs.Where(x => x.Status == MailSendStatus.FAILED);
                List<Task> tasks = new List<Task>();
                if (!string.IsNullOrWhiteSpace(template))
                {
                    foreach (MailLog log in logResend)
                    {
                        try
                        {
                            ViewIncomeEmployee income = getIncome(log.DataDate, log.UserId);
                            if (income != null)
                            {

                                string imageLogo = AppContext.BaseDirectory + _configuration.GetValue<string>("MailSettings:SignatureLogo");

                                SmtpClient mailClient = new SmtpClient(host)
                                {
                                    Port = port,
                                    Credentials = new NetworkCredential(sender_address, password),
                                    EnableSsl = true,
                                };

                                mailClient.SendCompleted += OnMailSendCompleted;
                                Employee em = _context.Employees.Find(income.UserId);
                                if (em != null && !string.IsNullOrWhiteSpace(em.BusinessEmail))
                                {
                                    MailAddress to = new MailAddress(em.BusinessEmail);


                                    string body = template;


                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.KiLuongThang), income.DataDate.ToString("MM/yyyy"), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.HoTen), income.FullName, RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.DonVi), income.DepartmentFullName, RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.MaNhanVien), em.UserName, RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.ChucVu), em.PositionName, RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.Email), em.BusinessEmail, RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.SoTaiKhoan), "0x000", RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.LuongCoBan), formatCurrency(income.LCB), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.PhuCapTrachNhiem), formatCurrency(income.PCTN), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.PhuCapThamNien), formatCurrency(income.PCTN), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.AnGiuaCa), formatCurrency(income.TienAnGiuaCa), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.TongTienThemGio), formatCurrency(income.TienThemGio), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.TienLamDem), formatCurrency(income.TienLamDem), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.BaoHiemXaHoi), formatCurrency(income.BHXH), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.BaoHiemYTe), formatCurrency(income.BHYT), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.BaoHiemThatNghiep), formatCurrency(income.BHTN), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.ThueThuNhap), formatCurrency(income.ThueThuNhap), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.DoanPhi), formatCurrency(income.DoanPhiCD), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body = Regex.Replace(body, MailUtils.GetReplaceField(MailConst.ThucLinh), formatCurrency(income.ThucLinh), RegexOptions.None, TimeSpan.FromSeconds(5));
                                    body += footer;
                                    LinkedResource linkedResource = new LinkedResource(imageLogo, MediaTypeNames.Image.Jpeg);
                                    linkedResource.ContentId = MailConst.Logo;

                                    AlternateView alternateView = AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html);
                                    alternateView.LinkedResources.Add(linkedResource);

                                    MailMessage message = new MailMessage(from, to)
                                    {
                                        Subject = string.Format("BẢNG KÊ CHI TRẢ LƯƠNG {0}", income.DataDate.ToString("MM/yyyy")),
                                        Body = body,
                                        IsBodyHtml = true,
                                        AlternateViews = { alternateView },
                                    };
                                    Task t = mailClient.SendMailAsync(message);
                                    tasks.Add(t);
                                    _dicTaskIncomeId.Add(t.Id, log.Id);
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    _counter.fail += 1;
                                    _workerSendMail.ReportProgress(_counter.success + _counter.fail, _counter);
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            _message.Append(ex.Message);
                        }
                    }
                    try
                    {
                        Task.WaitAll(tasks.ToArray());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy template");
                }

            }

        }
        private CounterState _counter = new CounterState()
        {
            fail = 0,
            success = 0,
            total = 0
        };
        private string formatCurrency(decimal? value)
        {
            if (value.HasValue)
            {
                return value.Value.ToString("C", new CultureInfo("vi-VN"));
            }
            return string.Empty;
        }

        private void OnMailSendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                TaskCompletionSource t = (TaskCompletionSource)e.UserState;
                int taskId = t.Task.Id;
                if (_dicTaskIncomeId.ContainsKey(taskId))
                {
                    MailLog log = _context.MailLogs.Find(_dicTaskIncomeId[taskId]);
                    if (log != null)
                    {
                        log.Status = e.Error is null ? MailSendStatus.SUCCESSED : MailSendStatus.FAILED;
                        if (log.Status == MailSendStatus.FAILED)
                        {
                            log.ErrorCount += 1;
                        }
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
            }

            if (e.Error != null)
            {
                _counter.fail += 1;
            }
            else
            {
                _counter.success += 1;
            }
            _workerSendMail.ReportProgress(_counter.success + _counter.fail, _counter);
        }

        private void workerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            reloadGrid();
            string message = _message.ToString();
            if (!string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(string.Format("Đã gửi thành công {0} mail", _counter.success), "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResend_Click(object sender, EventArgs e)
        {
            if (_workerSendMail == null || !_workerSendMail.IsBusy)
            {
                _workerSendMail = new BackgroundWorker()
                {
                    WorkerReportsProgress = true,
                    WorkerSupportsCancellation = true,
                };
                _workerSendMail.DoWork += onResend;
                _workerSendMail.RunWorkerCompleted += workerCompleted;
                _workerSendMail.RunWorkerAsync();
            }

        }

        private void onResend(object sender, DoWorkEventArgs e)
        {
            resend();
        }

        private static string footer = "<table style=\"border-collapse: collapse;table-layout: fixed;border-spacing: 0;mso-table-lspace: 0pt;mso-table-rspace: 0pt;vertical-align: top;min-width: 320px;Margin: 0 auto;background-color: #e7e7e7;width:100%\" cellpadding=\"0\" cellspacing=\"0\">\r\n  <tbody>\r\n  <tr style=\"vertical-align: top\">\r\n    <td style=\"word-break: break-word;border-collapse: collapse !important;vertical-align: top\">\r\n    <!--[if (mso)|(IE)]><table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\"><tr><td align=\"center\" style=\"background-color: #e7e7e7;\"><![endif]-->\r\n    \r\n  \r\n  \r\n<div class=\"u-row-container\" style=\"padding: 0px;background-color: transparent\">\r\n  <div class=\"u-row\" style=\"margin: 0 auto;min-width: 320px;max-width: 500px;overflow-wrap: break-word;word-wrap: break-word;word-break: break-word;background-color: transparent;\">\r\n    <div style=\"border-collapse: collapse;display: table;width: 100%;height: 100%;background-color: transparent;\">\r\n      <!--[if (mso)|(IE)]><table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\"><tr><td style=\"padding: 0px;background-color: transparent;\" align=\"center\"><table cellpadding=\"0\" cellspacing=\"0\" border=\"0\" style=\"width:500px;\"><tr style=\"background-color: transparent;\"><![endif]-->\r\n      \r\n<!--[if (mso)|(IE)]><td align=\"center\" width=\"500\" style=\"width: 500px;padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;\" valign=\"top\"><![endif]-->\r\n<div class=\"u-col u-col-100\" style=\"max-width: 320px;min-width: 500px;display: table-cell;vertical-align: top;\">\r\n  <div style=\"height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;\">\r\n  <!--[if (!mso)&(!IE)]><!--><div style=\"box-sizing: border-box; height: 100%; padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;\"><!--<![endif]-->\r\n  \r\n<table style=\"font-family:arial,helvetica,sans-serif;\" role=\"presentation\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" border=\"0\">\r\n  <tbody>\r\n    <tr>\r\n      <td style=\"overflow-wrap:break-word;word-break:break-word;padding:10px;font-family:arial,helvetica,sans-serif;\" align=\"left\">\r\n        \r\n  <div style=\"font-size: 14px; line-height: 140%; text-align: left; word-wrap: break-word;\">\r\n    <p style=\"line-height: 140%;\">NGUYEN CHAU THANH HAU (MR.)<br />IT-Software<br />Planning &amp; IT Division<br />Cell: 84-792 723 651<br />Email: haunguyen.08061999@gmail.com</p>\r\n  </div>\r\n\r\n      </td>\r\n    </tr>\r\n  </tbody>\r\n</table>\r\n\r\n<table style=\"font-family:arial,helvetica,sans-serif;\" role=\"presentation\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" border=\"0\">\r\n  <tbody>\r\n    <tr>\r\n      <td style=\"overflow-wrap:break-word;word-break:break-word;padding:10px;font-family:arial,helvetica,sans-serif;\" align=\"left\">\r\n        \r\n  <table height=\"0px\" align=\"center\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"border-collapse: collapse;table-layout: fixed;border-spacing: 0;mso-table-lspace: 0pt;mso-table-rspace: 0pt;vertical-align: top;border-top: 1px solid #BBBBBB;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%\">\r\n    <tbody>\r\n      <tr style=\"vertical-align: top\">\r\n        <td style=\"word-break: break-word;border-collapse: collapse !important;vertical-align: top;font-size: 0px;line-height: 0px;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%\">\r\n          <span>&#160;</span>\r\n        </td>\r\n      </tr>\r\n    </tbody>\r\n  </table>\r\n\r\n      </td>\r\n    </tr>\r\n  </tbody>\r\n</table>\r\n\r\n<table style=\"font-family:arial,helvetica,sans-serif;\" role=\"presentation\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" border=\"0\">\r\n  <tbody>\r\n    <tr>\r\n      <td style=\"overflow-wrap:break-word;word-break:break-word;padding:10px;font-family:arial,helvetica,sans-serif;\" align=\"left\">\r\n        \r\n<table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">\r\n  <tr>\r\n    <td style=\"padding-right: 0px;padding-left: 0px;\" align=\"center\">\r\n      \r\n      <img align=\"center\" border=\"0\" src=\"cid:[SIGNATURE_LOGO]\" alt=\"\" title=\"\" style=\"outline: none;text-decoration: none;-ms-interpolation-mode: bicubic;clear: both;display: inline-block !important;border: none;height: auto;float: none;width: 100%;max-width: 480px;\" width=\"480\"/>\r\n      \r\n    </td>\r\n  </tr>\r\n</table>\r\n\r\n      </td>\r\n    </tr>\r\n  </tbody>\r\n</table>\r\n\r\n<table style=\"font-family:arial,helvetica,sans-serif;\" role=\"presentation\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" border=\"0\">\r\n  <tbody>\r\n    <tr>\r\n      <td style=\"overflow-wrap:break-word;word-break:break-word;padding:10px;font-family:arial,helvetica,sans-serif;\" align=\"left\">\r\n        \r\n  <div style=\"font-size: 14px; line-height: 140%; text-align: left; word-wrap: break-word;\">\r\n    <p style=\"line-height: 140%;\">This email and any fi­les transmitted with it are con­dential and intended solely for the use of the individual or entity to whom they are addressed. If you have received this email in error, please notify the system manager.<br />Please note that any views or opinions presented in this email are solely those of the author and do not necessarily represent those of SAIGON GROUND SERVICES JSC. Finally, the recipient should check this email and any attachments for the presence of viruses. SAIGON GROUND SERVICES JSC accepts no liability for any damage caused by any virus transmitted by this email. Thank you!<br />PLEASE CONSIDER THE ENVIRONMENT BEFORE PRINTING THIS EMAIL.</p>\r\n  </div>\r\n\r\n      </td>\r\n    </tr>\r\n  </tbody>\r\n</table>\r\n\r\n  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->\r\n  </div>\r\n</div>\r\n<!--[if (mso)|(IE)]></td><![endif]-->\r\n      <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->\r\n    </div>\r\n  </div>\r\n  </div>\r\n  \r\n\r\n\r\n    <!--[if (mso)|(IE)]></td></tr></table><![endif]-->\r\n    </td>\r\n  </tr>\r\n  </tbody>\r\n  </table>";
    }
}
