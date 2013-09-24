using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const String numbers = "0802229738150040007504050778521250779108" +
                                   "4949994017811857608717409843694804566200" +
                                   "8149317355791429937140675388300349133665" +
                                   "5270952304601142692468560132567137023691" +
                                   "2231167151676389419236542240402866331380" +
                                   "2447326099034502447533537836842035171250" +
                                   "3298812864236710263840675954706618386470" +
                                   "6726206802621220956394396308409166499421" +
                                   "2455580566739926971778789683148834896372" +
                                   "2136230975007644204535140061339734313395" +
                                   "7817532822753167159403800462161409535692" +
                                   "1639054296353147555888240017542436298557" +
                                   "8656004835718907054444374460215851541758" +
                                   "1980816805944769287392138652177704895540" +
                                   "0452088397359916079757321626267933279866" +
                                   "8836688757622072034633674655123263935369" +
                                   "0442167338253911249472180846293240627636" +
                                   "2069364172302388346299698267598574043616" +
                                   "2073352978319001743149714886811623570554" +
                                   "0170547183515469169233486143520189196748";
            

            int sumEast = 0, sumNorth = 0, sumNortheast = 0, sumNorthwest = 0;
            int largestEast = 0, largestNorth = 0, largestNortheast = 0, largestNorthwest = 0;
            
            for (int i = 0; i < numbers.Length / 3; i++)
            {
                sumEast = int.Parse(numbers.Substring(i*2,2)) * int.Parse(numbers.Substring(i*2+2,2)) * int.Parse(numbers.Substring(i*2+4,2)) * int.Parse(numbers.Substring(i*2+6,2));
                
                if (sumEast > largestEast)
                {
                    largestEast = sumEast;
                }
            }
            
            for (int i = 0; i < numbers.Length / 3; i++)
            {
                sumNorth = int.Parse(numbers.Substring(i*2,2)) * int.Parse(numbers.Substring(i*2+40,2)) * int.Parse(numbers.Substring(i*2+80,2)) * int.Parse(numbers.Substring(i*2+120,2));
                
                if (sumNorth > largestNorth)
                {
                    largestNorth = sumNorth;
                }
            }
            
            for (int i = 0; i < numbers.Length / 3; i++)
            {
                sumNortheast = int.Parse(numbers.Substring(i*2,2)) * int.Parse(numbers.Substring(i*2+42,2)) * int.Parse(numbers.Substring(i*2+84,2)) * int.Parse(numbers.Substring(i*2+126,2));
                
                if (sumNortheast > largestNortheast)
                {
                    largestNortheast = sumNortheast;
                }
            }
            
            for (int i = 0; i < numbers.Length / 3; i++)
            {
                sumNorthwest = int.Parse(numbers.Substring(i*2+6,2)) * int.Parse(numbers.Substring(i*2+44,2)) * int.Parse(numbers.Substring(i*2+82,2)) * int.Parse(numbers.Substring(i*2+120,2));
                
                if (sumNorthwest > largestNorthwest)
                {
                    largestNorthwest = sumNorthwest;
                }
            }
            Console.WriteLine("The largest product of 4 adjacent numbers from left is: " + largestEast);
            Console.WriteLine("The largest product of 4 adjacent numbers from top to bottom is: " + largestNorth);
            Console.WriteLine("The largest product of 4 adjacent numbers diagonally left to right is: " + largestNortheast);
            Console.WriteLine("The largest product of 4 adjacent numbers diagonally right to left is: " + largestNorthwest);
            
            Console.WriteLine();
            
            if (largestEast > largestNorth && largestEast > largestNortheast && largestEast > largestNorthwest)
             {
                Console.WriteLine(largestEast + " is the largest of the products.");
             }
            if (largestNorth > largestEast && largestNorth > largestNortheast && largestNorth > largestNorthwest)
             {
                Console.WriteLine(largestNorth + " is the largest of the products.");
             }
            if (largestNortheast > largestEast && largestNortheast > largestNorth && largestNortheast > largestNorthwest)
             {
                Console.WriteLine(largestNortheast + " is the largest of the products.");
             }
            if (largestNorthwest > largestNortheast && largestNorthwest > largestNorth && largestNorthwest > largestEast)
             {
                Console.WriteLine(largestNorthwest + " is the largest of the products.");
             }
        }
    }
}
