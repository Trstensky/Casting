using System;

namespace Casting.Inheritance {
    /// <summary>
    /// Derived class (child) 
    /// </summary>
    class MessageA:Message {
        public void MyCustomMethodOnA() {
            Console.WriteLine("A");
        }
    }
}
