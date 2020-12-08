using System;

namespace Casting.Polymorphism2 {
    /// <summary>
    /// Derived class (child) 
    /// </summary>
    class MessageA:IMessage {
        public void MyCustomMethodOn() {
            Console.WriteLine("A");
        }
    }
}
