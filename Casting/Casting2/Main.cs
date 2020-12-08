using Casting.Inheritance;

namespace Casting.Casting2 {
    class Main {
        /// <summary>
        /// Using casting with "is" operator
        /// </summary>
        public void RunCastingOperatorIs(Message message) {         
            if(message is MessageA) {
                var messageA = (MessageA)message;
                messageA.MyCustomMethodOnA();
            } else if(message is MessageB) {
                var messageB = (MessageB)message;
                messageB.MyCustomMethodOnB();
                messageB.SomeAdditionalMethodB();
            } else if(message is MessageC) {
                var messageC = (MessageC)message;
                messageC.MyCustomMethodOnC();
            }
        }
    }
}
