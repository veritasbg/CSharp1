using System;


namespace TextToNumber
{
    class TextToNumber
    {
        static void Main()
        {
            int module = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            text = text.ToLower();

            long result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (ch == '@')
                {
                    break;
                }
                else if ('0'<=ch && ch<='9')  //TODO: IS RESULT ?=0
                {
                    result *=(ch- '0');
                }
                else if ('a'<=ch && ch<='z')
                {
                    result += (ch-'a');
                }
                else
                {
                    result %= module;
                }
            }
            Console.WriteLine(result);
        }
    }
}
