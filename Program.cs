using System;
using InstructionsNameSpace;
using AlmacenNameSpace;
using ModuloCodigoNamespace;
using moduloPila;
using System.Collections;

namespace Minics.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            // dotnet run: correr c#
            Almacen almacen = new Almacen("almacen");
        
        // ------------------------------------

            

        //------------------------------------   

            InstructionSet instructionSet = new InstructionSet();
            instructionSet.run(); 

            ModuloCodigo moduloCodigo = new ModuloCodigo(ref instructionSet);
            moduloCodigo.obtenerInstrucciones("modulo_codigo/text.txt");

            instructionSet.printInstructionSet();
        }
    }
}
