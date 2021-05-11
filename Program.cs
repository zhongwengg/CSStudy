﻿using System;

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
            Console.WriteLine(delegateIntToString(45645321)+ "这是Delegate_delegate的结果");
            #endregion

            #region Func<>
            //创建工厂实列
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();
            //创建一个返回值是product,参数为空的Func,和productFactory的make**匹配
            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeApple);
            //wrapFactory的WrapProduct方法参数是一个Func实列,返回一个box实列
            Box box1 =wrapFactory.WrapProduct(func1);
            Console.WriteLine(box1.product.Name+"这是Func的结果");

            #endregion

        }
    }
}
