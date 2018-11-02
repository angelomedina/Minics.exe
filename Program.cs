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
         
        // TESTING PRELIMINARY DATA STRUCTURE:
            almacen.setValue("KEY 1", 1);
            almacen.setValue("KEY 2", 'a');
            almacen.setValue("KEY 3", 2);
            almacen.setValue("KEY 4", 'b');
            almacen.printContainer();
            almacen.searchValue("KEY 2");
            almacen.updateValue("KEY 2", 666);
            //almacen.getValue("KEY 2");

          


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
