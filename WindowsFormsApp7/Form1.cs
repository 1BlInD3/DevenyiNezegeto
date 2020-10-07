using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Threading;
//using _Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        string elseje = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ellenallasMeresDataSet2.Hal2EllenallasTemp' table. You can move, or remove it, as needed.
            this.hal2EllenallasTempTableAdapter2.Fill(this.ellenallasMeresDataSet2.Hal2EllenallasTemp); //rajzszam
            //this.hal2EllenallasTempTableAdapter1.Fill(this.ellenallasMeresDataSet1.Hal2EllenallasTemp); //regi
            //proba
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datum = fromDate.Value.Year.ToString() + "-" + fromDate.Value.Month.ToString() + "-" + fromDate.Value.Day.ToString();
            string datum2 = toDate.Value.Year.ToString() + "-" + toDate.Value.Month.ToString() + "-" + (toDate.Value.Day+1).ToString();

            DateTime parseDate;
            DateTime parseDate2;
            if (setDayCheck.Checked == true)
            {
                // MessageBox.Show("Bejöttem");
                //

                datum2 = "";
                if ((fromDate.Value.Month == 1 || fromDate.Value.Month == 3 || fromDate.Value.Month == 5 || fromDate.Value.Month == 7 || fromDate.Value.Month == 8 ||
                    fromDate.Value.Month == 10) && fromDate.Value.Day == 31)
                {
                    datum2 = fromDate.Value.Year.ToString() + "-" + (fromDate.Value.Month + 1).ToString() + "-" + "1";
                }
                else if (fromDate.Value.Month == 12 && fromDate.Value.Day == 31)
                {
                    datum2 = (fromDate.Value.Year + 1).ToString() + "-" + "1" + "-" + "1";
                }
                else if ((fromDate.Value.Month == 4 || fromDate.Value.Month == 6 || fromDate.Value.Month == 9 || fromDate.Value.Month == 11)
                    && fromDate.Value.Day == 30)
                {
                    datum2 = fromDate.Value.Year.ToString() + "-" + (fromDate.Value.Month + 1).ToString() + "-1";
                }
                else if (DateTime.IsLeapYear(fromDate.Value.Year) && fromDate.Value.Month == 2 && fromDate.Value.Day == 29)
                {
                    datum2 = fromDate.Value.Year.ToString() + "-" + (fromDate.Value.Month + 1).ToString() + "-1";
                }
                else if (!DateTime.IsLeapYear(fromDate.Value.Year) && fromDate.Value.Month == 2 && fromDate.Value.Day == 28)
                {
                    datum2 = fromDate.Value.Year.ToString() + "-" + (fromDate.Value.Month + 1).ToString() + "-1";
                }
                else
                {
                    datum2 = fromDate.Value.Year.ToString() + "-" + fromDate.Value.Month.ToString() + "-" + (fromDate.Value.Day + 1).ToString();
                }

                // string datum2 = fromDate.Value.Year.ToString() + "-" + fromDate.Value.Month.ToString() + "-" + (fromDate.Value.Day+1).ToString();
                //this.hal2EllenallasTempTableAdapter1.Fill(this.ellenallasMeresDataSet1.Hal2EllenallasTemp);
                parseDate = DateTime.Parse(datum);
                parseDate2 = DateTime.Parse(datum2);
                // MessageBox.Show($"{parseDate2 }");
               // this.hal2EllenallasTempTableAdapter1.FillBy(this.ellenallasMeresDataSet1.Hal2EllenallasTemp, parseDate, parseDate2); régi
                this.hal2EllenallasTempTableAdapter2.FillBy2(this.ellenallasMeresDataSet2.Hal2EllenallasTemp, parseDate, parseDate2);
            }
            else if (showAllDay.Checked == true)
            {
                this.hal2EllenallasTempTableAdapter2.Fill(this.ellenallasMeresDataSet2.Hal2EllenallasTemp);
            }
            else
            {
                parseDate = DateTime.Parse(datum);
                parseDate2 = DateTime.Parse(datum2);
                //MessageBox.Show($"{toDate.Value}");
                //this.hal2EllenallasTempTableAdapter1.FillBy(this.ellenallasMeresDataSet1.Hal2EllenallasTemp, parseDate, parseDate2);
                this.hal2EllenallasTempTableAdapter2.FillBy2(this.ellenallasMeresDataSet2.Hal2EllenallasTemp, parseDate, parseDate2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // this.hal2EllenallasTempTableAdapter1.Fill(this.ellenallasMeresDataSet1.Hal2EllenallasTemp);
            // this.hal2EllenallasTempTableAdapter1.FillBy(this.ellenallasMeresDataSet1.Hal2EllenallasTemp, "2012-01-01", "2016-01-01");

            if ((fromDate.Value.Year == toDate.Value.Year)&& (fromDate.Value.Month == toDate.Value.Month)&& (fromDate.Value.Day == toDate.Value.Day))
            { 
                this.hal2EllenallasTempTableAdapter1.FillBy1(this.ellenallasMeresDataSet1.Hal2EllenallasTemp);
                MessageBox.Show("Én futottam le");
            }
            else
                this.hal2EllenallasTempTableAdapter1.FillBy(this.ellenallasMeresDataSet1.Hal2EllenallasTemp,fromDate.Value,toDate.Value);


        }

        private void todayBtn_Click(object sender, EventArgs e)
        {
            // this.hal2EllenallasTempTableAdapter1.FillBy1(this.ellenallasMeresDataSet1.Hal2EllenallasTemp); //regi
            this.hal2EllenallasTempTableAdapter2.FillBy1(this.ellenallasMeresDataSet2.Hal2EllenallasTemp); //rajzszam
            fromDate.Value = DateTime.Now;
            toDate.Value = DateTime.Now;
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            if (dataGridView1.Rows.Count>0) 
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
               // _Excel.Application excel = new _Excel.Application();
                excel.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }
            t.Abort();
        }

        private void setDayCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (setDayCheck.Checked == false)
            {
                toDate.Enabled = true;
                label2.Enabled = true;
                showAllDay.Enabled = true;
            }
            else 
            {
                toDate.Enabled = false;
                label2.Enabled = false;
                showAllDay.Checked = false;
                showAllDay.Enabled = false;
            }
        }

        private void showAllDay_CheckedChanged(object sender, EventArgs e)
        {
            if (showAllDay.Checked == false)
            {
                fromDate.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                setDayCheck.Enabled = true;
                toDate.Enabled = true;
            }
            else 
            {
                fromDate.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                setDayCheck.Enabled = false;
                toDate.Enabled = false;
            }
        }
        public void StartForm() 
        {
            System.Windows.Forms.Application.Run(new Form2());
        }

    }
}
