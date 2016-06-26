using System;
using System.IO;

namespace MultiAplication{

class Multible{
    // member variable
    double len = 2;
    double width = 5;
    // dynamic e = 4;
    
    public void InputMul(){//(double len, double witdth){
        Console.WriteLine("Input {0}, {1}", len, width);
    }
    public void ResultMul(){
        Console.WriteLine("Result: {0}",len * width);
    }
}
class ExecuteMul{
    static void Main(string[] arg){
        Multible Mul = new Multible();
        Mul.InputMul();
        Mul.ResultMul();
        
        // Input from console
        int num;
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input value: {0}", num);
        Console.ReadLine();
    }
}
}
