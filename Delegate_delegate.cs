using System;

namespace CSStudy
{
    //声明一个委托
    delegate string delegateIntToString(int i);
    class Delegate_delegate
    {
       //创建一个和委托匹配的方法
       public string FIntToString(int i)
        {
            return i.ToString();
        }
    }
}
