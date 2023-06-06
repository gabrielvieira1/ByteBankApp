using ByteBankApp;
using System.ComponentModel;

namespace ByteBankAppTest
{
  public class TestPassword
  {
    
    [Fact]
    public void PasswordRight()
    {
      var password = "1233455";
      var result = Password.PasswordIsValid2(password);
      Assert.True(result);
    }

    [Fact]
    public void Test1()
    {

    }
  }
}