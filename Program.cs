using System;

namespace C_sharp_learning //name of project
{
    class Program //class that contains everything, since this is a very basic program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome! Please input the dimensions for your matrix first the number of rows, then the number of columns: \n");
           int rows = Convert.ToInt32(Console.ReadLine());
           int columns = Convert.ToInt32(Console.ReadLine());
           Matrix M = new Matrix(rows, columns);

           Console.WriteLine("printing Matrix\n");
           M.PrintM();
           Console.WriteLine("Matrix Printed");
           Console.ReadLine();
           bool running = true;
           while(running){
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
                        matrix.PrintM();
                        break;
                    case "Sum Diagnals":
                        Console.WriteLine("What's the name of the matrix?");
                        string MatrixName = Console.ReadLine();
                        //Console.WriteLine(Convert.ToString(MatrixName.SummingDiagnals()));
                        break;
                    case "Quit":
                        running = false;
                        break;
               }
           }
        }
    }

    class Matrix
    {
        int[,]m;
        int r;
        int c;
        string name;
        public Matrix(int newR, int newC){
            r = newR;
            c = newC;
            m = new int[r,c];
            for(int i=0;i<r;i++){
                for(int j=0;j<c;j++){
                    m[i,j]=0;
                }
            }
        }
        public void setName(string NewName){
            name = NewName;
        }
        public string getName(){
            return name;
        }
        public void PrintM(){
            for(int i=0;i<r;i++){
                Console.Write("\n[");
                for(int j=0;j<c;j++){
                    Console.Write(" {0}",m[i,j]);
                }
                Console.Write("]");
            }
            Console.Write('\n');
        }
        public int SummingDiagnals()
        {
            int sum=0;
            if(r != c){
                Console.WriteLine("error, matrix is not a nxn matrix");
                return -1;
            }
            else if(r == c){
                for(int i = 0; i<r;i++)
                {
                    sum = sum + m[i,i];
                }
                return sum;
            }
            else{
                Console.WriteLine("unknown error summing diagnals");
                return -2;
            }
        }
    }
}
