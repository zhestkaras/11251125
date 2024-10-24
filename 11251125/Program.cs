//1
//usind System.IO

//Random rnd = new Random();
//Console.WriteLine("Сколько чисел создавать?");
//int.TryParse(Console.ReadLine(), out int number);

//using (var fs = File.Create("f"))
//using (var bw = File.Create("fs"))
//{
//    for (int i = 0; i < number; i++)
//        bw.Write(rnd.Next(0, 100));
//}
//using (var fs = File.OpenRead("f"))
//using (var gs = File.Create("g"))
//using (var br = new BinaryReader("fs"))
//using (var bw = new BinaryWriter("gs"))
//{
//    for (int i = 0; i < number; i++)
//    {
//        int n = br.ReadInt32();
//        if (n % 2 == 0)
//        {
//            bw.Write(n);
//            Console.WriteLine($" число {n} записано в g");
//    }   }
//}

//2


//Random rnd = new Random();
//Console.WriteLine("deistviteln chisla");
//int.TryParse(Console.ReadLine(), out int number);
//using (var fs = File.Create("f"))
//using (var bw = new BinaryWriter(fs))
//using (var br = new BinaryReader(fs))
//    //double prod = 1;
//{
//    for (int i = 0; i < number; i++)
//        bw.Write(rnd.Next(0, 100));
//    int n = br.ReadInt32();
//    int s = br.ReadInt32();
//    if (double.TryParse(Console.ReadLine(), out double num))
//    {
//        num*= s;
//        bw.Write(num);
//        Console.WriteLine($" число {n} ");
//    }
//}

//3
//Random rnd = new Random();
//Console.WriteLine("Сколько чисел создавать?");
//int.TryParse(Console.ReadLine(), out int number);
//Console.WriteLine("vvedite n");
//int.TryParse(Console.ReadLine(), out int n);
//Console.WriteLine("vvedite m");
//int.TryParse(Console.ReadLine(), out int m);





//using (var fs = File.Create("f"))
//using (var bw = new BinaryWriter(fs))
//{
//    for (int i = 0; i < number; i++)
//        bw.Write(rnd.Next(0, 100));
//}
//using (var fs = File.OpenRead("f"))
//using (var gs = File.Create("g"))
//using (var br = new BinaryReader(fs))
//using (var bw = new BinaryWriter(gs))
//{
//    for (int i = 0; i < number; i++)
//    {
//        int test = br.ReadInt32();
//        if (((test%m)==0) && (( test% n) !=0))
//        {
//            bw.Write(test);
          

//            Console.WriteLine($" chislo {number} ne delits {n}  delits  {m}");
//        }

        
  



    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    //13


//List<int> array = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
//Console.WriteLine("old array");
//PrintArray(array);
//Swap(array);
//Console.WriteLine("new array");
//PrintArray(array);

//static void Swap(List<int> array)
//{
//    for (int i = 0; i < array.Count-1; i+=2)
//    {
//        int temp = array[i];
//        array[i] = array[i+1]; 
//        array[i+1] = temp;
//    }
//}
//static void PrintArray(List<int> array)
//{
//    foreach(var item in array)
//    {
//        Console.WriteLine(item + " ");
//    }
//    Console.WriteLine();
//}

//15

//List<int> array = new List<int> {};
//Console.WriteLine("enter ");
//int.TryParse(Console.ReadLine(), out int n );
//for(int i = 0; i < n; i++)
//{
//    array.Add( int.Parse(Console.ReadLine()));
//}
//Console.WriteLine();

//foreach (var item in array)
//{
//    if(item == 0)
//    { 
//        break; 

//    }
//    Console.WriteLine(item);

//}

//16

//List<double> argu = new List<double> { };
//List<double> fun = new List<double> { };
//Console.WriteLine("Enter subsequence");
//while (true)
//{
//    string input = Console.ReadLine();
//    if (input.ToLower() == "stop")
//    {
//        break;
//    }
//    if (double.TryParse(input, out double arg))
//    {

