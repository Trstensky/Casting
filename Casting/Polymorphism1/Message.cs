using System;

namespace Casting.Polymorphism1 {
    /// <summary>
    /// Base class (parent)
    /// </summary>
    class Message {
        public virtual void MyCustomMethodOn() {
            Console.WriteLine("On");
        }
    }
}
