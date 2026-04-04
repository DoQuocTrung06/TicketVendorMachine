using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using QRCoder; 

namespace TicketVendorMachine
{
    public partial class Form1 : Form
    {
        
        string connectionString = @"Data Source=(local);Initial Catalog=SmartTicketingDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRoutes();
        }
        private void lblPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadRoutes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT RouteID, RouteName, Price FROM Routes";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbRoutes.DataSource = dt;
                    cbRoutes.DisplayMember = "RouteName";
                    cbRoutes.ValueMember = "RouteID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi Hệ Thống");
            }
        }

        
        private void cbRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoutes.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cbRoutes.SelectedItem;
                lblPrice.Text = "Giá vé: " + drv["Price"].ToString() + " VNĐ";
            }
        }

        
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cbRoutes.SelectedItem == null) return;

            DataRowView drv = (DataRowView)cbRoutes.SelectedItem;
            string routeName = drv["RouteName"].ToString();
            string price = drv["Price"].ToString();

            // Tạo mã QR
            string qrData = $"Thanh_Toan_{routeName}_{price}VND_Momo";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            picQR.Image = qrCode.GetGraphic(5);

            
            lblStatus.Text = "Đang chờ bạn quét mã (Giả lập 5s)...";
            lblStatus.ForeColor = Color.Black;
            lblStatus.Visible = true;

            btnPay.Visible = false;

            btnCancel.Visible = true;

            picLogoMoMo.Visible = true;
            picLogoVNPay.Visible = true;
            lblPaymentMethods.Visible = true;

            timerFakeAPI.Start();
        }


        private void InVeTuDong()
        {
            try
            {
                DataRowView drv = (DataRowView)cbRoutes.SelectedItem;
                int routeId = Convert.ToInt32(drv["RouteID"]);
                string routeName = drv["RouteName"].ToString();
                string price = drv["Price"].ToString();

                
                int amountPaid = Convert.ToInt32(drv["Price"]);

             
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string query = "INSERT INTO Tickets (RouteID, AmountPaid, IssueDate, PaymentMethod, Status) VALUES (@RouteID, @AmountPaid, @IssueDate, 'E-Wallet', 'Paid'); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RouteID", routeId);
                    cmd.Parameters.AddWithValue("@AmountPaid", amountPaid); 
                    cmd.Parameters.AddWithValue("@IssueDate", DateTime.Now);

                    
                    int ticketId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Hiển thị Bill
                    pnlBill.Visible = true;

                    lblPaymentMethods.Visible = false;lblBillDetails.Text = $"=== VÉ TÀU BEN THANH METRO ===\n\n" +
                                          $"Mã vé: #{ticketId}\n" +
                                          $"Tuyến: {routeName}\n" +
                                          $"Giá tiền: {price} VNĐ\n" +
                                          $"Thời gian: {DateTime.Now}\n" +
                                          $"Trạng thái: ĐÃ THANH TOÁN (QR)\n\n" +
                                          $"Chúc quý khách chuyến đi vui vẻ!";

                    
                    cbRoutes.Visible = false;
                    lblPrice.Visible = false;
                    btnPay.Visible = false;

                    
                    lblStatus.Visible = false;

                   
                    timerReset.Stop(); 
                    timerReset.Start(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý vé: " + ex.Message, "Lỗi");
            }
        }

        private void lblBillDetails_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void timerReset_Tick(object sender, EventArgs e)
        {
            
            pnlBill.Visible = false;
            
            lblStatus.Visible = false; 

            
            cbRoutes.Visible = true;
            lblPrice.Visible = true;
            btnPay.Visible = true;

           
            timerReset.Stop();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private async void timerFakeAPI_Tick(object sender, EventArgs e)
        {
            
            timerFakeAPI.Stop();

            btnCancel.Visible = false;
            
            picQR.Image = null;

            lblPrice.Visible = false;
            cbRoutes.Visible = false;
            picLogoMoMo.Visible = false;
            picLogoVNPay.Visible = false;
            lblPaymentMethods.Visible = false;

            lblStatus.Text = "Thanh toán thành công! Đang in vé...";
            lblStatus.ForeColor = Color.Green;

            
            await System.Threading.Tasks.Task.Delay(1500);

            
            InVeTuDong();
        }

        private void pnlBill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
  
            timerFakeAPI.Stop();

            
            picQR.Image = null;
            lblStatus.Visible = false;
            btnCancel.Visible = false;


            picLogoMoMo.Visible = false;
            picLogoVNPay.Visible = false;
            lblPaymentMethods.Visible = false;

            cbRoutes.Visible = true;
            lblPrice.Visible = true;
            btnPay.Visible = true;

            
            cbRoutes.SelectedIndex = -1;
            lblPrice.Text = "Giá vé: 0 VNĐ";
        }

        private void lblStatus_Click_1(object sender, EventArgs e)
        {

        }

        private void picLogoVNPay_Click(object sender, EventArgs e)
        {

        }

        private void lblPaymentMethods_Click(object sender, EventArgs e)
        {

        }

        private void picLogoMoMo_Click(object sender, EventArgs e)
        {

        }
    }
}