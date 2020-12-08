using System;

namespace Casting.Polymorphism1 {
    /// <summary>
    /// Derived class (child) 
    /// </summary>
    class MessageB:Message {
        public override void MyCustomMethodOn() {
            Console.WriteLine("B");
        }
    }
}
