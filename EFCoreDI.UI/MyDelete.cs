namespace EFCoreDI.UI
{
    public class MyDelete : IDynamicFun
    {

        public MyDelete(){ Console.WriteLine("init Const Delete"); }

        public void Do()
        {
            Console.WriteLine("DO in MyDelete");
        }
    }
}
