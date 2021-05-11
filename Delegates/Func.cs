using System;
namespace CSStudy
{
   
    //2:创建一个Func<>模板
   
    class Product
    {
        public string Name { get; set; }
    }
    class Box
    {
        public Product product { get; set; }
    }
    

    //包装工厂,把box和product分离
    class WrapFactory
    {
        //1:创建一个返回BOX,参数是Func<>模板方法,Func<>的返回值应该是Product
        public Box WrapProduct(Func<Product> getProduct)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();//接收getProduct.Invoke()创建的product
            box.product = product;
            return box;
        }
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


}