//Math>=90, OR Chemestry >=90

//math && chemistry || math && biology || chemistry && biology

int math, biology, chemistry;

Console.WriteLine("Enter your Math resault:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry>=90) || ( biology >=90 && chemistry >=90 )||( math >=90 && biology >=90)) 
{
    Console.WriteLine("Congradulation! You got accepted");
}
else
{
    Console.WriteLine("Your applications cannot cannot be approved");
}