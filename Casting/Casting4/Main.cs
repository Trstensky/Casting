using Casting.Inheritance;

namespace Casting.Casting4 {
    class Main {
        /// <summary>
        /// Using casting with "is" operator and type pattern
        /// </summary>
        public void RunCastingOperatorIsTypePattern(Message message) {
            if(message is MessageA messageA) {
                messageA.MyCustomMethodOnA();
            } else if(message is MessageB messageB) {
                messageB.MyCustomMethodOnB();
                messageB.SomeAdditionalMethodB();
            } else if(message is MessageC messageC) {
                messageC.MyCustomMethodOnC();
            }
        }
    }
}
