

namespace WindowsFormsApplication2
{
    public class ExpressionChanges
    {
        //выводит false, если строка не соотвествует нужному формату
        static public bool Check_string(string line)
        {
            if (IsEmpty(line) | ChechNotX(line))
                return false;
            else
                return true;
        }

        static private bool IsEmpty(string line)
        {
            if ((line == ""))
                return true;
            else
                return false;
        }

        static private bool ChechNotX(string line)
        {
            if (!line.Contains("x"))
                return true;
            else
                return false;
        }
    }
}
