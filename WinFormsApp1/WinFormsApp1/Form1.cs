using WinFormsApp1.SOLID;

namespace WinFormsApp1
{
    //public partial class Form1 : Form
    //{
    //    //global variable
    //    string secilenLogTipi;
    //    ILog iLog;

    //    public Form1()
    //    {
    //        InitializeComponent();

    //    }

    //    private void btnKaydet_Click(object sender, EventArgs e)
    //    {

    //        LogFactory factory = new LogFactory();
    //        iLog = factory.yeniNesneOlustur(secilenLogTipi);
    //        Logger logger = new Logger(iLog);
    //        lblSonuc.Text = logger.LogKaydet(txtMesaj.Text);

    //    }

    //    private void cmbLogTipi_SelectedIndexChanged(object sender, EventArgs e)
    //    {
    //        secilenLogTipi = cmbLogTipi.SelectedItem.ToString();
    //    }
    //}

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOdemeTipi.Items.AddRange(new string[] { "Kredi Kartý", "Banka Havalesi", "PayPal" });
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            string odemeTipi = cmbOdemeTipi.SelectedItem?.ToString();
            decimal tutar;

            if (string.IsNullOrEmpty(odemeTipi))
            {
                lblSonuc.Text = "Lütfen bir ödeme tipi seçin.";
                return;
            }

            if (!decimal.TryParse(txtTutar.Text, out tutar))
            {
                lblSonuc.Text = "Geçersiz tutar giriþi.";
                return;
            }


            string sonuc = OdemeYap(odemeTipi, tutar);
            lblSonuc.Text = sonuc;
        }

        private string OdemeYap(string odemeTipi, decimal tutar)
        {

            return $"{tutar} TL {odemeTipi} ile ödendi.";
        }
    }
}
