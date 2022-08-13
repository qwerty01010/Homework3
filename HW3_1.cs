
Console.WriteLine ("Является ли число палиндромом");
Console.WriteLine ("Введите пятизначное число");
var Numb = int.Parse (Console.ReadLine ()!);

if (Numb > 9999 && Numb < 100000)
 {
     int step1 = Numb%10; 
     int step2 = Numb/10000; 
     int step3 = Numb%100; 
     int step4 = step3/10; 
     int step5 = Numb/1000; 
     int step6 = step5%10; 
     if (step1 == step2 && step4 == step6) 
        {Console.WriteLine("Число является палиндромом!");}
 else {Console.WriteLine("Число не является палиндромом!");}
 }

else {Console.WriteLine("Вы ввели не пятизначное число!");} 