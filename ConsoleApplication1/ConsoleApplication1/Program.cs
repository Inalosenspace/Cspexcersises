using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////BOOK
            ////Creating new instance and Showing it
            //Book book = new Book("harry potter", "J.K. Rowling");
            //Console.WriteLine(book.GetTitle());

            //book.SetTitle("New Title");
            //Console.WriteLine(book.GetTitle());

       
            //===============================BALL & COLOR=================================================

            
            //=========================COLOR=====================================
            //Creating new color, alpha by default is 255
            Color color = new Color(120, 100, 100);

            //Checking if alpha's default color is correct
            Console.WriteLine("Alpha color: {0}",color.GetAlphaColor());


            //==========================BALL=========================
            //Creating balls
            Ball ball = new Ball(new Color(100,200,255),100,2);
            Ball ball2 = new Ball(new Color(100,100,100),200,0);

            //Throwing a ball2 for a couple times
            Console.WriteLine("Throwing ball for a couple of times");
            ball2.Throw();
            ball2.Throw();
            ball2.Throw();

            //Checking values 
            Console.WriteLine("Ball throws: {0}",ball.GetThrows());
            Console.WriteLine("Ball2 throws: {0}",ball2.GetThrows());

            //Pop a ball
            Console.WriteLine("Trying to throw a popped ball");
            ball2.Throw();

            //Checking values 
            Console.WriteLine("Ball throws: {0}", ball.GetThrows());
            Console.WriteLine("Ball2 throws: {0}", ball2.GetThrows());

            Console.ReadLine();
        }
    }
}
