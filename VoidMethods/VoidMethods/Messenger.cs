using System;

namespace VoidMethods
{
    /*
     * 1. Access Level: Who can call the method?
     * 2. Return Type:  Does the method return any data? If so what kink of data?
     * 3. Name:         What name should other code blocks use to run the method?
     * 4. Parameters:   What data needs to be given to the method to do its job?
     * 5. Code Block:   What statements should be run when the method is called?
     */
    class Messenger
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World");
        }
    }
}