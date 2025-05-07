using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoney.Helpers
{
    internal class VisualStyle
    {
        public static void dgvStyle(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.LightCyan;
            dgv.DefaultCellStyle.ForeColor = Color.LightSkyBlue;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            dgv.EnableHeadersVisualStyles = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.DefaultCellStyle.Padding = new Padding(1);
        }

        public static void btnStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.SteelBlue;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            btn.Padding = new Padding(10, 5, 10, 5);
            btn.Height = 35;
            btn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
        }

        public static void cbStyle(ComboBox cb)
        {
            cb.FlatStyle = FlatStyle.Flat;
            cb.BackColor = Color.White;
            cb.ForeColor = Color.Black;
            cb.Font = new Font("Segoe UI", 10);
            cb.DropDownStyle = ComboBoxStyle.DropDownList; 
            cb.IntegralHeight = false;
            cb.MaxDropDownItems = 6;
        }

        public static void numStyle(NumericUpDown numUpDown)
        {
            numUpDown.BorderStyle = BorderStyle.None;
            numUpDown.BackColor = Color.White;
            numUpDown.ForeColor = Color.Black;
            numUpDown.Font = new Font("Segoe UI", 10);
            numUpDown.UpDownAlign = LeftRightAlignment.Left;

            numUpDown.Controls[0].BackColor = Color.SteelBlue; 
            numUpDown.Controls[0].ForeColor = Color.White; 
            numUpDown.Controls[0].Font = new Font("Segoe UI", 8, FontStyle.Bold);


            numUpDown.Controls[1].BackColor = Color.White;
            numUpDown.Controls[1].ForeColor = Color.Black;

            numUpDown.Padding = new Padding(5);
        }
    }
}
