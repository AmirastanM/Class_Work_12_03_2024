

//Console.WriteLine("");

////IntList intList = new IntList();
////Console.WriteLine(intList.age);


//IntList datas = new IntList();

//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//datas.Add(4);
//datas.Add(5);

//int[] result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//StringList stringList = new StringList();

//stringList.Add("salam");
//stringList.Add("sagol");


//var result2 = stringList.GetAll();

//foreach (var item in result2)
//{
//    Console.WriteLine(item);
//}


//DataList<int> datas = new DataList<int>();

//datas.Add(100);
//datas.Add(200);
//datas.Add(300);

//var result = datas.GetAll();

//foreach(var item in result)
//{
//    Console.WriteLine(item);
//};




//DataList<string> dataList = new DataList<string>();

//dataList.Add("salam");
//dataList.Add("Sagol");

//var result2 = dataList.GetAll();

//foreach (var item in result2)
//{
//    Console.WriteLine(item);
//};






//DataList<bool> dataList1 = new DataList<bool>();

//dataList1.Add(true); 
//dataList1.Add(false);
//dataList1.Add(true);

//var result3 = dataList1.GetAll();

//foreach (var item in result3)
//{
//    Console.WriteLine(item);
//};


//DataList<Book> books = new DataList<Book>();

//books.Add(new Book { Id = 1, Name = "Test1" });
//books.Add(new Book { Id = 2, Name = "Test2" });
//books.Add(new Book { Id = 3, Name = "Test3" });


//var result = books.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine((item.Name));
//}



using ClassPractice_HomeTask_12_03_2024;
using System.Collections;
using System.Globalization;

//DataList<int> datas = new DataList<int>();

//datas.Add(100);
//datas.Add(200);
//datas.Add(300);

//var result = datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//};

//datas.Delete(100);

//var result2 = datas.GetAll();

//foreach (var item in result2)
//{
//    Console.WriteLine(item);
//};



//Repository<string> data1 = new Repository<string>();

//Repository<int> data2 = new Repository<int>();

//Repository<bool> data3 = new Repository<bool>();

//Repository<Book> data4 = new Repository<Book>();


//ArrayList list1 = new ArrayList();
//list1.Add(100);
//list1.Add("salam");
//list1.Add(true);

//foreach(var item in list1)
//{
//    Console.WriteLine(item);
//}


Hashtable hashtable = new Hashtable();

//hashtable.Add("role", "Admin");
//hashtable.Add("name", "Nesir");
//hashtable.Add(100, 200);
//hashtable.Add(200,200);
//hashtable.Add(5, 200);

//foreach(DictionaryEntry item in hashtable)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}

//SortedList sortedList = new SortedList();

//sortedList.Add(100, 200);
//sortedList.Add(5, 100);
//sortedList.Add(55, 100);

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}


//SortedList<string, int> datas = new SortedList<string, int>();

//datas.Add("roleId", 100);
//datas.Add("age", 30);

//foreach (KeyValuePair<string, int> item in datas)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}

//Dictionary<string,string> datas = new Dictionary<string,string>();

//datas.Add("test1", "salam1");
//datas.Add("test2", "salam2");
//datas.Add("test3", "salam3");

//foreach (KeyValuePair<string, string> item in datas)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}

//Console.WriteLine(datas["test1"]);


//Stack<int> nums = new();

//nums.Push(1);
//nums.Push(100);
//nums.Push(18);

//foreach(var item in nums)
//{
//    Console.WriteLine(item);
//}



//Queue<int> nums = new();

//nums.Enqueue(1);
//nums.Enqueue(100);
//nums.Enqueue(18);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}


//IEnumerable<int> nums = new List<int>();


List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);

//Console.WriteLine(numbers.Count);

//for(int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//foreach(var item in numbers)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(numbers.FirstOrDefault(m => m == 5));


//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

//numbers.Remove(5);

//Console.WriteLine("-----------------------");


//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
