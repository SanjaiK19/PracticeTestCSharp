using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    public class ParcelDimensionsRecord
    {
        struct Dimensions
        {
            public double length;
            public double width;
            public double height;
            public Dimensions(double length, double width, double height)
            {
                if (length <= 0 || width <= 0 || height <= 0)
                {
                    throw new ArgumentException("Invalid dimensions");
                }
                this.length = length;   
                this.width = width; 
                this.height = height;
            }

            public double Volume()
            {
                return length * width * height;
            }
        }

        class Parcel
        {
            public Dimensions Size;
        }

        public class ParcelDimensions {
            static void Main()
            {
                Dimensions dimension1 = new Dimensions(10,8,6);
                Dimensions dimension2 = dimension1;
                dimension2.height = 12;

                Console.WriteLine($"Original :\nLength: {dimension1.length}\nWidth: {dimension1.width}\nHeight: {dimension1.height}\nVolume: {dimension1.Volume()}");
                Console.WriteLine($"Copy :\nLength: {dimension2.length}\nWidth: {dimension2.width}\nHeight: {dimension2.height}\nVolume: {dimension2.Volume()}");

                Parcel parcel1 = new Parcel();   
                parcel1.Size = new Dimensions(3,4,5);
                Parcel parcel2 = parcel1;
                parcel2.Size = new Dimensions(4, 5, 6);

                Console.WriteLine($"Parcel 1 Volume : {parcel1.Size.Volume()}");
                Console.WriteLine($"Parcel 2 Volume : {parcel2.Size.Volume()}");


            }
        }
    }
}
