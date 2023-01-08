namespace Kockapoker
{
    public partial class Form1 : Form
    {
        static int[] kockak = { 1, 2, 3, 4, 5 };
        static int[] kivalasztott_kockak = { 0, 0, 0, 0, 0 }; //ide mentjük el a kiválasztott kockák értékeit
        static int dobasok = 3; //3szor lehet újradobni
        static int korok = 15; //15 kör van
        public Form1()
        {
            InitializeComponent();
            LB_Dobasok.Text = dobasok.ToString();
            // az értékeket a dobás elött nem lehet lenntartani
            CHB_Dobott1.Enabled = false; 
            CHB_Dobott2.Enabled = false;
            CHB_Dobott3.Enabled = false;
            CHB_Dobott4.Enabled = false;
            CHB_Dobott5.Enabled = false;
        }

        private void BTN_Dobas_Click(object sender, EventArgs e)
        {

            if (dobasok != 0)
            {
                dobasok--;
                LB_Dobasok.Text = dobasok.ToString();

                //kockák kiválasztása:
                if (LB_Dobott1.Text != "0")
                {
                    if (CHB_Dobott1.Checked) kivalasztott_kockak[0] = kockak[0];
                    if (CHB_Dobott2.Checked) kivalasztott_kockak[1] = kockak[1];
                    if (CHB_Dobott3.Checked) kivalasztott_kockak[2] = kockak[2];
                    if (CHB_Dobott4.Checked) kivalasztott_kockak[3] = kockak[3];
                    if (CHB_Dobott5.Checked) kivalasztott_kockak[4] = kockak[4];
                }

                //5db kocka dobása:
                Random rnd = new Random();
                for (int i = 0; i < 5; i++)
                {
                    kockak[i] = rnd.Next(1, 7);
                }
                if (CHB_Dobott1.Checked) kockak[0] = kivalasztott_kockak[0];
                if (CHB_Dobott2.Checked) kockak[1] = kivalasztott_kockak[1];
                if (CHB_Dobott3.Checked) kockak[2] = kivalasztott_kockak[2];
                if (CHB_Dobott4.Checked) kockak[3] = kivalasztott_kockak[3];
                if (CHB_Dobott5.Checked) kockak[4] = kivalasztott_kockak[4];

                //dobott értékek kiírása:
                LB_Dobott1.Text = kockak[0].ToString();
                LB_Dobott2.Text = kockak[1].ToString();
                LB_Dobott3.Text = kockak[2].ToString();
                LB_Dobott4.Text = kockak[3].ToString();
                LB_Dobott5.Text = kockak[4].ToString();

                CHB_Dobott1.Enabled = true;
                CHB_Dobott2.Enabled = true;
                CHB_Dobott3.Enabled = true;
                CHB_Dobott4.Enabled = true;
                CHB_Dobott5.Enabled = true;


                Kiertekeles();
            }
            if (dobasok == 0) BTN_Dobas.Enabled = false;
            //elindul a kiértékelés
        }

        private static void Kiertekeles()
        {
            //kitölti a táblázatot
            //eltárolja és továbbadja a kiválasztott cellát a "Kivalasztas" metódusnak
        }

        private static void Kivalasztas(int index)
        {
            //eltárolja a kiválasztott cella pontját
        }
    }
}