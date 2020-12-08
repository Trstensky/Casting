
/********************************** Analyze casting problem *************************************
 * 1. We have to be careful that we are not using casting to solve a problem that would be better solved with polymorphism.
 * 2. We can use unsafe casting. Unsafe casting throw exception and this is a bad solution because application failes.
 * 3. We can use safe casting with "is" operator. Safe casting never throw exception and this is a good solution but problem is that input is accessed twice (first time in the condition and second time in the conditions block - that means double casting).
 * 4. We can use safe casting with "as" operator. This is also good solution but problem is it doesn't work with non-nullable types like int and it doesn't distinguish between a null value and the wrong type.
 * 5. We can use safe casting with "is" operator and type pattern. Input is only accessed once. The pattern will not match if input is null. Non-nullable types like int are supported. I think this is the best solution for casting.
 ***********************************************************************************************/

using Casting.Inheritance;

namespace Casting {
    class Program {

        static void Main() {
            // Casting original
            RunCastingOriginal();

            // Casting with "is" operator 
            RunCastingOperatorIs();

            // Casting with "as" operator
            RunCastingOperatorAs();

            // Casting with "is" operator and type pattern 
            RunCastingOperatorIsTypePattern();

            // Using polymorphism with simple inheritance 
            RunPolymorphismWithSimpleInheritance();

            // Using polymorphism with interface 
            RunPolymorphismWithInterface();
        }

        /// <summary>
        /// Casting original
        /// </summary>
        static void RunCastingOriginal() {
            Message messageA = new MessageA();
            new Casting1.Main().RunCastingOriginal(messageA);
        }

        /// <summary>
        /// Casting with "is" operator 
        /// </summary>
        static void RunCastingOperatorIs() {
            Message messageA = new MessageA();
            new Casting2.Main().RunCastingOperatorIs(messageA);
        }

        /// <summary>
        /// Casting with "as" operator
        /// </summary>
        static void RunCastingOperatorAs() {
            object objMessageA = new MessageA();
            var messageA = objMessageA as MessageA;
            new Casting3.Main().RunCastingOperatorAs(messageA, null, null);
        }

        /// <summary>
        /// Casting with "is" operator and type pattern 
        /// </summary>
        static void RunCastingOperatorIsTypePattern() {
            Message messageA = new MessageA();
            new Casting4.Main().RunCastingOperatorIsTypePattern(messageA);
        }

        /// <summary>
        /// Using polymorphism with simple inheritance 
        /// </summary>
        static void RunPolymorphismWithSimpleInheritance() {
            new Polymorphism1.Main().RunPolymorphismWithSimpleInheritance();
        }

        /// <summary>
        /// Using polymorphism with interface 
        /// </summary>
        static void RunPolymorphismWithInterface() {
            new Polymorphism2.Main().RunPolymorphismWithInterface();
        }
    }
}