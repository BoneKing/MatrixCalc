using System;

namespace MatrixCalc
{
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