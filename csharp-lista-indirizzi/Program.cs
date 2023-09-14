namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Address> addresses = new List<Address>();

            try
            {
                StreamReader fileAddresses = File.OpenText("C:\\Users\\stefa\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv");

                int counter = 0;

                while (!fileAddresses.EndOfStream)
                {
                    string line = fileAddresses.ReadLine();
                    counter++;

                    if (counter > 1)
                    {
                        string[] addressPieces = line.Split(',');

                        if (addressPieces.Length < 6)
                        {
                            Console.WriteLine($"{line} non è in un formato corretto!");
                        }
                        else
                        {
                            string firstName = addressPieces[0];
                            string lastName = addressPieces[1];
                            string steet = addressPieces[2];
                            string city = addressPieces[3];
                            string province = addressPieces[4];
                            int zipCode = int.Parse(addressPieces[5]);

                            Address newAddress = new Address(firstName, lastName, steet, city, province, zipCode);
                            Console.WriteLine("letto");

                            addresses.Add(newAddress);
                        }
                    }
                }


                fileAddresses.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            foreach(Address add in addresses)
            {
                Console.WriteLine(add);
            }
        }
    }
}