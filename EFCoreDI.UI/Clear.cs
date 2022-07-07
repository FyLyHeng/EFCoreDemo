namespace EFCoreDI.UI
{
    public class Clear : IDynamicFun
    {
        public Clear(){ Console.WriteLine("init Const Clear"); }
        public void Do()
        {
            Console.WriteLine($"Call me Do in {nameof(Clear)}");
        }

        public static void NotDo()
        {
            Console.WriteLine($"Not Do");

        }
    }
}
