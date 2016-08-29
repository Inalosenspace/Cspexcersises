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
            Ball ball = new Ball(2,100);
            Ball ball2 = new Ball(0,0);

            ball.Pop();
            Console.WriteLine("Current ball1 size, throws: {0}");
            Console.WriteLine(ball.GetBallSize());
            Console.WriteLine(ball.GetThrows());


            Console.ReadLine();
        }
    }
}
