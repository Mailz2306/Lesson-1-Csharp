﻿/* 
Задача No1. Напишите программу, которая на вход принимает два числа 
и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет

Задача No3. Напишите программу, которая будет выдавать название 
дня недели по заданному номеру.
3 -> Среда
5 -> Пятница

 
Console.WriteLine("Введите номер дня недели"); 

int a = int.Parse(Console.ReadLine());

if (a == 1){
Console.WriteLine ("Это понедельник");    
}

if (a == 2){
Console.WriteLine ("Это вторник");    
}

if (a == 3){
Console.WriteLine ("Это среда");    
}

if (a == 4){
Console.WriteLine ("Это четверг");    
}

if (a == 5){
Console.WriteLine ("Это пятница");    
}

if (a == 6){
Console.WriteLine ("Это суббота");    
}

if (a == 7){
Console.WriteLine ("Это воскресенье");    
}

if (a > 7){
    Console.WriteLine("Это не день недели");
}

if (a < 1){
    Console.WriteLine("Это не день недели");
}

*/ 

/*
Задача No5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"

Задача No7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6 782 -> 2 918 -> 8
*/ 

/*
int N = int.Parse(Console.ReadLine()); 

int a = -N; 

while (a <= N){
   Console.Write($"{a} "); 
      a = a + 1; 
}


Console.WriteLine("Введите трехзначное число");

int N = int.Parse(Console.ReadLine()); 

if (N < 1000 & N > 99){
    Console.WriteLine(N % 10);
}

else {
    Console.WriteLine("Введите правильное число");
}
 
---------------------------- 
/* ДОМАШНЕЕ ЗАДАНИЕ 1: 
 Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 

РЕШЕНИЕ ЗАДАЧИ 2: 

Console.WriteLine("Введите первое число");

int a = int.Parse(Console.ReadLine()); 

Console.WriteLine("Введите второе число");

int b = int.Parse(Console.ReadLine());

if (a > b){
    Console.WriteLine($"a = {a} ; b = {b} -> max {a} ");
}

else{
    Console.WriteLine($"a = {a} ; b = {b} -> max {b} ");
} 

-----------------------
ЗАДАЧА 3: 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 

РЕШЕНИЕ ЗАДАЧИ 3

Console.WriteLine("Введите первое число");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");

int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");

int c = int.Parse(Console.ReadLine());

int max = a;

if (max < b) max = b;
if (max < c) max = c;

Console.WriteLine($" {a} {b} {c} -> " + max);

--------------------
ЗАДАЧА 4: 

Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

РЕШЕНИЕ ЗАДАЧИ 4: 

Console.WriteLine("Введите ваше число и я проверю четное оно или нет");

int a = int.Parse(Console.ReadLine());

if (a % 2 == 0 ){
    Console.WriteLine($" {a} -> да");
}
else {
    Console.WriteLine($" {a} -> нет");
}
 
------------- 

ЗАДАЧА 5: 
*/ 


 