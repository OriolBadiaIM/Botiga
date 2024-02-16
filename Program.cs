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
            EscollirOpcioVenedor();
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

        //──OpcionsRol──//
        static void EscollirRol()
        {
            CenterText("Sóc un Client");
            CenterText("Sóc el Venedor");
            OpcioRol();
        }

        static void OpcioRol()
        {
            string OpcioRol;
            Console.WriteLine("Qui ets?: ");
            OpcioRol = Convert.ToString(Console.ReadLine());

            switch (OpcioRol)
            {
                case "Client":
                    Console.Clear();
                    MostrarBotiga();
                    break;

                case "Venedor":
                    Console.Clear();
                    EscollirOpcioVenedor();
                    break;
            }
        }
        //────────────────────────────//

        //──OpcionsVenedor//
        static void EscollirOpcioVenedor()
        {
            CenterText("Ampliar Botiga");
            CenterText("Modificar Preu");
            CenterText("Modificar Producte");
            CenterText("Ordenar Productes");
            CenterText("Ordenar Preus");
            OpcioVenedor();
        }

        static void OpcioVenedor()
        {
            string OpcioAccioVenedor;
            Console.WriteLine("Hola Venedor! Que vols fer? ");
            OpcioAccioVenedor = Convert.ToString(Console.ReadLine());

            switch (OpcioAccioVenedor)
            {
               case "Ampliar Botiga":
                    Console.Clear();
                    //AmpliarBotiga();
                    break;

                case "Modificar Preu":
                    Console.Clear();
                    //ModificarPreu();
                    break;

                case "Modificar Producte":
                    Console.Clear();
                    //ModificarProducte();
                    break;

                case "Ordenar Producte":
                    Console.Clear();
                    //OrdenarProducte();
                    break;

                case "Ordenar Preus":
                    Console.Clear();
                    //OrdenarPreus();
                    break;
            }
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
            Console.WriteLine("Benvolgut Client! Escriu el que vols afegir a la cistella: ");
            OpcionsProductes = Convert.ToString(Console.ReadLine());

            switch (OpcionsProductes)
            {
                case "Tomata":
                    Console.Clear();
                    AfegirProducte();
                    break;

                case "Formatge":
                    Console.Clear();
                    //AfegirProducte();
                    break;
                case "Pebre":
                    Console.Clear();
                    //AfegirProducte();
                    break;
                case "Espaguetis":
                    Console.Clear();
                    //AfegirProducte();
                    break;
                case "Enciam":
                    Console.Clear();
                    //AfegirProducte();
                    break;
                case "Croissant":
                    Console.Clear();
                    //AfegirProducte();
                    break;
                case "Pizza pernil":
                    Console.Clear();
                    //AfegirProducte();
                    break;
                case "Llenties":
                    Console.Clear();
                    //AfegirProducte();
                    break;
                case "Fuet":
                    Console.Clear();
                    //AfegirProducte();
                    break;
            }

        }


        //────────────────────────────//

        

        //──AfegirProducte──//
        static void AfegirProducte(string producte, double preu)
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

            Console.WriteLine("Escull el producte que vols:");
            producte = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escull el preu:");
            preu = Convert.ToDouble(Console.ReadLine());
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
