using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace ShapeOOP
{
    class MyEllipse
    {
        public int width;
        public int height;
        public int positionX;
        public int positionY;
        public Color color;

        //constructor - used when objects are created
        public MyEllipse(int width, int height, int positionX, int positionY, Color color)
        {
            this.width = width;
            this.height = height;
            this.positionX = positionX;
            this.positionY = positionY;
            this.color = color;
        }


    }
}
