using System;

namespace Casting.Polymorphism1 {
    /// <summary>
    /// Derived class (child) 
    /// </summary>
    class MessageC:Message {
        public override void MyCustomMethodOn() {
            Console.WriteLine("C");
        }
    }
}
