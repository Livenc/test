namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Post post = new Post()
            {
                sotrydnic = new Employee() { Familia = "dfdf", Imail = "dfsf" },
                zarplata = 12423,
                nazvanieDolgnosi = "Selo"
            };

            Organization organization = new Organization("Staleks", 200423, post);
            Console.WriteLine(organization.Budjet);
           // organization.doljnoist[0] = post;
            organization.VuplataZarplat();
            Console.WriteLine(organization.RabotaMasac("-"));
            Console.ReadLine();
        }
    }
}