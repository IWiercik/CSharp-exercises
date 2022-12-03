namespace Kolokium
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string file = Path.Combine(Environment.CurrentDirectory, "./\\identyfikator.txt");
            string[] lines = File.ReadAllLines(file);
            showingListContent(everyNumOfIdPrimeOr0or1(lines));
        }
        static void showingListContent(List<string> table)
        {
            string txt = "[";
            for (int i = 0; i < table.Count; i++)
            {
                txt += table[i];
                if (i < table.Count - 1)
                {
                    txt += ", ";
                }
            }
            txt += "]";
            Console.WriteLine(txt);
        }
        static List<string> everyNumOfIdPrimeOr0or1(string[] array)
        {
            List<string> correctItems = new List<string>();
            for (int i = 0; i < array.Length; i++) // Filling series and ids array
            {
                string item = array[i];
                string id = item.Substring(3);
                bool allNumPrime = true;
                for (int j = 0; j < id.Length; j++)
                {
                    int idSingleNum = int.Parse(id[j].ToString());
                    if (allNumPrime == true)
                    {
                        if (idSingleNum == 0 || idSingleNum == 1)
                        {
                            allNumPrime = true;
                        }
                        else
                        {
                            if (isPrime(idSingleNum) == false) allNumPrime = false;
                        }
                    }
                }
                if (allNumPrime == true) correctItems.Add(item);
            }
            return correctItems;
        }
        static bool isPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}