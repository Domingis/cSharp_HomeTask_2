        //First task//
// System.Console.WriteLine("Введите Трёхзначное число");
// int num = int.Parse(Console.ReadLine());
// num = num / 10;
// num = num % 10;
// System.Console.WriteLine(num);

        //Second task
// System.Console.WriteLine("Введите число");
// String num = Console.ReadLine();
// if (num.Length >=3 ){
//     System.Console.WriteLine(num[2]);
// } 
// else{
//     System.Console.WriteLine("Третей цифры нет");
// }

        //Third task
System.Console.WriteLine("Введите число, обозначающее номер дня недели");
int num = int.Parse(Console.ReadLine());
if (num >=1 && num <=5){
    System.Console.WriteLine("Нет");
}
else if (num >=6 && num <=7){
    System.Console.WriteLine("Да");
}