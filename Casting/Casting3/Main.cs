using Casting.Inheritance;

namespace Casting.Casting3 {
    class Main {
        /// <summary>
        /// Using casting with "as" operator
        /// </summary>
        public void RunCastingOperatorAs(MessageA messageA, MessageB messageB, MessageC messageC) {
            if(messageA != null) {
                messageA.MyCustomMethodOnA();
            } else if(messageB != null) {
                messageB.MyCustomMethodOnB();
                messageB.SomeAdditionalMethodB();
            } else if(messageC != null) {
                messageC.MyCustomMethodOnC();
            }
        }
    }
}


