using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims
{

    /// <summary>
    /// Class contains data for inputing an expression, and then computing the expression using Dijkstras algorithim
    /// </summary>
    public static class ExpressionEvaluation
    {
        public static double Evaluate(string inputString)
        {
            
            Stack<char> operators = new Stack<char>();
            Stack<double> values = new Stack<double>();
            // Used as a place holder for numbers in the input string. It is useful because it can be used to read numbers larger then 9. 
            // As the itteration statement iterates, any time it comes across a number, it adds it to the numberString. If the input string
            // Continues to hold number characters for the given real number, it adds it to the string. Once it no longer runs across number characters,
            // The string is set to an empty value.
            string numberString = "";

            // For each element in the length of the string
            for(int i = 0; i < inputString.Length; i++)
            {
                //
                if(numberString.Length > 0)
                {
                    double result;
                    if(double.TryParse(inputString[i].ToString(), out result))
                    {
                        numberString += result.ToString();
                        continue;
                    }
                    else
                    {
                        values.Push(double.Parse(numberString));
                        numberString = "";
                       
                    }
                }
                // Interprets which ever character is in the string at the given location i. Depending on the condition, 
                // Add a value to the stack or pop the stack.
                switch(inputString[i])
                {
                    // Pop if ) appears
                    case ')':
                        // read the last two integers on the values list.
                        // Apply the last operator on the two integers
                        // Remove the last two digits...
                        if (values.Count >= 2 && operators.Count >= 1)
                        {
                            double y = values.Pop();
                            double x = values.Pop();
                            char operand = operators.Pop();
                            switch(operand)
                            {
                                case '+':
                                    values.Push(x + y);
                                    break;
                                case '-':
                                    values.Push(x - y);
                                    break;
                                case '/':
                                    values.Push(x / y);
                                    break;
                                case '*':
                                    values.Push(x * y);
                                    break;
                                case '^':
                                    values.Push(Math.Pow(x, y));
                                    break;
                                default:
                                    throw new ArgumentException("Syntax error!");
                                    
                            }

                        }
                        else
                            throw new ArgumentException("Syntax error!");
                        break;
                        // Ignore left (
                    case '(':
                        break;
                    case '+':
                        operators.Push('+');
                        break;
                    case '-':
                        operators.Push('-');
                        break;
                    case '/':
                        operators.Push('/');
                        break;
                    case '*':
                        operators.Push('*');
                        break;
                        // Use the square root function.
                    case '^':
                        operators.Push('^');
                        break;
                    case ' ':
                        break;
                    default:
                        numberString += inputString[i];
                        break;
                
                }
            }

            return values.Pop();
        }
    }
}
