using System;

namespace CSStudy
{
    
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate_delegate
            //创建Delegate_delegate实列
            Delegate_delegate delegate_Delegate = new Delegate_delegate();
            //实列一个委托,把Delegate_delegate实列的FIntToString方法作为参数
            delegateIntToString delegateIntToString = new delegateIntToString(delegate_Delegate.FIntToString);
            //直接输出委托
            Console.WriteLine(delegateIntToString(45645321)+ "这是Delegate_delegate的结果");
            #endregion
        }
    }
}
