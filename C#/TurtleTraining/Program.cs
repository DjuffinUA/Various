using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
		static void WriteT(int size)
        {
			Turtle.Move(size);
			Turtle.TurnRight();
			Turtle.Move(30);
			Turtle.Angle =270;
			Turtle.Move(60);
		}
        static void Main(string[] args)
        {
			Turtle.Speed = 9;
			int i = 0;
			while (i < 4)
			{
				Turtle.Move(100);
				//Turtle.TurnRight();
				//Turtle.Turn( 90 );
				Turtle.TurnLeft();
				i++;
			}
			int n = 0;
			while (n < 4)
            {
				Turtle.Move(100);
				Turtle.TurnRight();
				n++;
            }

			for (int l = 0; l < 4; l++)
            {
				Turtle.Move(25);
				Turtle.TurnRight();
				Turtle.Move(25);
				Turtle.TurnRight();
				Turtle.Move(25);
				Turtle.TurnLeft();
				Turtle.Move(25);
				Turtle.TurnLeft();
			}

			Turtle.X = 200;
			Turtle.Y = 200;

			int size = 60;

			WriteT(size);

		}
    }
}
