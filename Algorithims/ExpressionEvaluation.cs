﻿using System;
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
            List<char> charToNumberList = new List<char>();

            for(int i = 0; i < inputString.Length; i++)
            {
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
                                    break;
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
                        double outResult;
                      
                        values.Push(double.Parse(inputString[i].ToString()));
                        break;
                
                }
            }

            return values.Pop();
        }
    }
}