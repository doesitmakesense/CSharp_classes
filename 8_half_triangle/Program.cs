Console.Clear();

 int i = 0; //одна переменная для строки, вторая для звездочки
            int j = 0;
            while (i < 10)
            {
               while (j < 10 - i && j >= 0)
               {
                   Console.Write("*");
                   j++;
               }
              j = 0;
              i++;
              Console.WriteLine();
            }

        // //второй вариант:

        //  int i = 0;
        //     int j = 0;
        //     while (i < 10)
        //     {
        //        while (j < 10 - i && j >= 0)
        //        {
        //            Console.Write("*");
        //            j++;
        //        }
        //       j = 0;
        //       i++;
        //       Console.WriteLine();
        //     }