//    argu.Add(arg);
//        fun.Add(Functoinal(arg));
//    }
//    else
//    {
//        Console.WriteLine("incorect");
//    }
//}
//Console.WriteLine("\nARG\tZNACH");
//Console.WriteLine("----------------------------");
//for(int i=0; i<argu.Count; i++)
//{
//    Console.WriteLine($"{argu[i]}\t{fun[i]}");
//}

//static double Functoinal(double x)
//{
//    return x*x;
//}


//18
////Console.WriteLine("vvedite kol-vo bankov");

////int n = int.Parse(Console.ReadLine());
////List<double> buye = new List<double> { };

////for (int i = 0; i < n; i++)
////{
////    Console.WriteLine($"vvedite kurs pokupki {i+1}");
////    double buy = double.Parse(Console.ReadLine());
////    buye.Add(buy);
////}
////Console.WriteLine("vvedite kolvo $");
////double dollar = double.Parse(Console.ReadLine());
////double max = buye.Max();
////int maxIndex = buye.IndexOf(max);
////Console.WriteLine($"best kurs{buye[maxIndex]} продажа принесет {max*dollar} рублей v banke {maxIndex + 1}");
/*
double max = 0;
int best = -1;
for(int i = 0;i < n;i++)
{
    double rub = dollar * buye[i];
    if (rub > max)
    {

    max = rub; best = i; 
    }
}
Console.WriteLine($"best kurs{buye[best]} v banke {best + 1}");
Console.WriteLine($"v poluch {max} rub");
*/


//19
//List<int> array = new List<int> {};
//Console.WriteLine("enter ");
//int.TryParse(Console.ReadLine(), out int n);
//array.IndexOf(n);
//for (int i = 0; i < array.Count; i *= 2)
//{
//    using System.Globalization;

//    if (i < array.Count)
//    {
//        Console.WriteLine($"index {i}, element: {array[i]}");
//    }
//}

//}
////foreach (int i in array)
////{
//if (array.Count == 0)
//{
//    //int t = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(Math.Pow(n, 2));
//}

//}


//20

Console.WriteLine("enter subsequence");
int n = int.Parse(Console.ReadLine());


//Console.WriteLine("enter r");
//int r = int.Parse(Console.ReadLine());

Console.WriteLine("enter subsequence");
List<double> nums = new List<double> { };
for( int i = 0; i < n; i++ )
{
    double num = double.Parse(Console.ReadLine());
    nums.Add(num);
}
Console.WriteLine("enter k");
int k = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
int equal = 0;
foreach (var num in nums)
{
    if (k == num)
    {
        Console.WriteLine("equal k");
        equal++;
    }
    else if (k > num)
    {
        Console.WriteLine("smaller then k");
        min++;
    }
    else 
    {
        Console.WriteLine("biger then k");
        max++;
    }

}

