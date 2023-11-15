namespace dogaSzlobodnyik
{
    public partial class MainForm
    {
        float elsoadat;
        float masodikadat;
        char muveletjel;
        public MainForm()
        {
            InitializeComponent();
            btnKoszonj.Click += BtnKoszonj_Click;
            lblPiros.Click += LblPiros_Click;
            lblZold.Click += LblZold_Click;
            lblKek.Click += LblKek_Click;
            btnPlusz.Click += BtnPlusz_Click;
            btnAlaphelyzet.Click += BtnAlaphelyzet_Click;
            btnKilepes.Click += BtnKilepes_Click;
            btnSzorzas.Click += BtnSzorzas_Click;
            btnMinusz.Click += BtnMinusz_Click;
            btnOsztas.Click += BtnOsztas_Click;
            btnSzamolj.Click += BtnSzamolj_Click;
        }

        private void BtnSzamolj_Click(object? sender, EventArgs e)
        {
            if (muveletjel==)
            {

            }

        }

        private void BtnOsztas_Click(object? sender, EventArgs e)
        {
            btnMinusz.BackColor = Color.Silver;
            btnOsztas.BackColor = Color.Yellow;
            btnSzorzas.BackColor = Color.Silver;
            btnPlusz.BackColor = Color.Silver;
            muveletjel = '/';

        }

        private void BtnMinusz_Click(object? sender, EventArgs e)
        {
            btnMinusz.BackColor = Color.Yellow;
            btnOsztas.BackColor = Color.Silver;
            btnSzorzas.BackColor = Color.Silver;
            btnPlusz.BackColor = Color.Silver;
            muveletjel = '-';
        }

        private void BtnSzorzas_Click(object? sender, EventArgs e)
        {
            btnMinusz.BackColor = Color.Silver;
            btnOsztas.BackColor = Color.Silver;
            btnSzorzas.BackColor = Color.Yellow;
            btnPlusz.BackColor = Color.Silver;
            muveletjel = '*';
        }

        private void BtnKilepes_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAlaphelyzet_Click(object? sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnPlusz_Click(object? sender, EventArgs e)
        {
            btnMinusz.BackColor = Color.Silver;
            btnOsztas.BackColor = Color.Silver;
            btnSzorzas.BackColor = Color.Silver;
            btnPlusz.BackColor = Color.Yellow;
            muveletjel = '+';

        }

        private void LblKek_Click(object? sender, EventArgs e)
        {
            BackColor = lblKek.BackColor;
        }

        private void LblZold_Click(object? sender, EventArgs e)
        {
            BackColor = lblZold.BackColor;
        }

        private void LblPiros_Click(object? sender, EventArgs e)
        {
            BackColor = lblPiros.BackColor;
        }

        private void BtnKoszonj_Click(object? sender, EventArgs e)
        {
            string nev = $"Szia {tbxNev.Text}";

            if (tbxNev.Text == "###UDVOZLES###")
            {
                MessageBox.Show("Töltse ki a név mezõt!");
            }
            else
            { lblUdvozles.Text = nev; }
        }

        private void tbxElsoadat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}