using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    /// <summary>
    /// 代理（Proxy）模式:给某一个对象提供一个代理，并由代理对象控制对原对象的引用。
    /// </summary>
    /// 如果按照使用目的来划分，代理有以下几种：
    ///远程（Remote）代理：为一个位于不同的地址空间的对象提供一个局域代表对象。这个不同的地址空间可以是在本机器中，也可是在另一台机器中。远程代理又叫做大使（Ambassador）。
    ///虚拟（Virtual）代理：根据需要创建一个资源消耗较大的对象，使得此对象只在需要时才会被真正创建。
    ///Copy-on-Write代理：虚拟代理的一种。把复制（克隆）拖延到只有在客户端需要时，才真正采取行动。
    ///保护（Protect or Access）代理：控制对一个对象的访问，如果需要，可以给不同的用户提供不同级别的使用权限。
    ///Cache代理：为某一个目标操作的结果提供临时的存储空间，以便多个客户端可以共享这些结果。
    ///防火墙（Firewall）代理：保护目标，不让恶意用户接近。
    ///同步化（Synchronization）代理：使几个用户能够同时使用一个对象而没有冲突。
    ///智能引用（Smart Reference）代理：当一个对象被引用时，提供一些额外的操作，比如将对此对象调用的次数记录下来等。
    ///在所有种类的代理模式中，虚拟（Virtual）代理、远程（Remote）代理、智能引用代理（Smart Reference Proxy）和保护（Protect or Access）代理是最为常见的代理模式。
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();
            Console.Read();
        }
    }
}
