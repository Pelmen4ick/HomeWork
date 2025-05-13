using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1233
{
    class Program
    {
        static void Main(string[] args)
        {




            
            
                Money myMoney = new Money(100, 5);
                myMoney.Display();
            Console.ReadKey();

                Console.WriteLine(myMoney.CanAfford(450) ? "Достаточно средств." : "Недостаточно средств.");
                Console.WriteLine($"Можно купить товаров: {myMoney.GetItemCount(100)}");

                Console.WriteLine($"Номинал (по индексу 0): {myMoney[0]}");
                Console.WriteLine($"Количество (по индексу 1): {myMoney[1]}");

            Console.ReadKey();
            myMoney[0] = 200;
                myMoney[1] = 3;
                myMoney.Display();

                myMoney++;
                Console.WriteLine("После увеличения:");
                myMoney.Display();

                myMoney += 2;
                Console.WriteLine("После увеличения на 2:");
                myMoney.Display();

            Console.ReadKey();

        }
    }

    public class Money
    {
        public int nominal;
        public int count;

        public Money(int nominal, int count)
        {
            this.nominal = nominal;
            this.count = count;
        }

        public void Display()
        {
            Console.WriteLine($"Номинал: {nominal} рублей, Количество: {count} шт.");
        }

        public bool CanAfford(int amount)
        {
            return TotalAmount >= amount;
        }

        public int GetItemCount(int itemPrice)
        {
            return TotalAmount / itemPrice;
        }

        public int TotalAmount
        {
            get { return nominal * count; }
        }

        public int this[int index]
        {
            get
            {
                if (index == 0) return nominal;
                if (index == 1) return count;
                throw new IndexOutOfRangeException("Индекс должен быть 0 или 1.");
            }
            set
            {
                if (index == 0) nominal = value;
                else if (index == 1) count = value;
                else throw new IndexOutOfRangeException("Индекс должен быть 0 или 1.");
            }
        }

        public static Money operator ++(Money money)
        {
            money.count++;
            return money;
        }

        public static Money operator --(Money money)
        {
            money.count--;
            return money;
        }

        public static Money operator +(Money money, int scalar)
        {
            money.count += scalar;
            return money;
        }
    }

}
