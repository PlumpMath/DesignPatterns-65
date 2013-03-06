﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    //工厂方法（FactoryMethod）模式是类的创建模式，其用意是定义一个创建产品对象的工厂接口，将实际创建工作推迟到子类中。

    //工厂方法模式是简单工厂模式的进一步抽象和推广。由于使用了多态性，工厂方法模式保持了简单工厂模式的优点，而且克服了它的缺点。

    //在工厂方法模式中，核心的工厂类不再负责所有产品的创建，而是将具体创建工作交给子类去做。这个核心类仅仅负责给出具体工厂必须实现的接口，而不接触哪一个产品类被实例化这种细节。这使得工厂方法模式可以允许系统在不修改工厂角色的情况下引进新产品。

    //在Factory Method模式中，工厂类与产品类往往具有平行的等级结构，它们之间一一对应。
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new CreatorA();
            Light light = creator.Factory();
            light.TurnOn();

            creator = new CreatorB();
            light = creator.Factory();
            light.TurnOff();

            Console.Read();
          
        }
    }
}
