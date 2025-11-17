namespace OddEvenApp;

class Program
{
    /*
     * Menampilkan Menu
     */
    static void Menu()
    {
        string input;
        do{
            Console.WriteLine("===================================");
            Console.WriteLine("         MENU GANJIL GENAP         ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Cek Ganjil Genap");
            Console.WriteLine("2. Print Ganjil/Genap (dengan Limit)");
            Console.WriteLine("3. Exit");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                                   ");
            Console.Write("Pilihan: ");
            input = Console.ReadLine();
            if(input != "1" && input != "2" && input != "3")
            {
                Console.WriteLine("Input pilihan tidak valid!!!");
            }
            try
            {
                switch (input)
                {
                    case "1":
                        Console.Write("Masukkan Bilangan yang ingin di cek : ");
                        string number  = Console.ReadLine();
                        int convertedInput = Convert.ToInt32(number);
                        if(convertedInput <= 0)
                        {
                            Console.WriteLine("Input pilihan tidak valid!!!");
                            break;
                        }
                        string numbersCheck = CheckEvenOrOdd(convertedInput);
                        Console.WriteLine(numbersCheck);
                        Console.WriteLine("===================================");
                        break;
                    case "2":
                        Console.Write("Pilih (Ganjil/Genap) : ");
                        string choice  = Console.ReadLine().ToLower();
                        Console.Write("Masukkan Limit : ");
                        string limit = Console.ReadLine(); 
                        int convertedLimit = Convert.ToInt32(limit);
                        if((choice != "ganjil" && choice != "genap"))
                        {
                            Console.WriteLine("Input pilihan tidak valid!!!");
                            break;
                        }
                        if(convertedLimit <= 0)
                        {
                            Console.WriteLine("Input limit tidak valid!!!");
                            break;
                        }
                        if(convertedLimit <= 1 && choice == "genap")
                        {  
                            Console.WriteLine("Input tidak valid!!!");
                        }
                        Console.WriteLine("Print bilangan 1 - " + convertedLimit);
                        PrintEvenOdd(convertedLimit, choice);
                        Console.WriteLine("");
                        Console.WriteLine("===================================");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Input tidak valid!!!");
            }
        }while(input != "3");
    }

    /*
     * ex: PrintEvenOdd(5, "Genap"') ;
     * output 1, 3, 5
     * x: PrintEvenOdd(5, "Ganjil");
     * output 2, 4
     * @PARAM Limit: Batas akhir. minimal 1, tidak boleh O atau negatif.
     * @PARAM choice: Pilihan, hanya boleh "Even" atau "Odd". Selain itu invalid
     */
    static void PrintEvenOdd(int limit, string choice)
    {
        // if(choice == "genap")
        // {
        //     if(limit <= 1)
        //     {  
        //         Console.WriteLine("Input tidak valid!!!");
        //     }
        //     for(int i = 1; i <= limit; i++)
        //     {   
        //         if(i % 2 == 0) 
        //         {
        //             if(i == limit || i == limit-1) Console.Write(i);
        //             else Console.Write(i + ", ");
        //         }
        //     }    
        // }
        // else
        // {
        //      for(int i = 1; i <= limit; i++)
        //     {
        //         if(i % 2 != 0) 
        //         {
        //             if(i == limit || i == limit-1) Console.Write(i);
        //             else Console.Write(i + ", ");
        //         }
        //     }   
        // }

        var modularResult = 1;
        if(choice == "genap")
        {
            modularResult = 0;
        }

        for(int i = 1; i <= limit; i++)
        {   
            if(i % 2 == modularResult) 
            {
                if(i == limit || i == limit-1) Console.Write(i);
                else Console.Write(i + ", ");
            }
        }    
    }

    /*
     * ex: EvenOddCheck(5);
     * output "Even"
     * @PARAM input: Angka yang akan dicek. minimal 1, tidak boleh O atau negatif.
     * @RETURN "Genap" jika input genap, "Ganil". jika input ganjil, selain itu Invalid Input!! jika input tidak sesuai pada @PARAM input
     */
    static string CheckEvenOrOdd(int input)
    {
        if(input % 2 == 0) 
        {
            return "Genap";
        }
        else
        {
            return "Ganjil";
        }
        return "";
    }
    
    static void Main(string[] args)
    {
        Menu();
    }
}