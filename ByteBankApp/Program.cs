//Console.WriteLine($" A senha é valida? {PasswordIsValid("#Root@123")}");

using ByteBankApp;

public class Program
{
  public static void Main(string[] args)
  {
    //Console.WriteLine($" A senha é valida? {PasswordIsValid("#Root@123")}");
    Console.WriteLine($" A senha é valida? {Password.IsValidPassword("1234567")}");

    Console.WriteLine($" A senha é valida? {Password.IsValidPassword2("#Root123Root1234")}");
  }
}