using System;


namespace PrintASCIITable
{
    class PrintASCIITable
    {
        static void Main()
        {
          
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            for (int i = 33; i <= 126; i++)
            {
                Console.Write("{0}", (char)i);    // Convert.ToChar(i);
            }
        }
    }
}
