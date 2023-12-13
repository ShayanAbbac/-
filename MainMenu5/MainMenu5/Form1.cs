using System.Globalization;

namespace MainMenu5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.Font = new Font("Tahoma", 8, FontStyle.Underline);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font("Tahoma", 8, FontStyle.Regular);
            label4.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnBackFault_Click(object sender, EventArgs e)
        {
            this.pnlFault.Visible = false;
        }



        private void btnBackConfig_Click(object sender, EventArgs e)
        {
            this.pnlConfiguration.Visible = false;
        }

        private void btnBackAcc_Click(object sender, EventArgs e)
        {
            this.pnlAcc.Visible = false;
        }

        private void btnBackPerform_Click(object sender, EventArgs e)
        {
            this.pnlPerformance.Visible = false;
        }

        private void btnBackSecurity_Click(object sender, EventArgs e)
        {
            this.pnlSecurity.Visible = false;
        }

        private void btnBackCommand_Click(object sender, EventArgs e)
        {
            this.pnlCommand.Visible = false;
        }

        private void btnBackClient_Click(object sender, EventArgs e)
        {
            this.pnlClient.Visible = false;
        }

        private void btnBackTicket_Click(object sender, EventArgs e)
        {
            this.pnlTicket.Visible = false;
        }

        private void btnBackReport_Click(object sender, EventArgs e)
        {
            this.pnlReport.Visible = false;
        }

        private void btnBackMaintanance_Click(object sender, EventArgs e)
        {
            this.pnlMaintanance.Visible = false;
        }

        private void mainButtons1_Click(object sender, EventArgs e)
        {
            Panel[] pnl = new Panel[10] { pnlFault, pnlConfiguration,pnlAcc,pnlPerformance,
                pnlSecurity,pnlCommand,pnlClient,pnlTicket,pnlReport,pnlMaintanance };
            for (int i = 0; i < 10; i++)
            {
                pnl[i].Visible = false;
            }

            pnlFault.Location = new Point(259, 56);
            pnlFault.Size = new Size(1128, 708);
            this.pnlFault.Visible = true;
        }

        private void mainButtons2_Click(object sender, EventArgs e)
        {
            Panel[] pnl = new Panel[10] { pnlFault, pnlConfiguration,pnlAcc,pnlPerformance,
                pnlSecurity,pnlCommand,pnlClient,pnlTicket,pnlReport,pnlMaintanance };
            for (int i = 0; i < 10; i++)
            {
                pnl[i].Visible = false;
            }

            pnlConfiguration.Location = new Point(259, 56);
            pnlConfiguration.Size = new Size(1128, 708);
            this.pnlConfiguration.Visible = true;
        }

        private void mainButtons3_Click(object sender, EventArgs e)
        {
            Panel[] pnl = new Panel[10] { pnlFault, pnlConfiguration,pnlAcc,pnlPerformance,
                pnlSecurity,pnlCommand,pnlClient,pnlTicket,pnlReport,pnlMaintanance };
            for (int i = 0; i < 10; i++)
            {
                pnl[i].Visible = false;
            }

            pnlAcc.Location = new Point(259, 56);
            pnlAcc.Size = new Size(1128, 708);
            this.pnlAcc.Visible = true;
        }

        private void mainButtons4_Click(object sender, EventArgs e)
        {
            Panel[] pnl = new Panel[10] { pnlFault, pnlConfiguration,pnlAcc,pnlPerformance,
                pnlSecurity,pnlCommand,pnlClient,pnlTicket,pnlReport,pnlMaintanance };
            for (int i = 0; i < 10; i++)
            {
                pnl[i].Visible = false;
            }

            pnlPerformance.Location = new Point(259, 56);
            pnlPerformance.Size = new Size(1128, 708);
            this.pnlPerformance.Visible = true;
        }

        private void mainButtons5_Click(object sender, EventArgs e)
        {
            Panel[] pnl = new Panel[10] { pnlFault, pnlConfiguration,pnlAcc,pnlPerformance,
                pnlSecurity,pnlCommand,pnlClient,pnlTicket,pnlReport,pnlMaintanance };
            for (int i = 0; i < 10; i++)
            {
                pnl[i].Visible = false;
            }

            pnlSecurity.Location = new Point(259, 56);
            pnlSecurity.Size = new Size(1128, 708);
            this.pnlSecurity.Visible = true;
        }

        private void mainButtons6_Click(object sender, EventArgs e)
        {
            Panel[] pnl = new Panel[10] { pnlFault, pnlConfiguration,pnlAcc,pnlPerformance,
                pnlSecurity,pnlCommand,pnlClient,pnlTicket,pnlReport,pnlMaintanance };
            for (int i = 0; i < 10; i++)
            {
                pnl[i].Visible = false;
            }

            pnlCommand.Location = new Point(259, 56);
            pnlCommand.Size = new Size(1128, 708);
            this.pnlCommand.Visible = true;
        }

        private void mainButtons7_Click(object sender, EventArgs e)
        {

            Panel[] pnl = new Panel[10] { pnlFault, pnlConfiguration,pnlAcc,pnlPerformance,
                pnlSecurity,pnlCommand,pnlClient,pnlTicket,pnlReport,pnlMaintanance };
            for (int i = 0; i < 10; i++)
            {
                pnl[i].Visible = false;
            }

            pnlClient.Location = new Point(259, 56);
            pnlClient.Size = new Size(1128, 708);
            this.pnlClient.Visible = true;
        }

        private void mainButtons8_Click(object sender, EventArgs e)
        {
            Panel[] pnl = new Panel[10] { pnlFault, pnlConfiguration,pnlAcc,pnlPerformance,
                pnlSecurity,pnlCommand,pnlClient,pnlTicket,pnlReport,pnlMaintanance };
            for (int i = 0; i < 10; i++)
            {
                pnl[i].Visible = false;
            }

            pnlTicket.Location = new Point(259, 56);
            pnlTicket.Size = new Size(1128, 708);
            this.pnlTicket.Visible = true;
        }

        private void mainButtons9_Click(object sender, EventArgs e)
        {
            Panel[] pnl = new Panel[10] { pnlFault, pnlConfiguration,pnlAcc,pnlPerformance,
                pnlSecurity,pnlCommand,pnlClient,pnlTicket,pnlReport,pnlMaintanance };
            for (int i = 0; i < 10; i++)
            {
                pnl[i].Visible = false;
            }

            pnlReport.Location = new Point(259, 56);
            pnlReport.Size = new Size(1128, 708);
            this.pnlReport.Visible = true;
        }

        private void mainButtons10_Click(object sender, EventArgs e)
        {
            Panel[] pnl = new Panel[10] { pnlFault, pnlConfiguration,pnlAcc,pnlPerformance,
                pnlSecurity,pnlCommand,pnlClient,pnlTicket,pnlReport,pnlMaintanance };
            for (int i = 0; i < 10; i++)
            {
                pnl[i].Visible = false;
            }

            pnlMaintanance.Location = new Point(259, 56);
            pnlMaintanance.Size = new Size(1128, 708);
            this.pnlMaintanance.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            PersianCalendar pc = new PersianCalendar();
            lblDate.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
        }
    }
}