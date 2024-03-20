using Infra.EF;
using Infra.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using ToolInsertCheckin.Core;
using ToolInsertCheckin.Ext;

namespace ToolInsertCheckin
{
    public partial class frmAutoInsert : Form
    {
        private readonly AppDbContext _appContext;
        private readonly IConfiguration _config;
        public frmAutoInsert(AppDbContext appContext, IConfiguration config)
        {
            _appContext = appContext;
            _config = config;
            InitializeComponent();
        }


        private bool _isRunning = false;
        #region Background worker
        private BackgroundWorker _autoWorker;
        private BackgroundWorker _refreshWorker;
        private void initRefreshWorker()
        {
            if (_refreshWorker != null && !_refreshWorker.IsBusy)
            {
                _refreshWorker.Dispose();
            }
            _refreshWorker = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            _refreshWorker.DoWork += onRefreshWorkerRun;
            _refreshWorker.RunWorkerCompleted += onRefreshWorkerCompleted;
            _refreshWorker.ProgressChanged += onRefreshWorkerProcessChanged;
        }

        private void onRefreshWorkerProcessChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void onRefreshWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            addControlText(txtTerminal, "Get data completed");
        }

        private void onRefreshWorkerRun(object sender, DoWorkEventArgs e)
        {
            DateTime authDate = dpkAuthDate.Value;
            addControlText(txtTerminal, string.Format("Starting worker"));
            process(authDate, _refreshWorker);
            addControlText(txtTerminal, string.Format("Completed"));
        }

