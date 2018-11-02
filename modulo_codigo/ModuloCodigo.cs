using System;
using System.Linq;
using InstructionsNameSpace;

namespace ModuloCodigoNamespace
{
    class ModuloCodigo
    {   
        public InstructionSet setInstrucciones;
        public ModuloCodigo(ref InstructionSet setInstrucciones){
            this.setInstrucciones = setInstrucciones;
        }

        public void obtenerInstrucciones(string origen){
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(origen);  
            while((line = file.ReadLine()) != null)  
            {  
                string[] palabras = line.Split(' ');
                if(palabras.Length == 3){
                    try
                    {
                        int param = System.Convert.ToInt32(palabras[2]);
                        setInstrucciones.addInst(palabras[1], param);//El parámetro ingresa como integer
                    }
                    catch (FormatException)
                    {
                        
                        if(palabras[2].Length == 1) 
                            setInstrucciones.addInst(palabras[1], System.Convert.ToChar(palabras[2]));//El parámetro ingresa como char
                        else
                            setInstrucciones.addInst(palabras[1], palabras[2]);//El parámetro ingresa como string
                    }
                }
                else{
                    setInstrucciones.addInst(palabras[1], null);//La instrucción no contiene parámetro.
                }

            }  
            file.Close();
        }
        
    }
}
