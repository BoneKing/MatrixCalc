using System;

namespace MatrixCalc
{
    class Matrix
    {
        int[,]m; //creates empty matrix named m
        int r; //number of rows
        int c; //number of columns
        string name; 
        public Matrix(int newR, int newC){ //default constructor 
            r = newR; //sets r
            c = newC; //sets c 
            m = new int[r,c]; //creates an rxc matrix
            for(int i=0;i<r;i++){ //populates it with 0s
                for(int j=0;j<c;j++){
                    m[i,j]=0;
                }
            }
        }
        public void setName(string NewName){ //sets name of matrix
            name = NewName;
        }
        public string getName(){ //returns name of matrix
            return name;
        }
        public void PrintM(){ //prints matrix
            for(int i=0;i<r;i++){
                Console.Write("\n[");
                for(int j=0;j<c;j++){
                    Console.Write(" {0}",m[i,j]);
                }
                Console.Write("]");
            }
            Console.Write('\n');
        }
        public int SummingDiagnals() //sums numbers on the diagnal of an nxn matrix
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
        public void Populate(){ //allows user to fill in integer values for the matrix
            for(int i =0; i<r;i++){
                Console.WriteLine("enter the entries for row number {0} seperated by enter",i+1);
                for(int j=0;j<c;j++){
                    m[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}