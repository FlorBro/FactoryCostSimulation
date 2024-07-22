namespace ClassPros
{
    public class Machine
    {
        public string Nom { get; set; }
        public int Temps { get; set; }
        public int Couts { get; set; }
        public int NombreUnité { get; set; }
        public void ListeUnité()
        {

            Console.WriteLine("Nom de la machine:" + Nom);

        }
    }
}