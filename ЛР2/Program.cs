using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    class Programm
    {
        static void Main(string[] args)
        {
            Library lib=new Library();
            Library.Initial();
            Console.WriteLine("Библиотека готова к работе");
            Console.Write("Введите имя читателя ");
            string fio = Console.ReadLine();
            Console.Write("Введите номер билета ");
            string ticket = Console.ReadLine();
            Reader reader = new Reader(fio, ticket);

            Console.WriteLine("Уважаемый " + reader.fio + ", выберите действие\n" +
                "1-Вывод каталога\n" +
                "2-Запрос книги\n" +
                "0-Выход");
            int doIt = int.MaxValue;
            while(doIt > 0)
            {
                Console.Write("Ваш выбор: ");
                doIt = int.Parse(Console.ReadLine());
                switch (doIt)
                {
                    case 1:
                        lib.ListBooks();
                        break;
                    case 2:
                        Console.Write("Введите код книги ");
                        int kode = int.Parse(Console.ReadLine());
                        lib.GetBook(kode, reader);
                        break;
                    case 0:
                        doIt = 0;
                        break;
                    default: break;

                }
            }
            Console.ReadLine();
        }
    }
}