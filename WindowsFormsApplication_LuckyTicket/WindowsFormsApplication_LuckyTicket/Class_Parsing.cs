using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_LuckyTicket
{
    class Class_Parsing
    {
        public static short StrToShortDef(string s, short @default)
        {
            if (short.TryParse(s, out short number))
                return number;
            return @default;
        }

        public static void ConvertLongToArray(long lg_value, ref short[] sh_array)
        {
            for (short sh_i = 0; sh_i < 6; sh_i++)
                sh_array[sh_i] = 0;

            string str = lg_value.ToString();
            long count = str.Count();

            for (long lg_i = count - 1; lg_i >= 0; lg_i--)
            {
                string str_digit = str.ElementAt((int)lg_i).ToString();
                sh_array[lg_i] = StrToShortDef(str_digit, sh_array[lg_i]);
            }
        }

        public static string ConvertLongToString(long lg_value, short sh_num_of_digits)
        {
            string str_return = "";
            string str = lg_value.ToString();
            long count = str.Count();

            for (long lg_i = 0; lg_i < sh_num_of_digits - count; lg_i++)
                str_return += "0";

            for (long lg_i = 0; lg_i < count; lg_i++)
                str_return += str.ElementAt((int)lg_i).ToString();

            return str_return;
        }
    }

    public class Class_Evaluating
    {
        public const short DEF_LUCKY_TICKET = 1;
        public const short DEF_USUAL_TICKET = 0;
        public const short DEF_FAILED_TICKET = -1;
        public const short DEF_VARIANT_DEFAULT = 100;
        public const short DEF_VARIANT_TASK = 101;

        public static string GetMessageByLuckyValue(short sh_is_lucky)
        {
            switch (sh_is_lucky)
            {
                case DEF_LUCKY_TICKET: return "Получен счастливый билет!";
                case DEF_USUAL_TICKET: return "Получен обычный билет!(";
                default: return "Задан недопустимый номер билета";
            }
        }

        public static short IsHappyLucky(short[] arr, short sh_checked)
        {
            short sh_return = CheckInput(arr);
            if (sh_return == DEF_USUAL_TICKET)
            {
                switch (sh_checked)
                {
                    case DEF_VARIANT_DEFAULT: sh_return = RevealLucky_Default(arr); break;
                    case DEF_VARIANT_TASK: sh_return = RevealLucky_Task(arr); break;
                }
                return sh_return;
            }
            return sh_return;
        }

        private static short CheckInput(short[] arr)
        {
            for (short iter = 0; iter <= 5; iter++)
                if (arr[iter] < 0 || arr[iter] > 9)
                    return DEF_FAILED_TICKET;
            return DEF_USUAL_TICKET;
        }

        private static short RevealLucky_Default(short[] arr)
        {
            for (short iter = 1; iter <= 5; iter++)
            {
                if (!((arr[iter] % 2 == 0 || arr[iter] % 3 == 0) && (arr[iter] == arr[0])))
                    return DEF_USUAL_TICKET;
            }
            return DEF_LUCKY_TICKET;
        }

        private static short RevealLucky_Task(short[] arr)
        {
            // Реализация для варианта 11: есть цифра 3, затем 7 (слева направо)
            bool found3 = false;
            for (int i = 0; i < 6; i++)
            {
                if (!found3 && arr[i] == 3)
                    found3 = true;
                else if (found3 && arr[i] == 7)
                    return DEF_LUCKY_TICKET;
            }
            return DEF_USUAL_TICKET;
        }
    }
}

