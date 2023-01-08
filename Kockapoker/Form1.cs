namespace Kockapoker
{
    public partial class Form1 : Form
    {
        static int[] kockak = { 1, 2, 3, 4, 5 };
        static int[] kivalasztott_kockak = { 0, 0, 0, 0, 0 }; //ide mentj�k el a kiv�lasztott kock�k �rt�keit
        static int dobasok = 10; //3szor lehet �jradobni
        static int korok = 15; //15 k�r van
        public Form1()
        {
            InitializeComponent();
            LB_Dobasok.Text = dobasok.ToString();
            //nem lehet lenntartani az �rt�keket inicializ�l�sk�r
            CHB_Dobott1.Enabled = false; 
            CHB_Dobott2.Enabled = false;
            CHB_Dobott3.Enabled = false;
            CHB_Dobott4.Enabled = false;
            CHB_Dobott5.Enabled = false;
            string[] Kategoria = { "Egyesek", "Kettesek", "H�rmasok", "N�gyesek", "�t�s�k", "Hatosok",
                                   "P�r", "Terc", "P�ker", "Full House", "Kis sor", "Nagy sor", "Yahtzee", "�sszeg"};
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

                //kock�k kiv�laszt�sa:
                if (LB_Dobott1.Text != "0")
                {
                    if (CHB_Dobott1.Checked) kivalasztott_kockak[0] = kockak[0];
                    if (CHB_Dobott2.Checked) kivalasztott_kockak[1] = kockak[1];
                    if (CHB_Dobott3.Checked) kivalasztott_kockak[2] = kockak[2];
                    if (CHB_Dobott4.Checked) kivalasztott_kockak[3] = kockak[3];
                    if (CHB_Dobott5.Checked) kivalasztott_kockak[4] = kockak[4];
                }

                //5db kocka dob�sa:
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

                //dobott �rt�kek ki�r�sa:
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
            //elindul a ki�rt�kel�s
        }

        private void Kiertekeles()
        {
            // megsz�moljuk a dobott sz�mok darabsz�m�t
            int[] darabszam = { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < darabszam.Length; i++)
            {
                darabszam[i] = kockak.Count(x => x == i + 1);
            }
            List<int> Pontok = new List<int>();
            //fels� sor:
            //egyesek
            Pontok.Add(darabszam[0]);
            //Pontok.Add(kockak.Count(x => x == 1));
            //kettesek
            Pontok.Add(darabszam[1]*2);
            //Pontok.Add(kockak.Count(x => x == 2)*2);
            //h�rmasok
            Pontok.Add(darabszam[2]*3);
            //Pontok.Add(kockak.Count(x => x == 3)*3);
            //n�gyesek
            Pontok.Add(darabszam[3]*4);
            //Pontok.Add(kockak.Count(x => x == 4)*4);
            //�t�sok
            Pontok.Add(darabszam[4]*5);
            //Pontok.Add(kockak.Count(x => x == 5)*5);
            //hatosok:
            Pontok.Add(darabszam[5]*6);
            //Pontok.Add(kockak.Count(x => x == 6)*6);
            //als� sor:
            //p�r
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
            //p�ker
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
            //kit�lti a t�bl�zatot:
            for (int i = 0; i < Pontok.Count; i++)
            {
                DGV_Tablazat[1, i].Value = Pontok[i];
            }
            //elt�rolja �s tov�bbadja a kiv�lasztott cell�t a "Kivalasztas" met�dusnak
        }

        private static void Kivalasztas(int index)
        {
            //elt�rolja a kiv�lasztott cella pontj�t
        }
    }
}