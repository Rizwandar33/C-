using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class ClassStatic
    {
        public static void Fun(int x, int y)
        {
            int sum = x + y;
          Console.WriteLine($"The value of field is {sum}");
        }
    }
}
internal class StaticExample
{
public static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        ClassStatic.Fun(x, y);
    }
}