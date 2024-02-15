namespace BotigaExercici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Botiga//
            string[] productesBotiga = new string[9];
            double[] preus = new double[9];
            int nElemBotiga;

            //Cistella//
            string[] productesCistella = new string[9];
            int[] quantitat = new int[9];
            int nElemCistella;
            double diners;


            EscollirRol();
            MostrarBotiga();
        }

        //──METODES BOTIGA──//

        //──Text Centrat──//
        static void CenterText(string text)
        {

            int screenWidth = Console.WindowWidth;
            int stringWidth = text.Length;
            int leftMargin = (screenWidth - stringWidth) / 2;
            Console.SetCursorPosition(leftMargin, Console.CursorTop);
            Console.WriteLine(text);
        }
        //────────────────────────────//

        static void MostrarBotiga()
        {
            Console.Clear();
            CenterText("╔═════════════════════════════════╗");
            CenterText("║        PRODUCTES BOTIGA         ║");
            CenterText("║─────────────────────────────────║");
            CenterText("║ 1 - Tomata............... 0.50e ║");
            CenterText("║ 2 - Formatge............. 1.20e ║");
            CenterText("║ 3 - Pebre................ 3.70e ║");
            CenterText("║ 4 - Espaguetis........... 5.00e ║");
            CenterText("║ 5 - Enciam............... 0.20e ║");
            CenterText("║ 6 - Croissant............ 2.00e ║");
            CenterText("║ 7 - Pizza pernil......... 4.50e ║");
            CenterText("║ 8 - Llenties............. 6.45e ║");
            CenterText("║ 9 - Fuet................. 9.80e ║");
            CenterText("╚═════════════════════════════════╝");
            OpcioMenu();
        }

        //──MenúOpcionsProdcutes──//

        static void OpcioMenu()
        {
            string OpcionsProductes;
            Console.WriteLine("Escriu el que vols afegir a la cistella: ");
            OpcionsProductes = Convert.ToString(Console.ReadLine());

            switch (OpcionsProductes)
            {
                case "Tomata":
                    Console.Clear();
                    MostrarBotiga();
                    break;

                case "Formatge":
                    Console.Clear();
                    MostrarBotiga();
                    break;
                case "Pebre":
                    Console.Clear();
                    MostrarBotiga();
                    break;
                case "Espaguetis":
                    Console.Clear();
                    MostrarBotiga();
                    break;
                case "Enciam":
                    Console.Clear();
                    MostrarBotiga();
                    break;
                case "Croissant":
                    Console.Clear();
                    MostrarBotiga();
                    break;
                case "Pizza pernil":
                    Console.Clear();
                    MostrarBotiga();
                    break;
                case "Llenties":
                    Console.Clear();
                    MostrarBotiga();
                    break;
                case "Fuet":
                    Console.Clear();
                    MostrarBotiga();
                    break;
            }

        }


        //────────────────────────────//

        static void EscollirRol()
        {
            CenterText("Sóc un client");
            CenterText(" Sóc el venedor");
            OpcioRol();
        }
        //──MenúOpcionsRol──//

        static void OpcioRol()
        {
            string OpcioRol;
            Console.WriteLine("Qui ets?: ");
            OpcioRol = Convert.ToString(Console.ReadLine());

            switch (OpcioRol)
            {
                case "Client":
                    MostrarBotiga();
                    Console.Clear();
                    break;

                case "Venedor":
                    Console.Clear();
                    MostrarBotiga();
                    break;
            }
            //────────────────────────────//
          

            //──AfegirProducte──//
            static void AfegirProductes(string productes, double preu)
            {

            }
            //────────────────────────────//

            //──AmpliarBotiga──//
            static void AmpliarBotiga(int num)
            {

            }
            //────────────────────────────//

            //──ModificarPreu──//
            static void ModificarPreu(string producte, double preu)
            {

            }
            //────────────────────────────//

            //──ModificarProducte──//
            static void ModificarProducte(string producteAntic, string producteNou)
            {

            }
            //────────────────────────────//

            //──OrdenarProducte──//
            static void OrdenarProducte()
            {

            }
            //────────────────────────────//

            //──OrdenarPreus──//
            static void OrdenarPreus()
            {

            }
            //────────────────────────────//

            //──BotigaToString──//
            static void BotigaToString()
            {

            }
            //────────────────────────────//



            //──METODES CISTELLA──//

            //──ComprarProducte──//
            static void ComprarProducte(string producte, int quantitat)
            {

            }
            //───────────────────//

            //──OrdenarCistella──//
            static void OrdenarCistella(string producte, int quantitat)
            {

            }
            //───────────────────//

            //──MostrarCistella──//
            static void MostrarCistella()
            {

            }
            //───────────────────//

            //──CistellaToString──//
            static void CistellaToString()
            {

            }
            //───────────────────//

        }
    }
}
