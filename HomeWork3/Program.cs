
string userName;
Console.WriteLine("Kā tevi sauc?");
userName = Console.ReadLine();
Console.WriteLine("Sveiks, " + userName + "!");

int userAge;
Console.WriteLine("Kāds ir tavs vecums?");
userAge = int.Parse(Console.ReadLine());
userAge += 1;
Console.WriteLine("Nākamgad tev paliks " + userAge + ", Tu esi pilngadīgs.");

int num1, num2, maxNum, minNum;
Console.WriteLine("Ievadiet pirmo skaitli");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ievadiet otro skaitli");
num2 = int.Parse(Console.ReadLine());
maxNum = Math.Max(num1, num2);
minNum = Math.Min(num1, num2);
Console.WriteLine("Lielākais skaitlis ir: " + maxNum);
Console.WriteLine("Mazākais skaitlis ir: " + minNum);
Console.WriteLine("Skaitļu dalīšanas atlikums ir: " + num1 % num2);

int num3;
Console.WriteLine("Ievadiet skaitli");
num3 = int.Parse(Console.ReadLine());
if (num3 % 2 == 0)
{
    Console.WriteLine("Jūsu ievadītais skaitlis ir pāra skaitlis");
}
else
{
    Console.WriteLine("Jūsu ievadītais skaitlis ir nepāra skaitlis");
}

int edge1, edge2;
Console.WriteLine("Ievadiet taisnstūra vienas malas garumu:");
edge1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ievadiet taisnstūra otras malas garumu:");
edge2 = int.Parse(Console.ReadLine());
Console.WriteLine("Taisnstūra laukums ir: " + edge1 * edge2);

int edge3;
Console.WriteLine("Ievadiet taisnleņķa trīsstūra malas garumu:");
edge3 = int.Parse(Console.ReadLine());
Console.WriteLine("Taisnleņķa trīsstūra laukums ir: " + edge3 * edge3 / 2);

string userNameA;
int userAgeA;
Console.WriteLine("Kāds ir tavs vārds?");
userNameA = Console.ReadLine();
Console.WriteLine("Kāds ir tavs vecums?");
userAgeA = int.Parse(Console.ReadLine());
Console.WriteLine($"Sveiks {userNameA}, tavs vecums ir {userAgeA}");


Console.ReadLine();
