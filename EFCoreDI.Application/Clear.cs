namespace EFCoreDI.Application
{
    public class Clear : IDynamicFun
    {
        private Clear(){}
        
        private static Clear insant;

        public static Clear GetInstent()
        {
            if (insant == null)
            {
                insant = new Clear();
            }
            return insant;
        }
        
        
        public void Do(string parameter)
        {
            Console.WriteLine($"Call me Do in {nameof(Clear)}");
        }
    }
}
