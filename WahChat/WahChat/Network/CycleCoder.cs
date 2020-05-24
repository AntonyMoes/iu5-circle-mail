using System;
using System.Collections.Generic;
using System.Text;

namespace WahChat
{
    class CycleCoder
    {
        /// <summary>
        /// Процедура кодирования циклическим кодом с образующим полиномом g(x)=x^3+x+1
        /// </summary>
        /// <param name="a">информационные разряды</param>
        /// <param name="n">образующий полином</param>
        /// <param name="code">результат кодовая комбинация</param>
        static void CycleCode(byte a, byte n, out byte code)
        {
            a <<= 3;
            // умножаем исходную код
            // считаем число разрядов

            while (CountBit(a) != CountBit(n)) n <<= 1; // уравняли по двоичному порядку делимое и делитель цикла while-необходим для получения остатка от деления v(x)*x^n-k на образующий полином.
            code = a;

            do // цикл, когда a> 111,все что меньше идет в остаток
            {
                a ^= n;
                do
                {
                    n >>= 1;
                }
                while (CountBit(a) != CountBit(n));
            } while (a > 7);
            code |= a; // приписываем остаток в начало кодового вектора                                    
        } 

        static int CountBit(byte a)
        {
            int count = 0;
            while (!(a == 0))
            {
                a /= 2;
                ++count;
            }

            return (count);
        }

        static bool CycleDecode(byte a, out byte code, byte n)
        {
            while (CountBit(a) != CountBit(n)) n <<= 1; // уравняли по двоичному порядку делимое и делитель цикла while-необходим для получения остатка от деления v(x)*x^n-k на образующий полином.
            code = a;
            do // цикл, когда a> 111, все что меньше идет в остаток
            {
                code ^= n;
                do
                {
                    n >>= 1;
                }
                while (CountBit(code) != CountBit(n));
            }
            while (code > 7);

            if (code == 0)
            {
                code = (byte)(a >> 3);
                return (true);
            }
            else return (false);
        }

        /// <summary>
        /// Процедура кодирования строки текста
        /// </summary>
        /// <param name="str">строка из текстбокса</param>
        static public List<byte> CodeString(string str)
        {
            char[] ChrArr;
            byte LShort, HShort;
            byte LWord, HWord; // младшая и старшие части символа
            byte Gx = 11; // образующий полином
            byte Code;
            List<byte> CodingString = new List<byte>();

            ChrArr = str.ToCharArray();

            short[] ShortArr = new short[str.Length];

            for (int i = 0; i < ChrArr.Length; i++)
            {
                ShortArr[i] = (short)ChrArr[i];
            }

            for (int i = 0; i < ShortArr.Length; i++)
            {
                LShort = (byte)(ShortArr[i] & 0x00FF); // получаем младшие 4 разряда маской 0000000011111111;
                HShort = (byte)((ShortArr[i] & 0xFF00) >> 8); // получаем старшие (маска 1111111100000000) и сдвигаем вначало

                LWord = (byte)(LShort & 0x0F); // получаем младшие 4 разряда маской 00001111;
                HWord = (byte)((LShort & 0xF0) >> 4); // получаем старшие (маска 11110000) и сдвигаем вначало

                CycleCode(LWord, Gx, out Code);
                CodingString.Add(Code);
                CycleCode(HWord, Gx, out Code);
                CodingString.Add(Code);

                LWord = (byte)(HShort & 0x0F); // получаем младшие 4 разряда маской 00001111;
                HWord = (byte)((HShort & 0xF0) >> 4); // получаем старшие (маска 11110000) и сдвигаем вначало

                CycleCode(LWord, Gx, out Code);
                CodingString.Add(Code);
                CycleCode(HWord, Gx, out Code);
                CodingString.Add(Code);
            }

            return (CodingString);
        }      

        /// <summary>
        /// Метод декодирования исходной строки байтов в строку, введенную пользователем
        /// </summary>
        /// <param name="str">закодированая строка байтов</param>
        /// <returns></returns>
        static public string DecodeString(byte[] str)
        {
            char ch;
            string DecodedString = "";
            byte LWord, HWord; // младшая и старшие части символа
            short LShort, HShort;

            byte Gx = 11; // образующий полином

            for (int i = 0; i < str.Length; i++)
            {
                if (!CycleDecode(str[i], out LWord, Gx)) return ("");
                if (!CycleDecode(str[++i], out HWord, Gx)) return ("");

                LShort = (short)((HWord << 4) | LWord);

                if (!CycleDecode(str[++i], out LWord, Gx)) return ("");
                if (!CycleDecode(str[++i], out HWord, Gx)) return ("");
                HShort = (short)((HWord << 4) | LWord);

                ch = Convert.ToChar((HShort << 8) | LShort);
                Console.WriteLine("ch={0}", ch);
                DecodedString += ch;
            }

            return (DecodedString);
        }
    }
}