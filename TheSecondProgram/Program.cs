using System. Collections;
using System. Diagnostics;

namespace TheSecondProgram
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Stopwatch stopwatch = new Stopwatch ();
            var numbersList=new List<int> ();//создание List

            stopwatch. Start ();
            for (int i = 1; i<=1_000_000; i++)
            {
                numbersList.Add (i);
            }
            stopwatch. Stop ();
            TimeSpan fillingTimeList = stopwatch. Elapsed;
            Console.WriteLine ("Время добавления 1 000 000 элементов в List составило: "+fillingTimeList);
            stopwatch. Start ();
            numbersList.BinarySearch(496_753);
            stopwatch. Stop ();
            TimeSpan searchTimeList = stopwatch. Elapsed;
            Console. WriteLine ("Время поиска 496 753го элемента в List составило: "+searchTimeList);
            stopwatch. Start ();
            for(int j=0 ;j<1_000_000 ; j++)
            {
                if (numbersList[j]%777==0)
                {
                   Console. WriteLine ("Число, которое делится без остатка на 777: "+numbersList[j]);
                }
            }
            stopwatch. Stop ();
            TimeSpan divisionWithoutRemainderInList=stopwatch. Elapsed;
            Console. WriteLine ("Длительность вывода элемента коллекции, который без остатка делится на 777: "+divisionWithoutRemainderInList);

            var numbersArrayList= new ArrayList ();//создание ArrayList
            stopwatch. Start ();
            for(int i=1 ; i<=1_000_000 ; i++)
            {
                numbersArrayList.Add (i);
            }
            stopwatch. Stop ();
            TimeSpan fillingTimeArrayList = stopwatch. Elapsed;
            Console. WriteLine ("Время добавления 1 000 000 элементов в ArrayList составило: "+fillingTimeArrayList);
            stopwatch. Start ();
            numbersArrayList.BinarySearch(496_753);
            stopwatch. Stop ();
            TimeSpan searchTimeArrayList = stopwatch. Elapsed;
            Console. WriteLine ("Время поиска 496 753го элемента в ArrayList составило: "+searchTimeArrayList);
            stopwatch. Start ();

            for (int j = 0 ; j<1_000_000 ; j++)
            {
                if ((int) numbersArrayList[j]%777 == 0)
                {
                   Console. WriteLine ("Число, которое делится без остатка на 777: "+numbersArrayList[j]);
                }
            }
            stopwatch. Stop ();
            TimeSpan divisionWithoutRemainderInArrayList = stopwatch. Elapsed;
            Console. WriteLine ("Длительность вывода элемента коллекции, который без остатка делится на 777: "+divisionWithoutRemainderInArrayList);

            var numbersLinkedList=new LinkedList<int>();//создание LinkedList
            stopwatch. Start ();
            for (int i = 1 ; i<=1_000_000 ; i++)
            {
                numbersLinkedList. AddLast (i);
            }
            stopwatch. Stop ();
            TimeSpan fillingTimeLinkedList = stopwatch. Elapsed;
            Console. WriteLine ("Время добавления 1 000 000 элементов в LinkedList составило: "+fillingTimeLinkedList);
            stopwatch. Start ();
            numbersLinkedList. Find (496_753);
            stopwatch. Stop ();
            TimeSpan searchTimeLinkedList = stopwatch. Elapsed;
            Console. WriteLine ("Время поиска 496 753го элемента в LinkedList составило: "+searchTimeLinkedList);
            stopwatch. Start ();
            for (var item=numbersLinkedList.First ; item!=null ; item=item.Next)
            {
                if (item. Value%777==0)
                {
                   Console. WriteLine ("Число, которое делится без остатка на 777: "+item. Value);
                }
            }
            stopwatch. Stop ();
            TimeSpan divisionWithoutRemainderInLinkedList = stopwatch. Elapsed;
            Console. WriteLine ("Длительность вывода элемента коллекции, который без остатка делится на 777: "+divisionWithoutRemainderInLinkedList);
        }
    }
}
