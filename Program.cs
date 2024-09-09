namespace GestioneImmobili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Immobili> list = new List<Immobili>();
                Console.WriteLine("nome immobile");
                string nome = Console.ReadLine();
                Console.WriteLine("descrizione immobile");
                string descrizione = Console.ReadLine();
                Console.WriteLine("prezzo immobile");
                int prezzo = Convert.ToInt32(Console.ReadLine());

                int calcoloIva(int prezzocasa)
                {
                    const double fisso = 0.22;
                    int iva = (int)(prezzocasa * fisso);
                    return iva;
                }
                int iva = calcoloIva(prezzo);
                Immobili casauno = new Immobili(nome, descrizione, prezzo, iva);
                list.Add(casauno);
                foreach (Immobili i in list)
                {
                    Console.WriteLine($"{i.Prezzo}  {i.Nome}  {i.Descrizione}  {i.Iva}");
                }

                int identificativo()
                {

                    return 0;
                }

                Console.WriteLine($"L'iva e di {iva}");

                Console.WriteLine($"quindi in totale e di  {prezzo + iva}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("inserire un numero senza virgloa");
            }
            finally
            {
                Console.WriteLine("il codice di  verifica sempre ");
            }


        }
    }
}
