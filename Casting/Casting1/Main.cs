using Casting.Inheritance;

namespace Casting.Casting1 {
    class Main {
        /// <summary>
        ///  /********************************* Originale code **********************************
        ///  * 1. Double casting is bad solution if it is not nessesarry:
        ///  *      a) casting "is" operator
        ///  *      b) casting "as" operator
        ///  * 2. In the condition block there is casting with "as" operator. Here we can use unsafe casting to improve performance.
        ///  * 3. Null conditional "ternary" operator is already checked inside if condition, if message is equal null then condition is false and ternary operator on null condition never run. We have to avoid redundand conditions. We have to write code carefully and clean.
        ///  *    
        ///  * Conclusion: code is double casted with redundant conditions and low performance and we can write much more better and cleaner code. Rateing this code is 4 when best value is 1 and the worst value is 5.
        ///  ***********************************************************************************/
        /// </summary>
        public void RunCastingOriginal(Message message) {            
            if(message is MessageA) {
                var messageA = message as MessageA;
                messageA?.MyCustomMethodOnA();
            } else if(message is MessageB) {
                var messageB = message as MessageB;
                messageB?.MyCustomMethodOnB();
                messageB?.SomeAdditionalMethodB();
            } else if(message is MessageC) {
                var messageC = message as MessageC;
                messageC?.MyCustomMethodOnC();
            }
        }
    }
}
