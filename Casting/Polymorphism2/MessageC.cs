using System;

namespace Casting.Polymorphism2 {
    /// <summary>
    /// Derived class (child) 
    /// </summary>
    class MessageC:IMessage {
        public void MyCustomMethodOn() {
            Console.WriteLine("C");
        }
    }
}
