using System;

namespace Casting.Polymorphism2 {
    /// <summary>
    /// Derived class (child) 
    /// </summary>
    class MessageB:IMessage {
        public void MyCustomMethodOn() {
            Console.WriteLine("B");
        }
    }
}
