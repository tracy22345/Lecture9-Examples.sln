using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public interface IObserverable
    {
        void Register(IObserver o);//註冊一個觀察者

        void RemoveObserver(IObserver o);//取消一個觀察者

        void Notify();//通知一個觀察者
    }
}