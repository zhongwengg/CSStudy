using System;
namespace CSStudy
{
    //事件信息,命名一般<<事件+EventArgs>>,派生自类库EventArgs
    public class OrderEventArgs:EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    //声明一个委托类型,委托名字一般用 <<事件+EventHandler>> 命名!!
    public delegate void OrderEventHandler(Customer customer,OrderEventArgs e);//参数为事件拥有者,事件信息
    
    //事件的拥有者
    public class Customer
    {
        //创建一个委托字段
        private OrderEventHandler orderEventHandler;
        //声明事件 event关键字后面跟委托类型
        public event OrderEventHandler Order
        {
            add
            {
                this.orderEventHandler += value;
            }
            remove
            {
                this.orderEventHandler -= value;
            }
        }

        public void DianCai()
        {       
            if (this.orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "叫花鸡 - 这是event的结果";
                e.Size = "大份 - 这是event的结果";
                this.orderEventHandler.Invoke(this, e);
            }
        }
       
    }
    //创建事件的响应者
    public class Waiter
    {
        public void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("i will serve you the dish-{0}", e.DishName);

        }
    }



}
