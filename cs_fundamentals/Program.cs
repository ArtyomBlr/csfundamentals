using System;
using System.Diagnostics;
// !START: Angry Birds - path calculation
// namespace AngryBirds
// {
//   public static class AngryBirdsTask
//   {
//     public static double FindSightAngle(double v, double distance)
//     {
//       const double g = 9.8;

//       double degreePath = 45 + Math.Acos(g * distance / (v * v)) / 2;
//       double horizontalDistance = v * v * Math.Sin(2 * DegreeTransformer(degreePath)) / g;

//       if (horizontalDistance < distance)
//       {
//         return double.NaN;
//       }

//       return DegreeTransformer(degreePath);
//     }

//     public static double DegreeTransformer(double degree)
//     {
//       return degree * Math.PI / 180;
//     }
//   }
// }
// !END: Angry Birds - path calculation

// !START: Billiards - path calculation
// namespace Billiards
// {
//     public static class BilliardsTask
//     {
//       public static double BounceWall(double directionRadians, double wallInclinationRadians)
//       {
//         return (wallInclinationRadians * 2.0) - directionRadians;
//       }
//     }
// }
// !END: Billiards - path calculation

// !START: Loan - calculation
// class Loan {
//   public static void Main() 
//   {
//     var userInput = Console.ReadLine();

//       if (userInput != null)
//       {
//         Calculate(userInput);
//       }
//   }


//   public static void Calculate(string userInput)
//   {
//     var loanData = userInput.Split(' ');

//     var sum = int.Parse(loanData[0]);
//     var percents = int.Parse(loanData[1]);
//     var months = int.Parse(loanData[2]);

//     double result = sum * (percents  / 100 + months) ;

//     Console.WriteLine(result);
//   }
// }
// !END: Loan - calculation
