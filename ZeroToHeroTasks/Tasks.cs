using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroToHeroTasks
{
    internal class Tasks
    {
        public static void Task1()
        {
            int number1 = 22;
            int number2 = 11;
            int sum = number1 + number2;
            Console.WriteLine(sum);
        }
        public static void Task2()
        {
            int number = 22;
            int square = number * number;
            Console.WriteLine(square);
        }
        public static void Task3()
        {
            string name = "Nezrin";
            int age = 21;
            Console.WriteLine($" Salam, mənim adım {name}dir və mənim {age} yaşım var.");
        }
        public static void Task4()
        {
            int a = 10;
            int b = 20;
            (a, b) = (b, a);
            Console.WriteLine($"a deyiseninin evvelki deyeri 10, yer deyişmeden sonra 20-dir.\n" +
                $"b deyişeninin evvelki deyeri 20, yer deyişmeden sonra 10-dur.");

        }
        public static void Task5()
        {
            int num1 = 2;
            int num2 = 1;
            int num3 = 91;
            int sum = num1 + num2 + num3;
            double average = sum / 3.0;
            Console.WriteLine($"Total:{sum}\n average:{average}");
        }
        public static void Task6()
        {

            Console.Write("Dördrəqəmli ədəd daxil edin: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Xahiş olunur, dördrəqəmli ədəd daxil edin.");
                return;
            }

            int sum = 0;
            int temp = number;

            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            Console.WriteLine($"Rəqəmlərin cəmi: {sum}");
        }
        public static void Task7()
        {
            Console.Write("Eded daxil edin: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} ədəd cutdur.");
            }
            else
            {
                Console.WriteLine($"{number} ədəd cut deyil.");
            }
        }
        public static void Task8()
        {
            Console.WriteLine("Birinci ededi daxil edin");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin");
            int number2 = int.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine($"{number1}>{number2}");
            }
            else if (number1 < number2)
            {
                Console.WriteLine($"{number1}<{number2}");
            }
            else
            {
                Console.WriteLine($"{number1}={number2}");
            }
        }
        public static void Task9()
        {
            Console.WriteLine("Ədədi daxil edin:");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"{number} müsbət ədəddir.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} mənfi ədəddir.");
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz ədəd sıfırdır.");
            }
        }
        public static void Task10()
        {
            Console.WriteLine("Ədədi daxil edin:");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine($"{number} həm 3-ə, həm də 5-ə bölünür.");
            }
            else
            {
                Console.WriteLine($"{number} həm 3-ə, həm də 5-ə bölünmür.");
            }
        }
        public static void Task11()
        {
            Console.WriteLine("Ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0 || number % 3 == 0)
            {
                if (number % 2 == 0 && number % 3 == 0)
                {
                    Console.WriteLine($"{number} həm 2-yə, həm də 3-ə bölünür");
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} ancaq 2-yə bölünür.");
                }
                else
                {
                    Console.WriteLine($"{number} ancaq 3-ə bölünür.");
                }
            }
            else
            {
                Console.WriteLine($"{number} 2-yə və ya 3-ə bölünmür.");
            }
        }
        public static void Task12()
        {
            Console.WriteLine("Enter month number (1-12):");
            int monthNumber = int.Parse(Console.ReadLine()); ;
            string monthName;
            switch (monthNumber)
            {
                case 1: monthName = "January"; break;
                case 2: monthName = "February"; break;
                case 3: monthName = "March"; break;
                case 4: monthName = "April"; break;
                case 5: monthName = "May"; break;
                case 6: monthName = "June"; break;
                case 7: monthName = "July"; break;
                case 8: monthName = "August"; break;
                case 9: monthName = "Semptember"; break;
                case 10: monthName = "October"; break;
                case 11: monthName = "November"; break;
                case 12: monthName = "December"; break;
                default:
                    monthName = "Invalid month number";
                    break;
            }
            Console.WriteLine(monthName);

        }
        public static void Task13()
        {
            Console.WriteLine("Enter student's score (0-100):");
            int score = int.Parse(Console.ReadLine());

            string grade;

            switch (score)
            {
                case int n when (n >= 91 && n <= 100):
                    grade = "A (Excellent)";
                    break;
                case int n when (n >= 81 && n <= 90):
                    grade = "B (Very Good)";
                    break;
                case int n when (n >= 71 && n <= 80):
                    grade = "C (Good)";
                    break;
                case int n when (n >= 61 && n <= 70):
                    grade = "D (Satisfactory)";
                    break;
                case int n when (n >= 51 && n <= 60):
                    grade = "E (Sufficient)";
                    break;
                case int n when (n >= 0 && n <= 50):
                    grade = "F (Fail)";
                    break;
                default:
                    grade = "Invalid score!";
                    break;
            }

            Console.WriteLine($"Grade: {grade}");
        }
        public static void Task14()
        {
            Console.WriteLine("Enter first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /):");
            char operation = char.Parse(Console.ReadLine());

            double result = 0;
            bool isValidOperation = true;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero!");
                        isValidOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation!");
                    isValidOperation = false;
                    break;
            }

            if (isValidOperation)
            {
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }
        }
        public static void Task15()
        {
            Console.WriteLine("Məhsulun qiymətini daxil edin (AZN):");
            double amount = double.Parse(Console.ReadLine());

            double discountRate = 0;
            string discountMessage = "";

            if (amount >= 100)
            {
                discountRate = 0.10;
                discountMessage = "10% endirim tətbiq edildi";
            }
            else if (amount >= 50 && amount < 100)
            {
                discountRate = 0.05;
                discountMessage = "5% endirim tətbiq edildi";
            }
            else
            {
                discountMessage = "Endirim tətbiq edilmədi";
            }

            double discountAmount = amount * discountRate;
            double finalAmount = amount - discountAmount;

            Console.WriteLine($"\nAlınan məhsulun dəyəri: {amount} AZN");
            Console.WriteLine($"Ödəyəcəyiniz məbləğ: {finalAmount} AZN ({discountMessage})");
        }
        public static void Task16()
        {
            string correctUsername = "admin";
            string correctPassword = "2222";

            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login successful! Welcome, admin!");
            }
            else
            {
                Console.WriteLine("Login failed! Incorrect username or password.");
            }
        }
        public static void Task17()
        {
            const double ExchangeRate = 1.7;

            Console.WriteLine("Currency Converter");
            Console.WriteLine("1. AZN to USD");
            Console.WriteLine("2. USD to AZN");
            Console.Write("Select conversion type (1 or 2): ");

            string choice = Console.ReadLine();

            Console.Write("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());

            double result;
            string conversionMessage;

            switch (choice)
            {
                case "1":
                    result = Math.Round(amount / ExchangeRate, 2);
                    conversionMessage = $"{amount} AZN = {result} USD";
                    break;
                case "2":
                    result = Math.Round(amount * ExchangeRate, 2);
                    conversionMessage = $"{amount} USD = {result} AZN";
                    break;
                default:
                    conversionMessage = "Invalid choice! Please select 1 or 2.";
                    break;
            }

            Console.WriteLine("\nConversion Result:");
            Console.WriteLine(conversionMessage);
            Console.WriteLine($"(Exchange rate: 1 USD = {ExchangeRate} AZN)");
        }
        public static void Task18()
        {
            Console.WriteLine("Boyunuzu daxil edin (metr ilə, məsələn: 1.75):");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Çəkinizi daxil edin (kq ilə):");
            double weight = double.Parse(Console.ReadLine());

            double bmi = Math.Round(weight / (height * height), 2);
            string result;

            if (bmi < 18.5)
                result = "Çəki azlığı";
            else if (bmi >= 18.5 && bmi < 25)
                result = "Normal çəki";
            else if (bmi >= 25 && bmi < 30)
                result = "Artıq çəki";
            else
                result = "Piylənmə";

            Console.WriteLine($"\nBMI nəticəniz: {bmi}");
            Console.WriteLine($"Sizin vəziyyət: {result}");
        }
        public static void Task19()
        {
            double balance = 1000;
            bool continueOperations = true;

            Console.WriteLine("ATM Proqramına xoş gəlmisiniz!");

            while (continueOperations)
            {
                Console.WriteLine("\nƏməliyyat seçin:");
                Console.WriteLine("1. Balansı yoxla");
                Console.WriteLine("2. Pul əlavə et");
                Console.WriteLine("3. Pul çıxar");
                Console.WriteLine("4. Çıxış");
                Console.Write("Seçiminiz (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"\nCari balansınız: {balance:F2} AZN");
                        break;

                    case "2":
                        Console.Write("\nƏlavə ediləcək məbləği daxil edin (AZN): ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            if (depositAmount > 0)
                            {
                                balance += depositAmount;
                                Console.WriteLine($"Əməliyyat uğurla tamamlandı. Yeni balans: {balance:F2} AZN");
                            }
                            else
                            {
                                Console.WriteLine("Xəta: Məbləğ müsbət olmalıdır!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Xəta: Düzgün məbləğ daxil edin!");
                        }
                        break;

                    case "3":
                        Console.Write("\nÇıxarılacaq məbləği daxil edin (AZN): ");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            if (withdrawAmount > 0)
                            {
                                if (withdrawAmount <= balance)
                                {
                                    balance -= withdrawAmount;
                                    Console.WriteLine($"Əməliyyat uğurla tamamlandı. Yeni balans: {balance:F2} AZN");
                                }
                                else
                                {
                                    Console.WriteLine("Xəta: Kifayət qədər balans yoxdur!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Xəta: Məbləğ müsbət olmalıdır!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Xəta: Düzgün məbləğ daxil edin!");
                        }
                        break;

                    case "4": // Çıxış
                        continueOperations = false;
                        Console.WriteLine("\nATM proqramından çıxılır. Xidmətimizdən istifadə etdiyiniz üçün təşəkkürlər!");
                        break;

                    default:
                        Console.WriteLine("\nXəta: Yanlış seçim! Zəhmət olmasa 1-4 arası rəqəm daxil edin.");
                        break;

                }
            }
        }

        public static void Task20()
        {
            int[] arr = { 14, 43, 2, 3, 4 };

            Console.WriteLine();
        }
        public static void Task21()
        {
            int[] arr = { 1, 43, 2, 3, 4 };
            int sum = 0;
            foreach (int n in arr)
            { sum += n; }
            Console.WriteLine(" Elementlərin cəmi:" + sum);
        }
        public static void Task22()
        {
            int[] arr = { 1, 43, 2, 3, 4 };

            double average = arr.Average();
            Console.WriteLine("Elementlərin ortalamasi:" + average);
        }
        public static void Task23()
        {
            int[] numbers = { 12, 45, 23, 67, 8, 91, 34, 56 };

            int max = numbers[0];
            int min = numbers[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
            }

            Console.WriteLine("Array elements:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine($"Largest element: {max} (at index {maxIndex})");
            Console.WriteLine($"Smallest element: {min} (at index {minIndex})");
        }

        public static void Task24()
        {
            int[] arr = { 12, 99, 11, 13, 14 };
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void Task25()
        {
            int[] originalArray = { 10, 20, 30, 40, 50 };
            int[] reversedArray = new int[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                reversedArray[i] = originalArray[originalArray.Length - 1 - i];
            }

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", originalArray));

            Console.WriteLine("\nReversed array:");
            Console.WriteLine(string.Join(", ", reversedArray));
        }
        public static void Task26()
        {
            int[] numbers = { 15, 23, 7, 42, 18, 9, 31 };
            Console.WriteLine("Enter number to search:");
            int searchNumber = int.Parse(Console.ReadLine());

            int foundIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchNumber)
                {
                    foundIndex = i;
                    break;
                }
            }

            Console.WriteLine("\nArray elements:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine($"Number {searchNumber} found at index: {foundIndex}");

        }
        public static void Task27()
        {
            int[] numbers = { 1, 2, 3, 4, 2, 5, 3, 6, 7, 8, 1, 9, 5 };
            int[] duplicates = new int[numbers.Length];
            int duplicateCount = 0;

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", numbers));

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && !Contains(duplicates, numbers[i], duplicateCount))
                    {
                        duplicates[duplicateCount] = numbers[i];
                        duplicateCount++;
                        break;
                    }
                }
            }

            Console.WriteLine("\nDuplicate elements:");
            if (duplicateCount > 0)
            {
                for (int i = 0; i < duplicateCount; i++)
                {
                    Console.Write(duplicates[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("No duplicates found");
            }

            static bool Contains(int[] array, int value, int length)
            {
                for (int i = 0; i < length; i++)
                {
                    if (array[i] == value)
                    {
                        return true;
                    }
                }
                return false;
            }

        }
        public static void Task28()
        {
            int[] numbers = { 12, 45, 23, 67, 8, 91, 34, 56 };

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    secondLargest = largest;
                    largest = numbers[i];
                }
                else if (numbers[i] > secondLargest && numbers[i] != largest)
                {
                    secondLargest = numbers[i];
                }
            }

            Console.WriteLine("Array elements:");
            Console.WriteLine(string.Join(", ", numbers));

            if (secondLargest != int.MinValue)
            {
                Console.WriteLine($"Second largest element: {secondLargest}");
            }
            else
            {
                Console.WriteLine("No second largest element found");
            }
        }
        public static void Task29()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int temp = Math.Abs(number);

            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            Console.WriteLine($"Sum of digits in {number} is: {sum}");
        }
        public static void Task30()
        {
            Console.WriteLine("Enter a number:");
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int digitCount = number == 0 ? 1 : 0;

            while (number > 0)
            {
                digitCount++;
                number /= 10;
            }

            Console.WriteLine($"Number of digits: {digitCount}");
        }
        public static void Task31()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            if (number < 2)
            {
                Console.WriteLine($"{number} is neither prime nor composite.");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine($"{number} is {(isPrime ? "prime" : "composite")}.");
        }
        public static void Task32()
        {
            Console.WriteLine("Enter a number:");
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int original = number;
            int reversed = 0;

            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }

            bool isPalindrome = (original == reversed);
            Console.WriteLine($"{original} is {(isPalindrome ? "" : "not ")}a palindrome.");
        }
        public static void Task33()
        {
           
                Console.WriteLine("Enter the number of Fibonacci terms to generate:");
                int n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("Please enter a positive integer.");
                    return;
                }

                Console.WriteLine("\nFibonacci sequence:");

                long a = 0;
                long b = 1;
                Console.Write(a);

                if (n > 1)
                {
                    Console.Write(", " + b);
                }

                for (int i = 2; i < n; i++)
                {
                    long next = a + b;
                    Console.Write(", " + next);
                    a = b;
                    b = next;
                }
            }
        }

    }



    





