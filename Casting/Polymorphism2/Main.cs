namespace Casting.Polymorphism2 {
    class Main {
        /// <summary>
        /// Using polymorphism with interface
        /// </summary>
        public void RunPolymorphismWithInterface() {
            IMessage message = new MessageA();
            message.MyCustomMethodOn();
        }
    }
}
