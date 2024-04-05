using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new stack of integers
        Stack<int> myStack = new Stack<int>();

        // Push some elements onto the stack
        myStack.Push(10); //bottom 
        myStack.Push(20);
        myStack.Push(30);
        myStack.Push(40);
        myStack.Push(50);
        myStack.Push(60); //top
        
        Stack<int> myStack_second = new Stack<int>();
        Stack<int> myStack_third = new Stack<int>();
        // Push some elements onto the stack
        myStack_second.Push(110); //bottom
        myStack_second.Push(220);
        myStack_second.Push(330);
         myStack_second.Push(440);
        myStack_second.Push(550);
        myStack_second.Push(660); //top
        
        myStack_third.Push(101); //bottom 
        myStack_third.Push(202);
        myStack_third.Push(303);
        myStack_third.Push(404);
        myStack_third.Push(505);
        myStack_third.Push(606); //top
        
        
        Stack<int> myStack_result = new Stack<int>();
        
        
        for(int i = 0 ; myStack.Count> 0;i++){
            //the switch combination depends on the input carrying stacks. excluding result.
            //we are switching between the combinations.
            //0,3,6,9,12,15
            //1,4,7,10,13,16
            //2,5,8,11,14,17
            if(i==0||i%3==0){
                
        myStack_result.Push(myStack.Pop()); //30
        myStack_result.Push(myStack_second.Pop()); //330 ->betn
        myStack_result.Push(myStack_third.Pop()); //303
            }
            
            if(i==1||i%3==1){
                 myStack_result.Push(myStack_second.Pop()); //220
        myStack_result.Push(myStack_third.Pop()); //202
        myStack_result.Push(myStack.Pop()); //20 
            }
            if(i==2||i%3==2){
        myStack_result.Push(myStack_third.Pop()); //303
        myStack_result.Push(myStack.Pop()); //10 
                myStack_result.Push(myStack_second.Pop()); //110
            }
        
            
        }
        int count = 0;
while (myStack_result.Count > 0)
{
    count++;
    Console.WriteLine($"stack result ko value for {count}: {myStack_result.Pop()}");
}
        
        
       
        // Peek at the top element without removing it
        // Console.WriteLine("Top element of the stack: " + myStack_result.Peek());

        // Pop elements off the stack and print them
        Console.WriteLine("Popping elements off the stack:");
        while (myStack.Count > 0)
        {
            int element = myStack.Pop();
            Console.WriteLine(element);
        }
    }
}