Console.WriteLine(
Console.WriteLine(
Console.WriteLine(n);



//int a = 0;
//List<int> aaa = new List<int>();
//Console.WriteLine("vvedite k");
//int.TryParse(Console.ReadLine(), out int k);
//Console.WriteLine("vvedite kol-vo elementov");
//int.TryParse(Console.ReadLine(), out int n);
//Random random = new Random();
//for (int i = 0; i < n; i++)
//    aaa.Add(random.Next(0, n));
//aaa.ForEach(x => Console.WriteLine(x));
//List<int> newaaa = aaa.Where(x => x % k == 0).ToList();
//newaaa.ForEach(x => a += x);
//Console.WriteLine(a);

//2
//Console.WriteLine("vvedite kolvo elem");
//int.TryParse(Console.ReadLine(), out int n);
//List<int> celoe = new List<int>();
//Random random = new Random();
//for (int i = 0; i < n; i++)
//    celoe.Add(random.Next(0, n));
//celoe.ForEach(x => Console.WriteLine(x));

//List<int> nomera = new List<int>();
//int nuli = celoe.Count(x => x == 0);
//for(int i = 0; i < nuli; i++)
//{
//    int index = celoe.LastIndexOf(0);
//    nomera.Add(index);
//    celoe.RemoveAt(index);
//}
//Console.WriteLine("new:");
//nomera.ForEach(x => Console.WriteLine(x));

//4

//List<int> nume = new List<int>();
//while (true)
//{
//    Console.WriteLine("введите число или exit");
//    if (!int.TryParse(Console.ReadLine(), out int num))
//        break;
//    nume.Add(num);
//}

//bool pos = Pos(nume);

//if (pos)
//{
//    Console.WriteLine("vozrastaet");
//}
//else
//{
//    Console.WriteLine("Nevozrastaet");
//}

//static bool Pos(List<int> numbers)
//{
//    for (int i = 1; i < numbers.Count; i++)
//    {
//        if (numbers[i] <= numbers[i - 1])
//        {
//            return false;
//        }
//    }
//    return true;
//}









//14
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//int max = 0;
//int cur = 0;    
//foreach (char c in input)
//{
//    if (char.IsDigit(c))
//    {
//        cur++;
//        if (cur > max)
//        {
//            max = cur;
//        }
//    }
//    else
//    {
//        cur = 0;
//    }
//}
//Console.WriteLine("dlina"+ max);

//15
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//if ( input.EndsWith(":") )
//{
//    input = input.Substring(0, input.Length - 1);
//}
//string[] words = input.Split(';');
//    int count =  0;
//foreach ( string word in words )
//{
//    string trim = word.Trim();
//    if ( trim.Length > 0 && trim.EndsWith("a", StringComparison.OrdinalIgnoreCase))
//    {
//        count++;
//    }
//}
//Console.WriteLine("kol-vo slov"+count);

//16
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//string[] words = input.Split(new char[] { ' ', ',','.',';',':','!','?'}, StringSplitOptions.RemoveEmptyEntries);
//Console.WriteLine("slova na k");
//bool found = false; 
//foreach ( string word in words)
//{
//    if (word.IndexOf('k', StringComparison.OrdinalIgnoreCase) >= 0)
//    {
//        Console.WriteLine(word);
//        found = true;   
//    }
//}
//if (!found)
//{
//    Console.WriteLine("slov net");
//}

//17
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//string[] words = input.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
//Console.WriteLine("slova nachin i zakan");
//bool found = false;
//foreach (string word in words)
//{
//   if ( word.Length > 0)
//    {
//        if (char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]))
//        {
//            Console.WriteLine(word);
//            found = true;
//        }

//    }
//}
//if (!found)
//{
//    Console.WriteLine("slov net");
//}

//18
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//char oldchar = ':';
//char newchar = ';';
//int count = 0;
//string newStr = "";
//for(int i = 0; i < input.Length; i++)

//    if (input[i] == oldchar)
//        count++;
//input = input.Replace(oldchar, newchar);
//Console.WriteLine(input);
//Console.WriteLine(count);

//18.2
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//char oldchar = ':';
//char newchar = ';';
//int count = 0;
//string newStr = "";
//for (int i = 0; i < input.Length; i++)
//{
//    if (input[i] == oldchar)
//    {
//        newStr += newchar;
//        count++;
//    }
//    else
//        newStr += input[i];
//}
//input = input.Replace(oldchar, newchar);
//Console.WriteLine(input);

//Console.WriteLine(newStr);
//Console.WriteLine(count);

//19
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//char oldchar = ':';
//char newchar = ' ';
//int count = 0;
//string newStr = "";
//for (int i = 0; i < input.Length; i++)

//    if (input[i] == oldchar)
//        count++;
//input = input.Replace(oldchar, newchar);
//Console.WriteLine(input);
//Console.WriteLine(count);

//20
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//char oldchar = ' ';
//char newchar = ',';
//char prob = ' ';
//int count = 0;
//for (int i = 0; i < input.Length; i++)
//    if (input[i] == oldchar + prob)
//        count++;
//input = input.Replace(oldchar, newchar);
//Console.WriteLine(input);

//21
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//int open = input.IndexOf('(');
//int close = input.LastIndexOf(')');
//if(open != -1 && close != -1 && open<close)
//{
//    string result = input.Remove(open, close + 1);
//    Console.WriteLine("result: " + result);
//}
//else
//{
//    Console.WriteLine("skopok net or nepravelno");
//}

//22
//Console.WriteLine("vvedite slovo");
//string input = Console.ReadLine();
//string wordfind = Console.ReadLine();
//string[] words = input.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
//int count = 0;
//foreach (string word in words)
//{
//    if (word.Equals(wordfind, StringComparison.OrdinalIgnoreCase))
//    {
//        count++;

//    }
//}
//Console.WriteLine($"eto slovo'{wordfind}'vstr {count} raz");



// See https://aka.ms/new-console-template for more information
//1.1
//int a = 31;
//int b = 18;
//int c = 79;
//Console.WriteLine(a + " " + b + " " + c );
//1.2
//int a = 47;
//int b = 52;
//int c = 150;
//Console.WriteLine(a + "  " + b + "  " + c);
//1.3
//Console.WriteLine(50);
//Console.WriteLine(10);
//1.6
//Console.WriteLine(Math.Round(Math.PI, 3));
//1.7
//Console.WriteLine(Math.Round(Math.E, 1));
//1.8
//Console.Write("Введите число — ");
//string number = Console.ReadLine();
//Console.WriteLine(" Вы ввели число " + number);
//Console.Read();
//1.10
//Console.Write("Введите Ваше ФИО ");
//string number = Console.ReadLine();
//Console.WriteLine(" Ваше ФИО " + number);
//Console.Read();
//1.11
//Console.Write("Как тебя зовут? ");
//string number = Console.ReadLine();
//Console.WriteLine(" Привет, " + number);
//Console.Read();
//1.13
//int namber, next, pred;
//int.TryParse(Console.ReadLine(), out namber);
//next = namber + 1;
//pred = namber - 1;
//Console.WriteLine("Следущее за числом " + namber + " это " + next);
//Console.WriteLine("TПредыдущее число " + namber + " это " + pred);
//Console.ReadKey();
//1.14
//int[] numbers = new int[3];
//Console.WriteLine("1 число:\n");
//numbers[0] = int.TryParse(Console.ReadLine());
//Console.WriteLine("2 число:\n");
//numbers[1] = int.TryParse(Console.ReadLine());
//Console.WriteLine("3 число:\n");
//numbers[2] = 
//Console.WriteLine($"{numbers[0]}  {numbers[1]}  {numbers[2]}");
//Console.ReadKey();
//11/5
//int[] ints = new int[12];
//Random random = new Random();
//for (int  i = 0;  i < ints.Length; i++)
//{
//    ints[i]= random.Next(163,191);
//    Console.WriteLine(ints[i]);
//}






//11.8

//Console.WriteLine("Введите размер массива");
//int.TryParse(Console.ReadLine(), out int count);
//int[] ints2 = new int[count];

//for (int i = 0; i < ints2.Length; i++)
//{
//    Console.Write($"ячейка [{i}] = ");
//    int.TryParse(Console.ReadLine(), out ints2[i]);
//}

//Console.WriteLine("Введите индекс");
//int.TryParse(Console.ReadLine(), out int index);
//if (index >= count || index < 0)
//    Console.WriteLine("Индекса не существует");
//else
//    Console.WriteLine(ints[index]);

////11.1
//int[] num1 = new int[8];
//for (int i = 0; i<8; i++)
//{
//    int.TryParse(Console.ReadLine(), out num1[i]);
//}
//Console.WriteLine("Массив");
//for ( int i= 0; i<8; i++)
//{
//    Console.WriteLine(num1[i]);
//}

//11.2
//int[] num1 = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    int.TryParse(Console.ReadLine(), out num1[i]);
//}
//11.3
//double.TryParse(Console.ReadLine(), out num1[i]);
//a
//Random random = new Random();
//double[] num1 = new double[15];
//for (int i = 0; i < 15; i++)
//{
//    num1[i] = random.NextDouble();
//}
//Console.WriteLine("Массив");
//for (int i = 0; i < 15; i++)
//{
//    Console.WriteLine(num1[i]);
//}
//b
//Random random = new Random();
//double[] num1 = new double[15];
//for (int i = 0; i < 15; i++)
//{
//    num1[i] = random.Next(22,23);
//}
//Console.WriteLine("Массив");
//for (int i = 0; i < 15; i++)
//{
//    Console.WriteLine(num1[i]);
//}

//11.4
//char[] num1 = new char[20];
//for (int i = 0; i < 20; i++)
//{
//    num1[i]='#';

//}
//for (int i = 0; i < 20; i++)
//{
//    Console.WriteLine(num1[i]);

//}

//11.5

//int[] ints = new int[12];
//Random random = new Random();
//for (int i = 0; i < ints.Length; i++)
//{
//    ints[i] = random.Next(163, 191);
//    Console.WriteLine(ints[i]);
//}

//11.6
//Random random = new Random();
//double[] num1 = new double[20];
//for (int i = 0; i < 20; i++)
//{
//    num1[i] = random.Next(50,101);
//}
//Console.WriteLine("Массив");
//for (int i = 0; i < 20; i++)
//{
//    Console.WriteLine(num1[i]);
//}

//11,7
//int n = number3;
//Console.Write("Введите число элементов в массиве ");
//Console.Write("Введите число а ");
//Console.Write("Введите число б ");

//int number = int.Parse(Console.ReadLine());
//int number2 = int.Parse(Console.ReadLine());
//int number3 = int.Parse(Console.ReadLine());
//Random random = new Random();
//double[] num1 = new double[n];
//for (int i = 0; i < 15; i++)
//{
//    num1[i] = random.Next(a, b);
//}
//Console.WriteLine("Массив");
//for (int i = 0; i < 15; i++)
//{
//    Console.WriteLine(num1[i]);
//}


//11.8

//Console.WriteLine("Введите размер массива");
//int.TryParse(Console.ReadLine(), out int count);
//int[] ints2 = new int[count];

//for (int i = 0; i < ints2.Length; i++)
//{
//    Console.Write($"ячейка [{i}] = ");
//    int.TryParse(Console.ReadLine(), out ints2[i]);
//}

//Console.WriteLine("Введите индекс");
//int.TryParse(Console.ReadLine(), out int index);
//if (index >= count || index < 0)
//    Console.WriteLine("Индекса не существует");
//else
//    Console.WriteLine(ints[index]);


//11.9
//string[] array = { "A", "B", "C", "D", "E" };
//for (int i = array.Length - 1; i >= 0; --i)
//    Console.Write(array[i] + " ");
//Console.ReadKey(true);

//Array.Reverse

//11.10
//int[] array = new int[20];

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = 1 + i;
//}

//Console.WriteLine("Массив:");
//foreach (int number in array)
//{
//    Console.Write(number + " ");
//}


//11/12
//int[] array = new int[20];

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = 20 - i;
//}

//Console.WriteLine("Массив:");
//foreach (int number in array)
//{
//    Console.Write(number + " ");
//}
//11/11
//int[] array = new int[25];

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = 1 + i;
//}

//Console.WriteLine("Массив:");
//foreach (int number in array)
//{
//    Console.Write(number + " ");
//}
//Console.WriteLine("100" + " " + "200");    
//int[] array = new int[20];

//11.14
//int[] array = new int[9999];
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] =  - i;
//}

//Console.WriteLine("Массив:");
//foreach (int number in array)
//{
//    Console.Write(number + " ");
//}

//11/15
//a
//int[] array = new int[8];

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = 1 + i;
//}

//Console.WriteLine("Массив:");
//foreach (int number in array)
//{
//    Console.Write(number + " ");
//}

//b
//int[] array = new int[20];

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = 20 - i;
//}

//Console.WriteLine("Массив:");
//foreach (int number in array)
//{
//    Console.Write(number + " ");
//}
