//C#.Seminar #1 Howe work. Alexeev


//Task #1 (2). Program takes 2 numeric, and print maximum value

/*Console.WriteLine("Dear User pls input first num");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("And secound num please");
int numB = Convert.ToInt32(Console.ReadLine());
int max = numA;
if (numA < numB) {
    max = numB;
}  
Console.WriteLine($"Max num is {max}");*/

//Task2 #2 (4). Program takes 3 numeric, and print maximum value
/*Console.WriteLine("Dear User pls input first num");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("And secound num please");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("And third num please");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;
if (max < numB) {
    max = numB;
}
if (max < numC) {
    max = numC;
}
Console.WriteLine($"Max num is {max}");*/

// Task #3 (6). Program takes num, and give answered it even or not.
/*Console.WriteLine("Dear User pls input num");
int numA = Convert.ToInt32(Console.ReadLine());
int balance = numA % 2;
if (balance == 0) {
    Console.WriteLine("It`s even");
}
else {
    Console.WriteLine("It`s NOT even");
}*/

// Task #4 (8). Program takes num, and print all even from 1 to N.
Console.WriteLine("Dear User pls input num");
int numN = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= numN){
           int balance =  current % 2;
           if (balance == 0){
            Console.Write(current + ", ");
        }
    
    current++;
}