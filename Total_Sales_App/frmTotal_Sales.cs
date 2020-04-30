using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Sales_App
{
    public partial class frmTotal_Sales : Form
    {
        public frmTotal_Sales()
        {
            InitializeComponent();

            lstRegionalSales.Items.Add("Month       Kwazulu-Natal sales(R)      Gauteng sales(R)      Western Cape sales(R)");

            int[,] salesArray = new int[6, 3]
            {
                { 120000, 90000, 65000 },
                { 190000, 85000, 64000 },
                { 175000, 80000, 71000 },
                { 188000, 83000, 67000 },
                { 125000, 87000, 65000 },
                { 163000, 80000, 64000 },
            };

            int iCount = 1;
            double dTotalSales = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dTotalSales = dTotalSales + salesArray[i, j];
                }
                lstRegionalSales.Items.Add((iCount).ToString() + "              "+salesArray[i,0].ToString()+"                            "+ salesArray[i,1].ToString()+"                      "+salesArray[i,2].ToString() + "\n");
                iCount++;
            }

            double dKznSales = 0;
            double dGautengSales = 0;
            double dWesternSales = 0;

            for (int i = 0; i < 6; i++)
            {
                dKznSales = dKznSales + salesArray[i, 0];
                dGautengSales = dGautengSales + salesArray[i, 1];
                dWesternSales = dWesternSales + salesArray[i, 2];
                
            }

            double dKznPercentage = (dKznSales / dTotalSales)*100;
            double dGautengPercentage = (dGautengSales / dTotalSales)*100;
            double dWesternPercentage = (dWesternSales / dTotalSales)*100;

            lstRegionalSales.Items.Add("-------------------------------------------------------------------------------------------------------");


            lstRegionalSales.Items.Add("Total Sales= " + "  " + Math.Round(dKznPercentage) +"%                              "+ Math.Round(dKznPercentage) +"%                            "+ Math.Round(dWesternPercentage)+"%");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
