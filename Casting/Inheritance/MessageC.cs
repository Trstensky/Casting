using System;

namespace Casting.Inheritance {
    /// <summary>
    /// Derived class (child) 
    /// </summary>
    class MessageC:Message {
        public void MyCustomMethodOnC() {
            Console.WriteLine("C");
        }
    }
}
