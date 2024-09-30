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
