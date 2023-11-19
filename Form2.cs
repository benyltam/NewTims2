using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTims
{
    public partial class Form2 : Form
    {
        int myCounter = 3;
        public Form2()
        {
            InitializeComponent();
        }

        private void SetDockPadding(object sender, EventArgs e)
        {
            // Dock the button in the panel.
            button1.Dock = System.Windows.Forms.DockStyle.Fill;

            // Reset the counter if it is greater than 5.
            if (myCounter > 5)
            {
                myCounter = 0;
            }

            // Set the appropriate DockPadding and display
            // which one was set on the button face.
            switch (myCounter)
            {
                case 0:
                    panel1.DockPadding.All = 0;
                    button1.Text = "Start";
                    break;
                case 1:
                    panel1.DockPadding.Top = 10;
                    button1.Text = "Top";
                    break;
                case 2:
                    panel1.DockPadding.Bottom = 10;
                    button1.Text = "Bottom";
                    break;
                case 3:
                    panel1.DockPadding.Left = 10;
                    button1.Text = "Left";
                    break;
                case 4:
                    panel1.DockPadding.Right = 10;
                    button1.Text = "Right";
                    break;
                case 5:
                    panel1.DockPadding.All = 20;
                    button1.Text = "All";
                    break;
            }

            // Increment the counter.
            myCounter += 1;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class DataGridPanel : Panel
    {
        //public SfDataGrid DataGrid = new SfDataGrid();
        public DataGridPanel() : base()
        {
            this.DockPadding.All = 1;
            this.BackColor = Color.Blue;
            this.BorderStyle = BorderStyle.None;
            //this.DataGrid.Dock = DockStyle.Fill;
            //this.DataGrid.Style.BorderStyle = BorderStyle.None;
            //MethodInfo method = this.DataGrid.GetType().GetMethod("UpdateStyles", BindingFlags.NonPublic | BindingFlags.Instance);
            //method.Invoke(this.DataGrid, null);
            //this.Controls.Add(this.DataGrid);
        }

    }
}