        private void initAutoWorker()
        {
            if (_autoWorker != null && !_autoWorker.IsBusy)
            {
                _autoWorker.Dispose();
            }
            _autoWorker = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            _autoWorker.DoWork += onAutoInsertData;
            _autoWorker.RunWorkerCompleted += onAutoWorkerCompleted;
            _autoWorker.ProgressChanged += onAutoProgessChanged;
        }
        private void onAutoProgessChanged(object sender, ProgressChangedEventArgs e)
        {
            this.prgBar.Value = e.ProgressPercentage;
        }
        private void onAutoInsertData(object sender, DoWorkEventArgs e)
        {

            int timeout = getInterval();
            DateTime authDate = dpkAuthDate.Value;
            while (true)
            {
                try
                {
                    addControlText(txtTerminal, string.Format("Starting worker"));
                    process(authDate, _autoWorker);
                    addControlText(txtTerminal, string.Format("Completed"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Thread.Sleep(timeout);
            }
        }

        private void onAutoWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        #endregion


        #region Helper





        private int getInterval()
        {
            if (double.TryParse(_config.GetValue<string>("DelayAuto"), out double interval) && interval > 0)
            {
                return (int)(interval * 60000);
            }
            return 30000;
        }
        private void setBtnAutoStyle()
        {
            this.btnAuto.Text = getTextBtnAuto();
            this.btnAuto.ForeColor = getForeColorBtnAuto();
        }

        private string getTextBtnAuto()
        {
            return string.Format(@"Auto Insert Data: {0}", _isRunning ? "ON" : "OFF");
        }

        private Color getForeColorBtnAuto()
        {
            if (_isRunning)
            {
                return Color.FromArgb(13, 146, 118);
            }
            return Color.Black;
        }

        private void toggleDkpAuthDateState()
        {
            this.dpkAuthDate.Enabled = !_isRunning;
        }
        private void setProgressSetting(int max = 100)
        {
            if (this.prgBar.InvokeRequired)
            {
                this.prgBar.Invoke(() =>
                {
                    this.prgBar.Value = 0;
                    this.prgBar.Minimum = 0;
                    this.prgBar.Maximum = max;
                    this.prgBar.Step = 1;
                });
            }
            else
            {
                this.prgBar.Value = 0;
                this.prgBar.Minimum = 0;
                this.prgBar.Maximum = max;
                this.prgBar.Step = 1;
            }
        }

        private void resetProgessbar()
        {
            this.prgBar.Value = 0;
        }

        private void addControlText(Control ctrl, string text)
        {
            string line = string.Format("{0}: {1}", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"), text);
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(() =>
                {
                    ctrl.Text += Environment.NewLine;
                    ctrl.Text += line;
                });
            }
            else
            {
                ctrl.Text += line;
            }
        }

        private void setControlText(Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(() => { ctrl.Text = text; });
            }
            else
            {
                ctrl.Text = text;
            }
        }

        private void initGrid()
        {
            dgvAttendance.AddColumn("UserId", "User ID");
            dgvAttendance.AddColumn("AuthDate", "Auth Date");
            dgvAttendance.AddColumn("DeviceName", "Device Name");
            dgvAttendance.AddColumn("Flag", "Flag");
        }

        private void setDataToGrid(IEnumerable<Attendance> attendances)
        {
            if (dgvAttendance.InvokeRequired)
            {
                dgvAttendance.Invoke(() =>
                {
                    dgvAttendance.Rows.Clear();
                    if (attendances != null)
                    {
                        foreach (var attendance in attendances)
                        {
                            dgvAttendance.Rows.Add(attendance.UserID, attendance.AuthDate, attendance.DeviceName, attendance.Flag);
                        }
                    }
                });
            }
            else
            {
                dgvAttendance.Rows.Clear();
                if (attendances != null)
                {
                    foreach (var attendance in attendances)
                    {
                        dgvAttendance.Rows.Add(attendance.UserID, attendance.AuthDate, attendance.DeviceName, attendance.Flag);
                    }
                }
            }

        }

        private void process(DateTime authDate, BackgroundWorker worker = null)
        {
            try
            {
                string sqlRaw = string.Format("Exec {0} @DataDate, @Flag", Infra.Shared.StoreProcedure.Sel_DataHikCentral_By_Date_And_Flag);

                SqlParameter pDataDate = new SqlParameter("@DataDate", System.Data.SqlDbType.DateTime)
                {
                    Value = authDate,
                };
                SqlParameter pFlag = new SqlParameter("@Flag", System.Data.SqlDbType.Int)
                {
                    Value = 0,
                };
                Attendance[] attendances = _appContext.Webcam.Attendance.FromSqlRaw<Attendance>(sqlRaw, pDataDate, pFlag).ToArray();
                setDataToGrid(attendances);
                int totalAttendances = attendances.Length;
                setProgressSetting(totalAttendances);
                addControlText(txtTerminal, string.Format("Found {0} records", totalAttendances));

                int success = 0;

                for (int i = 0; i < totalAttendances; i++)
                {
                    setControlText(lblTotal, string.Format("Processing {0}/{1}", i + 1, totalAttendances));
                    int rows = _appContext.Hrm.Database.ExecuteSqlInterpolated($"EXEC {Infra.Shared.StoreProcedure.Ins_H0_EmployeeTimeBillByUserIdAndTime} @UserId={attendances[i].UserID},@InputTime={attendances[i].AuthDate},@Machine={attendances[i].DeviceName}");

                    addControlText(txtTerminal, string.Format("User with id {0} has been inserted", attendances[i].UserID));
                    success += 1;
                    attendances[i].Flag = 1;
                    if (worker != null)
                    {
                        worker.ReportProgress(i + 1);
                    }
                    _appContext.Webcam.SaveChanges();
                    Thread.Sleep(5000);
                }
                setControlText(lblLastRun, string.Format("Last run: {0}", DateTime.Now.ToShortTimeString()));
            }
            catch (Exception)
            {


            }

        }
        #endregion


        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                DialogResult comfirmDialog = MessageBox.Show("Dữ liệu đang được insert vào database, bạn chắc chắn muốn dừng lại?", "Dừng tiến trình", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (comfirmDialog == DialogResult.Yes)
                {
                    _autoWorker.CancelAsync();
                    _autoWorker.Dispose();
                    _isRunning = !_isRunning;
                    setBtnAutoStyle();
                    toggleDkpAuthDateState();
                    resetProgessbar();
                }
            }
            else
            {
                initAutoWorker();
                _autoWorker.RunWorkerAsync();
                _isRunning = !_isRunning;
                setBtnAutoStyle();
                toggleDkpAuthDateState();
                resetProgessbar();
            }

        }

        private void frmAutoInsert_Load(object sender, EventArgs e)
        {
            setBtnAutoStyle();
            setProgressSetting();
            initGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (_refreshWorker == null || (_refreshWorker != null && !_refreshWorker.IsBusy))
            {
                initRefreshWorker();
                _refreshWorker.RunWorkerAsync();
            }
        }
    }
}
