namespace WebsiteChecker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------Verifique se o site está online----------");
            Console.WriteLine("Digite a URL do site...");

            var URL = Console.ReadLine();
            Verify(URL);

            static void Verify(string? URL)
            {
                HttpClient Client = new HttpClient();
                try
                {
                    var res = Client.GetAsync(URL);
                    var status = res.Result.IsSuccessStatusCode;
                    if (status)
                        Console.WriteLine("O site está online!");
                    else
                        Console.WriteLine("O site está offline!");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("URL inválida.");

                }
            }
        }
    }
}