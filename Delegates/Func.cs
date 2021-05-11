using System;
namespace CSStudy
{


    #region 一些类
    class Product
    {
        public string Name { get; set; }
    }
    class Box
    {
        public Product product { get; set; }
    }

    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }

        public Product MakeApple()
        {
            Product product = new Product();
            product.Name = "Apple";
            return product;
        }
    }
    #endregion



    
    class WrapFactory
    {
        //1:创建一个返回BOX,参数是Func<>模板方法,Func<>需要返回一个Product
        public Box WrapProduct(Func<Product> getProduct)//注:如果这里不用委托,参数就直接调用productFactory.MakePizza();
        {                                               //哪每做一种新产品,都要用一个新的包装产品方法
            Box box = new Box();
            Product product = getProduct.Invoke();//接收getProduct.Invoke()创建的product
            box.product = product;
            return box;
        }
    }


}