using System;

namespace Casting.Polymorphism1 {
    /// <summary>
    /// Derived class (child) 
    /// </summary>
    class MessageA:Message {
        public override void MyCustomMethodOn() {
            Console.WriteLine("A");
        }
    }
}
