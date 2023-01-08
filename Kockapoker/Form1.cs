namespace Kockapoker
{
    public partial class Form1 : Form
    {
        static int[] kockak = { 1, 2, 3, 4, 5 };
        static int[] kivalasztott_kockak = { 0, 0, 0, 0, 0 }; //ide mentjük el a kiválasztott kockák értékeit
        static int dobasok = 3; //3szor lehet újradobni
        static int korok = 15; //15 kör van
        static int[] pontszam = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        public Form1()
        {
            InitializeComponent();
            //nem lehet lenntartani az értékeket inicializáláskór
            CHB_Dobott1.Enabled = false; 
            CHB_Dobott2.Enabled = false;
            CHB_Dobott3.Enabled = false;
            CHB_Dobott4.Enabled = false;
            CHB_Dobott5.Enabled = false;
            string[] Kategoria = { "Egyesek", "Kettesek", "Hármasok", "Négyesek", "Ötösök", "Hatosok", 
                                   "Pár", "Terc", "Póker", "Full House", "Kis sor", "Nagy sor", "Yahtzee", "Összeg",
                                   "Felsõ sor", "Bónusz"};
            for (int i = 0; i < Kategoria.Length; i++)
            {
                DGV_Tablazat.Rows.Add(Kategoria[i]);
            }
            DGV_Tablazat.Enabled = false;
            LB_Dobasok.Text = "Dobások: " + dobasok.ToString();
            LB_Korok.Text = "Kör: " + (16-korok).ToString() + ". / 15.";
        }

        private void BTN_Dobas_Click(object sender, EventArgs e)
        {
            DGV_Tablazat.Enabled = true;
            if (dobasok != 0)
            {
                dobasok--;
                LB_Dobasok.Text = "Dobások: " + dobasok.ToString();

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

        private void Kiertekeles()
        {
            // megszámoljuk a dobott számok darabszámát
            int[] darabszam = { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < darabszam.Length; i++)
            {
                darabszam[i] = kockak.Count(x => x == i + 1);
            }
            List<int> Pontok = new List<int>();
            //felsõ sor:
            //egyesek
            Pontok.Add(darabszam[0] * 1);
            //kettesek
            Pontok.Add(darabszam[1] * 2);
            //hármasok
            Pontok.Add(darabszam[2] * 3);
            //négyesek
            Pontok.Add(darabszam[3] * 4);
            //ötösok
            Pontok.Add(darabszam[4] * 5);
            //hatosok:
            Pontok.Add(darabszam[5] * 6);
            //alsó sor:
            //pár
            Pontok.Add(darabszam.Count(x => x >= 2) >= 1 ? kockak.Sum() : 0);
            //terc
            Pontok.Add(darabszam.Count(x => x >= 3) >= 1 ? kockak.Sum() : 0);
            //póker
            Pontok.Add(darabszam.Count(x => x >= 4) >= 1 ? kockak.Sum() : 0);
            //full house:
            Pontok.Add(darabszam.Count(x => x == 2) == 1 && darabszam.Count(x => x == 3) == 1 ? 25 : 0);
            //kis sor:
            int[] rendezett = { kockak[0], kockak[1], kockak[2], kockak[3], kockak[4] };
            Array.Sort(rendezett);
            string sor = rendezett[0].ToString() + rendezett[1].ToString() + rendezett[2].ToString() + rendezett[3].ToString() + rendezett[4].ToString();
            Pontok.Add(sor.Contains("1234") || sor.Contains("2345") || sor.Contains("3456") ? 30 : 0);
            //nagy sor:
            Pontok.Add(sor == "12345" || sor == "23456" ? 40 : 0);
            //yahtzee:
            Pontok.Add(darabszam.Count(x => x == 5) == 1 ? 50 : 0);
            //összeg:
            Pontok.Add(kockak.Sum());
            //kitölti a táblázatot:
            for (int i = 0; i < Pontok.Count; i++)
            {
                DGV_Tablazat[1, i].Value = Pontok[i];
                if (pontszam[i] != -1) DGV_Tablazat[1, i].Value = pontszam[i].ToString();
            }
            //eltárolja és továbbadja a kiválasztott cellát a "Kivalasztas" metódusnak
        }

        private void Kivalasztas(object sender, DataGridViewCellEventArgs e)
        {
            //eltárolja a kiválasztott cella pontját
            if (e.RowIndex < 14 && e.ColumnIndex == 1)
            {
                if(pontszam[e.RowIndex] == -1)
                {
                    pontszam[e.RowIndex] = int.Parse(DGV_Tablazat[e.ColumnIndex, e.RowIndex].Value.ToString());
                    DGV_Tablazat[e.ColumnIndex, e.RowIndex].Style.Font = new Font(DGV_Tablazat.Font, FontStyle.Bold);
                    //alaphelyzetbe állás
                    BTN_Dobas.Enabled = true;
                    CHB_Dobott1.Enabled = false;
                    CHB_Dobott2.Enabled = false;
                    CHB_Dobott3.Enabled = false;
                    CHB_Dobott4.Enabled = false;
                    CHB_Dobott5.Enabled = false;
                    CHB_Dobott1.Checked = false;
                    CHB_Dobott2.Checked = false;
                    CHB_Dobott3.Checked = false;
                    CHB_Dobott4.Checked = false;
                    CHB_Dobott5.Checked = false;
                    for (int i = 0; i < DGV_Tablazat.Rows.Count; i++)
                    {
                        if (!DGV_Tablazat[1,e.RowIndex].Style.Font.Bold) DGV_Tablazat[1, i].Value = null;
                    }
                    DGV_Tablazat.Enabled = false;
                    dobasok = 3;
                    korok--;
                    LB_Dobasok.Text = "Dobások: " + dobasok.ToString();
                    LB_Korok.Text = "Kör: " + (16 - korok).ToString() + ". / 15.";
                    if (korok == 1)
                    {
                        BTN_Dobas.Enabled = false;
                        int felso = 0; 
                        for (int i = 0; i < 6; i++)
                        {
                            felso += pontszam[i];
                        }
                        int bonusz = 0;
                        if (felso > 63) bonusz = 35;
                        int also = 0;
                        for (int i = 6; i < pontszam.Length; i++)
                        {
                            also += pontszam[i];
                        }
                        int Vegeredmeny = felso + bonusz + also + 2;
                        DGV_Tablazat[1, 14].Value = felso.ToString();
                        DGV_Tablazat[1, 15].Value = bonusz.ToString();
                        LB_Vegeredmeny.Text = "Végeredmény: " + Vegeredmeny;
                    }
                }
            }
        }
    }
}