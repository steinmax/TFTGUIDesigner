using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFTGUIDesigner.TFTControls;

namespace TFTGUIDesigner
{
    public partial class Form1 : Form
    {
        TFTCanvas TFTCan;
        public string TFTLibName = "tft";
        public bool MouseButtonDown = false;
        TFTControl selected = null;
        TFTControl hovered = null;
        Point offset = Point.Empty;

        public Form1()
        {
            InitializeComponent();
            TFTCan = new TFTCanvas(pnCanvas);
            lbCurrentSize.Text = $"{pnCanvas.Width};{pnCanvas.Height} (W;H)";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void AddControl(TFTControl con)
        {
            TFTCan.AddControl(con);
            TFTCan.RedrawControls();
        }

        private void btnSetCanvasSize_Click(object sender, EventArgs e)
        {
            frmResizeCanvas resize = new frmResizeCanvas();
            resize.ShowDialog();

            if (resize.Success)
            {
                pnCanvas.Height = resize.Height;
                pnCanvas.Width = resize.Width;
                lbCurrentSize.Text = $"{pnCanvas.Width};{pnCanvas.Height} (W;H)";
            }
        }

        private void btnExportCode_Click(object sender, EventArgs e)
        {
            ExportCode();
        }

        private void ExportCode()
        {
            throw new NotImplementedException();
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                TFTLibName = toolStripTextBox1.Text;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TFTLabel label = new TFTLabel(10, 10, 0, 0, TFTCan);
            label.Text = "Test Hallo";
            TFTCan.RedrawControls();
        }

        private void pnCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point current = e.Location;

            bool found = false;
            foreach(TFTControl control in TFTCan.GetControls())
            {
                if (IsPointInControl(control, current))
                {
                    hovered = control;
                    found = true;
                }
            }

            if (!found)
                hovered = null;

            if (selected != null && MouseButtonDown)
            {
                selected.X = e.X - offset.X;
                selected.Y = e.Y - offset.Y;
                TFTCan.RedrawControls();
            }
        }

        private bool IsPointInControl(TFTControl control, Point point)
        {
            return (point.X >= control.X) && (point.X <= (control.X + control.Width)) && (point.Y >= control.Y) && (point.Y <= (control.Y + control.Height));
        }

        private void pnCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            MouseButtonDown = false;
        }

        private void pnCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            MouseButtonDown = true;
            selected = hovered;

            Debug.WriteLine("Selected Control: " + selected);

            if(selected != null)
            {
                LoadProperties(selected);
                offset = new Point(e.X - selected.X, e.Y - selected.Y);
            }
        }

        private void LoadProperties(TFTControl sel)
        {
            //Load standard Properties (base class)
            DataTable table = new DataTable();
            table.Columns.Add("Property");
            table.Columns.Add("Value");

            DataRow row = table.NewRow();
            row["Property"] = nameof(sel.X);
            row["Value"] = sel.X;
            table.Rows.Add(row);
            row = table.NewRow();
            row["Property"] = nameof(sel.Y);
            row["Value"] = sel.Y;
            table.Rows.Add(row);
            row = table.NewRow();
            row["Property"] = nameof(sel.Width);
            row["Value"] = sel.Width;
            table.Rows.Add(row);
            row = table.NewRow();
            row["Property"] = nameof(sel.Height);
            row["Value"] = sel.Height;
            table.Rows.Add(row);
            row = table.NewRow();
            row["Property"] = nameof(sel.BorderWith);
            row["Value"] = sel.BorderWith;
            table.Rows.Add(row);
            row = table.NewRow();
            row["Property"] = nameof(sel.Text);
            row["Value"] = sel.Text;
            table.Rows.Add(row);
            row = table.NewRow();
            row["Property"] = nameof(sel.FontSize);
            row["Value"] = sel.FontSize;
            table.Rows.Add(row);
            row = table.NewRow();
            row["Property"] = nameof(sel.BackgroundColor);
            row["Value"] = sel.BackgroundColor;
            table.Rows.Add(row);
            row = table.NewRow();
            row["Property"] = nameof(sel.ForegroundColor);
            row["Value"] = sel.ForegroundColor;
            table.Rows.Add(row);

            if (sel is TFTRectangle rect)
            {
                //nothing
            }
            else if(sel is TFTButton btn)
            {
                row = table.NewRow();
                row["Property"] = nameof(btn.AutoSize);
                row["Value"] = btn.AutoSize;
                table.Rows.Add(row);
            }
            else if(sel is TFTLabel lbn)
            {
                //nothing
            }
            dgvProperties.Tag = sel;
            dgvProperties.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvControls.Items.Add("Rectangle");
            lvControls.Items.Add("Label");
            lvControls.Items.Add("Button");
        }

        private void lvControls_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lvControls.SelectedItems.Count > 0)
            {
                string control = lvControls.SelectedItems[0].Text;
                TFTControl con = null;
                if(control == "Button")
                {
                    con = new TFTButton(10, 10, 100, 50, TFTCan);
                    TFTCan.RedrawControls();
                }
                else if (control == "Label")
                {
                    con = new TFTLabel(10, 10, 100, 50, TFTCan);
                    TFTCan.RedrawControls();
                }
                else if(control == "Rectangle")
                {
                    con = new TFTRectangle(10, 10, 100, 50, TFTCan);
                    TFTCan.RedrawControls();
                }

                if(con != null)
                {
                    LoadProperties(con);
                    selected = con;
                }
            }
        }

        private void dgvProperties_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string name = (string)dgvProperties.Rows[e.RowIndex].Cells[0].Value;
            string value = (string)dgvProperties.Rows[e.RowIndex].Cells[1].Value;
            
            if(dgvProperties.Tag is TFTControl con)
            {
                switch (name)
                {
                    case "X":
                        if (int.TryParse(value, out int x))
                            con.X = x;
                        break;
                    case "Y":
                        if (int.TryParse(value, out int y))
                            con.Y = y;
                        break;
                    case "Width":
                        if (int.TryParse(value, out int w))
                            con.Width = w;
                        break;
                    case "Height":
                        if (int.TryParse(value, out int h))
                            con.Height = h;
                        break;
                    case "Text":
                        con.Text = value;
                        break;
                    case "FontSize":
                        if (float.TryParse(value, out float Fsize))
                            con.FontSize = Fsize;
                        break;
                    case "BackgroundColor":
                        con.BackgroundColor = Color.FromName(value);
                        break;
                    case "ForegroundColor":
                        con.ForegroundColor = Color.FromName(value);
                        break;
                }
                if (con is TFTRectangle rect)
                {
                    //nothing
                }
                else if (con is TFTButton btn)
                {
                    if(name == "AutoSize")
                    {
                        if (bool.TryParse(value, out bool autosize))
                            btn.AutoSize = autosize;
                    }
                }
                else if (con is TFTLabel lbn)
                {
                    //nothing
                }
                TFTCan.RedrawControls();
            }
        }

        private void btnDeleteControl_Click(object sender, EventArgs e)
        {
            if(selected != null)
            {
                TFTCan.RemoveControl(selected);
                dgvProperties.DataSource = null;
            }
        }
    }
}
