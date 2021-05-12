using System;

namespace CSStudy
{
    
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate
            //创建Delegate_delegate实列
            Delegate delegate_Delegate = new Delegate();
            //实列一个委托,把Delegate_delegate实列的FIntToString方法作为参数
            delegateIntToString delegateIntToString = new delegateIntToString(delegate_Delegate.FIntToString);
            //直接输出委托
            Console.WriteLine(delegateIntToString(45645321)+ "这是Delegate的结果");
            #endregion

            #region Func<>
            //创建工厂实列
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            //2:创建一个返回值是product,参数为空的Func,和productFactory的make**匹配
            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeApple);
            //wrapFactory的WrapProduct方法参数是一个Func实列,返回一个box实列
            Box box1 =wrapFactory.WrapProduct(func1);

            Console.WriteLine(box1.product.Name+"这是Func<>的结果");

            #endregion

            #region Event
            //创建事件拥有者和响应者的实列
            Customer customer = new Customer();
            Waiter waiter = new Waiter();

            //事件只能+=或者-=,Action(事件处理器)用ait+回车补全
            customer.Order += waiter.Action;
            //事件拥有者的某个方法来触发事件
            customer.DianCai();
            #endregion

            #region Lambda
            Func<int, int, int> func = new Func<int, int, int>((int a, int b) => { return a + b; });
            Console.WriteLine(func(9, 8)+"-这是lambda+的结果");
            func = new Func<int, int, int>((int a, int b) => {return a* b; });
            Console.WriteLine(func(9, 8) + "-这是lambda*的结果");
           Func<string,string> funcs = new Func<string, string>((string s) => { return s; });
            Console.WriteLine(funcs("hello lambda")+"这是lambda s的结果");
            #endregion

            #region Lambda简化版
            Func<int, int, int> funcj = (ja,jb)=> { return ja + jb; };
            Console.WriteLine(funcj(9, 18) + "-这是lambda简化+的结果");
            funcj = (a,b) => {return a*b; };
            Console.WriteLine(func(2, 2) + "-这是lambda简化*的结果");
            Func<string, string> funcsj = (s) => { return s; };
            Console.WriteLine(funcs("hello lambda简化") + "这是lambda简化 s的结果");
            #endregion

      
        }
    }
}
