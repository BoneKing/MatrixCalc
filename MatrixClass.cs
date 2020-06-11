using System;
using System.Collections;
using System.Collections.Generic;

namespace MatrixCalc
{
    class Matrix
    {
        object[,]m; //creates empty matrix named m
        int r; //number of rows
        int c; //number of columns
        string name; 
        public Matrix(int newR, int newC){ //default constructor 
            r = newR; //sets r
            c = newC; //sets c 
            m = new object[r,c]; //creates an rxc matrix
            for(int i=0;i<r;i++){ //populates it with 0s
                for(int j=0;j<c;j++){
                    m[i,j]="0";
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
        public string SummingDiagnals() //sums numbers on the diagnal of an nxn matrix
        {
            int sum=0;
            if(r != c){
                Console.WriteLine("error, matrix is not a nxn matrix");
                return "Failed";
            }
            else if(r == c){
                LinkedList<string> variables = new LinkedList<string>();
                string totalSum;
                for(int i = 0; i<r;i++)
                {
                    try{
                        sum += Convert.ToInt32(m[i,i]);
                    }
                    catch{
                        variables.AddLast(Convert.ToString(m[i,i]));
                    }
                }
                totalSum = Convert.ToString(sum);
                foreach(string v in variables){
                    totalSum += (" + "+v);
                }
                return totalSum;
            }
            else{
                Console.WriteLine("unknown error summing diagnals");
                //if you hit here I don't know what happened or what you did
                return "Failed";
            }
        } 
        public void Populate(){ //allows user to fill in integer values for the matrix
            for(int i =0; i<r;i++){
                Console.WriteLine("enter the entries for row number {0} seperated by enter",i+1);
                for(int j=0;j<c;j++){
                    string entry = Console.ReadLine();
                    try{
                        m[i,j] = Convert.ToInt32(entry);
                    }
                    catch{
                        m[i,j] = entry;
                    }
                }
            }
        }
    }
}