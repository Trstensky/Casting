using System;

namespace Casting.Inheritance {
    /// <summary>
    /// Derived class (child) 
    /// </summary>
    class MessageB:Message {
        public void MyCustomMethodOnB() {
            Console.WriteLine("B");
        }

        public void SomeAdditionalMethodB() {
            Console.WriteLine("AdditionalB");
        }
    }
}
