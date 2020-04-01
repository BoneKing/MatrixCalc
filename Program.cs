using System;
using System.Collections; 
using System.Collections.Generic; 

namespace MatrixCalc //name of project
{
    class Program //class that contains everything, since this is a very basic program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome!");
           LinkedList<Matrix> Memory = new LinkedList<Matrix>();
           bool running = true;
           while(running){
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
                        Matrix matrix = new Matrix(rows, columns);
                        matrix.setName(newMatrixName);
                        Console.WriteLine("new matrix {0} created", matrix.getName());
                        Memory.AddFirst(matrix);
                        Console.WriteLine("Memory now contains {0} Matrices", Memory.Count);
                        matrix.PrintM();
                        break;
                    case "Sum Diagnals":
                        Console.WriteLine("What's the name of the matrix?");
                        string MatrixName = Console.ReadLine();
                        bool found = false;
                        foreach(Matrix m in Memory){
                            if(m.getName() == MatrixName){
                                int sum = m.SummingDiagnals();
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
                            m.Populate();
                            Console.WriteLine("Printing populated matrix");
                            m.PrintM();
                            }
                        }
                        break;
                    case "Quit":
                        running = false;
                        break;
               }
           }
        }
    }
}
