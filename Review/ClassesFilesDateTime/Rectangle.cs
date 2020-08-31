using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesFilesDateTime
{
    public class Rectangle
    { 
    
        private int width { get; set; }
        private int height { get; set; }


        public DateTime creationDate { get; set; }

             

        public Rectangle()
        {
            width = 0;
            height = 0;
            creationDate = DateTime.Now;

        }
        /// <summary>
        /// Overloaded constructor for the Rectangle Class
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
            creationDate = DateTime.Now;

        }

        /// <summary>
        /// Calculate area of the rectangle
        /// </summary>
        /// <returns>The area of the rectangle</returns>
        public double area()
        {
            return width * height;
        }


    }
}
