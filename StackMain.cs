using System;

namespace Stack
{
    class Stack
    {
        private int MaxSize;
        private int ActualSize;
        private int[] StackBody;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Stack.Stack"/> class.
        /// </summary>
        /// <param name="Size">Size.</param>

        public Stack(int Size)
        {
            MaxSize = Size;
            StackBody = new int[MaxSize];
            ActualSize = 0;
        }

        /// <summary>
        /// Push the specified PushElement.
        /// </summary>
        /// <param name="PushElement">Push element.</param>

        public void Push(int PushElement)
        {
            if (MaxSize == ActualSize)
            {
                Console.Write("---Eror Push, Stack is overflowed ");
                Console.Write("\n\n\n");
            }

            if (ActualSize == 0)
            {
                StackBody[0] = PushElement;
            }

            else
            {
                for (int i = MaxSize; i > 0; i--)
                {
                    StackBody[i] = StackBody[i - 1];
                }

                StackBody[0] = PushElement;
                ActualSize++;

                Console.Write("---Push Success ");
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Push this instance.
        /// </summary>

        public void Push()
        {
            Console.Write("Push: ");
            int PushElement = Convert.ToInt32(Console.ReadLine());

            if (MaxSize == ActualSize)
            {
                Console.Write("---Eror Push, Stack Overflow ");
                Console.Write("\n");
            }

            else
            {
                if (ActualSize == 0)

                {
                    StackBody[0] = PushElement;
                }

                else
                {
                    for (int i = MaxSize - 1; i > 0; i--)
                    {
                        StackBody[i] = StackBody[i - 1];
                    }

                    StackBody[0] = PushElement;
                }

                ActualSize++;
                Console.Write("---Push Success ");
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Pop this instance.
        /// </summary>

        public void Pop()
        {
            Console.Write("Pop: ");

            if (ActualSize == 0)
            {
                Console.Write("---Eror Pop, Empty Stack ");
                Console.Write("\n");
            }

            else
            {
                for (int i = 0; i > ActualSize; i++)
                {
                    StackBody[i] = StackBody[i - 1];
                }

                StackBody[ActualSize - 1] = 0;
                ActualSize--;
                Console.Write("\n---Pop Success ");
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Resize the specified PlusSize.
        /// </summary>
        /// <param name="PlusSize">Plus size.</param>

        public void Resize(int PlusSize)
        {
            Array.Resize<int>(ref StackBody, MaxSize + PlusSize);
            MaxSize = MaxSize + PlusSize;
        }

        /// <summary>
        /// Gets the head.
        /// </summary>
        /// <returns>The head.</returns>

        public int GetHead()
        {
            Console.WriteLine($"\nStack Head: {StackBody[0]}");
            Console.WriteLine("\n");
            return StackBody[0];
        }

        /// <summary>
        /// Gets the size of the max.
        /// </summary>
        /// <returns>The max size.</returns>

        public int GetMaxSize()
        {
            Console.WriteLine($"\nMax Stack Size: {MaxSize}");
            Console.WriteLine("\n");
            return MaxSize;
        }

        /// <summary>
        /// Gets the actual size.
        /// </summary>
        /// <returns>The actual size.</returns>

        public int GetActualSize()
        {
            Console.WriteLine($"\nActual Stack Size: {ActualSize}");
            Console.WriteLine("\n");
            return ActualSize;
        }
    }
   
    /// <summary>
    /// Program.
    /// </summary>
   
    class Program
    {
       
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>

        static void Main(string[] args)
        {
            Stack test = new Stack(7);
            Console.ReadKey();
        }

    }
}
