using System;
using System.Collections; 
using System.Collections.Generic; 

namespace MatrixCalc //name of project
{
    class Program //class that holds main
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome!");
           Console.WriteLine("Please type help to get a list of commands if you get confused!");
           LinkedList<Matrix> Memory = new LinkedList<Matrix>(); //a linked list of matrices in memory
           bool running = true;
           while(running){ //loop that runs program
               int rows, columns;
               Console.WriteLine("What would you like to do");
               string option = Console.ReadLine();
               switch(option){
                   case "Create Matrix":
                        Console.WriteLine("what is the matrix called?");
                        string newMatrixName = Console.ReadLine();
                        Console.WriteLine("what is the dimensions row x columns");
                        rows = Convert.ToInt32(Console.ReadLine());
                        columns = Convert.ToInt32(Console.ReadLine());
                        Matrix matrix = new Matrix(rows, columns); //makes new instance of matrix with dimenstions r x c
                        matrix.setName(newMatrixName); //gives it a name to find in memory
                        Console.WriteLine("new matrix {0} created", matrix.getName());
                        Memory.AddLast(matrix); //adds new matrix to front of Memory
                        Console.WriteLine("Memory now contains {0} Matrices", Memory.Count);
                        matrix.PrintM();
                        Console.WriteLine("Would you like to populate this Matrix now? [y/n]");
                        string popu = Console.ReadLine();
                        if(popu == "y" || popu == "Y"){
                            matrix.Populate();
                        }
                        break;
                    case "Sum Diagnals":
                        Console.WriteLine("What's the name of the matrix?");
                        string MatrixName = Console.ReadLine();
                        bool found = false;
                        foreach(Matrix m in Memory){
                            if(m.getName() == MatrixName){ //searches memory for a matrix with a matching name
                                int sum = m.SummingDiagnals(); //calls Summing Diagnals from MatrixClass.cs
                                Console.WriteLine("Sum of diagonals = {0}", sum);
                                found = true;
                            }
                        }
                        if(found == false){
                            Console.WriteLine("No matrix found with name: {0}", MatrixName);
                        }
                        break;
                    case "Populate":
                        Console.WriteLine("What is the name of the matrix you wish to populate?");
                        string MatrixToPopulate = Console.ReadLine();
                        foreach(Matrix m in Memory){
                        if(m.getName() == MatrixToPopulate){
                            m.Populate(); //in MatrixClass.cs
                            Console.WriteLine("Printing populated matrix");
                            m.PrintM(); //prints matrix found in Matrix.cs
                            }
                        }
                        break;
                    case "Display Matrix":
                        Console.WriteLine("What is the name of the matrix you wish to display?");
                        string MatrixToDisplay = Console.ReadLine();
                        foreach(Matrix m in Memory){
                        if(m.getName() == MatrixToDisplay){
                            Console.WriteLine("*Printing Matrix {0}*", MatrixToDisplay);
                            m.PrintM();
                            }
                        }
                        break;
                    case "List Matrices":
                        foreach(Matrix m in Memory){
                            Console.WriteLine("{0}:", m.getName());
                            m.PrintM();
                            Console.WriteLine('\n');
                        }
                        break;
                    case "help":
                        Console.WriteLine("The options you can do are:");
                        Console.WriteLine("Create Matrix - Allows you to make a new matrix");
                        Console.WriteLine("Populate - allows user to fill in integer values for a given matrix");
                        Console.WriteLine("Sum Diagnals - sums the diagnal of a nxn matrix");
                        Console.WriteLine("Display Matrix - prints a given matrix to the screen");
                        Console.WriteLine("List Matrices - Prints all of the Matrices in Memory");
                        Console.WriteLine("Quit - Exits the program");
                        break;
                    case "Quit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("INVALID COMMAND");
                        break;
               }
           }
        }
    }
}
