// Business Bread

using System;
using System.Collections.Generic;


// namespace Scorer.Models
// {
//   public class Game
//   {
//     public int tallyScore(string word)
//     {
//       int score = 0;
//       string unusedVar = word;
//       // Version 1: use foreach-loop.
//       foreach (char c in word)
//       {
//         if (c.Equals('a') || c.Equals('e') || c.Equals('i') || c.Equals('o') || c.Equals('u') || c.Equals('l') || c.Equals('n') || c.Equals('r') || c.Equals('s') || c.Equals('t'))
//         {
//           score += 1;
//         }
//         else if (c.Equals('d') || c.Equals('g'))
//         {
//           score += 2;
//         }
//         else if (c.Equals('b') || c.Equals('c') || c.Equals('m') || c.Equals('p'))
//         {
//           score += 3;
//         }
//         else if (c.Equals('f') || c.Equals('h') || c.Equals('v') || c.Equals('w') || c.Equals('y'))
//         {
//           score += 4;
//         }
//         else if (c.Equals('k'))
//         {
//           score += 5;
//         }
//         else if (c.Equals('j') || c.Equals('x'))
//         {
//           score += 8;
//         }
//         else if (c.Equals('q') || c.Equals('z'))
//         {
//           score += 10;
//         }
//         else
//         {
//           Console.WriteLine(c + " is not a character in the game, ignoring it");
//         }
//       }
//       return score;
//     }
//   }
// }