using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSendMail.Ext
{
    public static class ControlsExt
    {
        public static void AddColumn(this DataGridView gridview, string column_name, string column_text, int width = 150)
        {
            DataGridViewColumn col = new DataGridViewTextBoxColumn()
            {
                HeaderText = column_text,
                Name = column_name,
                Width = width,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            };
            gridview.Columns.Add(col);
        }
    }
}
