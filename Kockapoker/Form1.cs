namespace Kockapoker
{
    public partial class Form1 : Form
    {
        static int[] kockak = { 1, 2, 3, 4, 5 };
        static int[] kivalasztott_kockak = { 0, 0, 0, 0, 0 }; //ide mentjük el a kiválasztott kockák értékeit
        static int dobasok = 10; //3szor lehet újradobni
        static int korok = 15; //15 kör van
        public Form1()
        {
            InitializeComponent();
            LB_Dobasok.Text = dobasok.ToString();
            //nem lehet lenntartani az értékeket inicializáláskór
            CHB_Dobott1.Enabled = false; 
            CHB_Dobott2.Enabled = false;
            CHB_Dobott3.Enabled = false;
            CHB_Dobott4.Enabled = false;
            CHB_Dobott5.Enabled = false;
            string[] Kategoria = { "Egyesek", "Kettesek", "Hármasok", "Négyesek", "Ötösök", "Hatosok",
                                   "Pár", "Terc", "Póker", "Full House", "Kis sor", "Nagy sor", "Yahtzee", "Összeg"};
            for (int i = 0; i < Kategoria.Length; i++)
            {
                DGV_Tablazat.Rows.Add(Kategoria[i]);
            }
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
            Pontok.Add(darabszam[0]);
            //Pontok.Add(kockak.Count(x => x == 1));
            //kettesek
            Pontok.Add(darabszam[1]*2);
            //Pontok.Add(kockak.Count(x => x == 2)*2);
            //hármasok
            Pontok.Add(darabszam[2]*3);
            //Pontok.Add(kockak.Count(x => x == 3)*3);
            //négyesek
            Pontok.Add(darabszam[3]*4);
            //Pontok.Add(kockak.Count(x => x == 4)*4);
            //ötösok
            Pontok.Add(darabszam[4]*5);
            //Pontok.Add(kockak.Count(x => x == 5)*5);
            //hatosok:
            Pontok.Add(darabszam[5]*6);
            //Pontok.Add(kockak.Count(x => x == 6)*6);
            //alsó sor:
            //pár
            Pontok.Add(darabszam.Count(x => x >= 2) >= 1 ? kockak.Sum() : 0);
            /*Pontok.Add(kockak.Count(x => x == 1) >= 2 ? kockak.Sum() :
                       kockak.Count(x => x == 2) >= 2 ? kockak.Sum() :
                       kockak.Count(x => x == 3) >= 2 ? kockak.Sum() :
                       kockak.Count(x => x == 4) >= 2 ? kockak.Sum() :
                       kockak.Count(x => x == 5) >= 2 ? kockak.Sum() :
                       kockak.Count(x => x == 6) >= 2 ? kockak.Sum() : 0);*/
            //terc
            Pontok.Add(darabszam.Count(x => x >= 3) >= 1 ? kockak.Sum() : 0);
            /*Pontok.Add(kockak.Count(x => x == 1) >= 3 ? kockak.Sum() :
                       kockak.Count(x => x == 2) >= 3 ? kockak.Sum() :
                       kockak.Count(x => x == 3) >= 3 ? kockak.Sum() :
                       kockak.Count(x => x == 4) >= 3 ? kockak.Sum() :
                       kockak.Count(x => x == 5) >= 3 ? kockak.Sum() :
                       kockak.Count(x => x == 6) >= 3 ? kockak.Sum() : 0);*/
            //póker
            Pontok.Add(darabszam.Count(x => x >= 4) >= 1 ? kockak.Sum() : 0);
            /*Pontok.Add(kockak.Count(x => x == 1) >= 4 ? kockak.Sum() :
                       kockak.Count(x => x == 2) >= 4 ? kockak.Sum() :
                       kockak.Count(x => x == 3) >= 4 ? kockak.Sum() :
                       kockak.Count(x => x == 4) >= 4 ? kockak.Sum() :
                       kockak.Count(x => x == 5) >= 4 ? kockak.Sum() :
                       kockak.Count(x => x == 6) >= 4 ? kockak.Sum() : 0);*/
            //full house:
            Pontok.Add(darabszam.Count(x => x == 2) == 1 && darabszam.Count(x => x == 3)  == 1 ? 25 : 0);
            //kis sor:
            int[] rendezett = { kockak[0], kockak[1], kockak[2], kockak[3], kockak[4] };
            Array.Sort(rendezett);
            string sor = rendezett[0].ToString() + rendezett[1].ToString() + rendezett[2].ToString() + rendezett[3].ToString() + rendezett[4].ToString();
            Pontok.Add(sor.Contains("1234") || sor.Contains("2345") || sor.Contains("3456")? 30 : 0);
            //nagy sor:
            Pontok.Add(sor == "12345" || sor == "23456" ? 40 : 0);
            //kitölti a táblázatot:
            for (int i = 0; i < Pontok.Count; i++)
            {
                DGV_Tablazat[1, i].Value = Pontok[i];
            }
            //eltárolja és továbbadja a kiválasztott cellát a "Kivalasztas" metódusnak
        }

        private static void Kivalasztas(int index)
        {
            //eltárolja a kiválasztott cella pontját
        }
    }
}