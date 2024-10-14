namespace SwitchCaseRestoranMenü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ne seçilecek
            //alt menü seç
            string siparis = string.Empty;//""
        MenuSecimi:
            Console.WriteLine("1-Yemek\n2-İçecek\n9-Çıkış");

            switch (Console.ReadLine())
            {
                case "1":
                    siparis += "Yemek:";
                    Console.Clear();
                    Console.WriteLine("Yemek Menüsü\n1-Kebap\n2-İskender");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            siparis += "Kebap:";
                            Console.Clear();
                            Console.WriteLine("Porsiyon Seçiniz\n1-Yarım\n2-Tüm\n3-Birbuçuk");
                            switch (Console.ReadLine())
                            {
                                case "1": siparis += "Yarım;"; break;
                                case "2": siparis += "Tüm;"; break;
                                case "3": siparis += "Birbuçuk;"; break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Porsiyon Seçiniz\n1-Tüm\n2-Birbuçuk\n3-Duble");
                            switch (Console.ReadLine())
                            {
                                case "1": siparis += "Tüm"; break;
                                case "2": siparis += "Birbuçuk"; break;
                                case "3": siparis += "Duble"; break;

                            }
                            break;
                    }

                    break;
                case "2":
                    siparis += "\nİçecek:";
                    Console.WriteLine("İçecek Menüsü\n1-Kola\n2-Ayran");
                    switch (Console.ReadLine())
                    {
                        case "1": siparis += "Kola;"; break;
                        case "2": siparis += "Ayran;"; break;
                    }

                    break;
                //string formatting
                case "9": Console.Clear(); Console.WriteLine("Siparişiniz\n{0}", siparis); Console.ReadLine(); return;
            }
            Console.Clear();
            goto MenuSecimi;


        }
    }
}
