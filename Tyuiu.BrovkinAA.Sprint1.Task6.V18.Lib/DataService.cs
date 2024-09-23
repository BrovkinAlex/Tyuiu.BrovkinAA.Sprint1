using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BrovkinAA.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {      
            foreach(char ch in value)
            {
                if (!char.IsNumber(ch)) return false;
            }
            return true;
        }
    }
}
