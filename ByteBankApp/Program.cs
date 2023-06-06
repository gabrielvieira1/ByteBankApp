//Console.WriteLine($" A senha é valida? {PasswordIsValid("#Root@123")}");

using ByteBankApp;

public class Program
{
  public static void Main(string[] args)
  {
    //Console.WriteLine($" A senha é valida? {PasswordIsValid("#Root@123")}");
    Console.WriteLine($" A senha é valida? {Password.PasswordIsValid("1234567")}");

    Console.WriteLine($" A senha é valida? {Password.PasswordIsValid2("#Root123Root1234")}");
  }
}