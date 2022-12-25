namespace ConsoleApp7
{
    public class StahovacDat
    {

        /// <summary>
        /// instance Seznamu osob
        /// </summary>
        private SeznamOsob seznam;
        /// <summary>
        /// seznam osob do Listu
        /// </summary>
        private List<SeznamOsob> seznamOsob = new List<SeznamOsob>();
        /// <summary>
        /// načtení do pole
        /// </summary>
        private string[] seznamVPoli;
        /// <summary>
        /// spočítá , kolik je členů na seznamu
        /// </summary>
        private static int pocet = 0;

        //Stažení dat ze souboru
        public void StahniData()
        {

            //Načtení cesty souboru
            StreamReader sr = new StreamReader("C:\\Users\\hanak\\Desktop\\VS2022\\ConsoleApp7\\ConsoleApp7\\Data\\seznam.txt");
          
            string nacistLidi = "";

            //Opakuj dokud není řádek prázdný
            while ((nacistLidi = sr.ReadLine()) != null)
            {
                try
                {                   
                    seznamVPoli = nacistLidi.Split(';');//Odstraň ; a načti do pole
                    PridatOsobu();
                    pocet++;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Chyba ---->  " + e.Message);
                }
            }
            sr.Close();
        }

        //Přidání členů do seznamu osob podle seznamu pole
        public void PridatOsobu()
        {
            seznam = new SeznamOsob(seznamVPoli[1], seznamVPoli[2], int.Parse(seznamVPoli[0]));
            seznamOsob.Add(seznam);
        }


        //Vypsání osob
        public void VypsatOsoby()
        {
            foreach (SeznamOsob item in seznamOsob)
            {
           
                Console.WriteLine(item);

            }
            Console.WriteLine("Celkem uživatelů:      {0}",VratPocet());
        }

        //Vrátí počet osob ze statiky
        public int VratPocet()
        {
            return pocet;
        }

    }
}
