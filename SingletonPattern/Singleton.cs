using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton instance;

        protected Singleton(){}

        public static Singleton Instance()
        {
            if (instance==null)
            {
                return new Singleton();
            }

            return instance;
        }
    }
}
