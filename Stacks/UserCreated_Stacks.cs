using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack theStack = new Stack(4);
            theStack.push("Star Wars: Empire Strikes Back");
            theStack.push("Jaws");
            theStack.push("Jaws 2");
            theStack.push("Titanic");
            theStack.push("Rocky"); //This one will give us the "This stack is full" error we coded below since we created a stack of only 4 cells

            Console.WriteLine("============================== \nAbout to peek:");
            Console.WriteLine("'" + theStack.peek() + "'" + " is at the top of the stack\n");

            Console.WriteLine("============================== \nThe Stack contains:\n");
            while (!theStack.isEmpty())
            {
                string movie = theStack.pop();
                WriteLine(movie);

            }
        }
    }

    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void push(string m)
        {
            if(isFull())
            {
                Console.WriteLine("This stack is full");
            }
            else 
            {
                top++;
                stackArray[top] = m;
            }
        }

        public string pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("The stack is empty");
                return "--";
            }
            else
            {
                int old_top = top;
                top--;
                return stackArray[old_top];
            }
        }

        public string peek()
        {
            return stackArray[top];
        }

        private bool isFull()
        {
            return (maxSize - 1 == top);
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

    }
}