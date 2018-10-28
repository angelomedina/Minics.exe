using System;
using System.Collections.Generic;
namespace AlmacenNameSpace
{
    public class Almacen{


        // PRELIMINARY DATA STRUCTURE:
        Dictionary<string, dynamic> test;

        // -----------------------------
        public String nombre;

        // constructor
        public Almacen(String nombre){
            this.test = new Dictionary<string, dynamic>();
            this.nombre = nombre;
        }

        // ADD VALUE TO THE DICTIONARY
        public void setValue(string key, dynamic value){
            this.test.Add(key, value);
        }

        // RETURN VALUE
        public dynamic getValue(string key){
            
            dynamic result = null;

            foreach (dynamic item in this.test)
            {
                    if (item.Key == key ){
                        Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
                        result = item.Value;
                    }
                    
            }
            return result;

        }

        // GET VALUE IF FOUND
        public bool searchValue(string key){

            if(this.test.ContainsKey(key)){
                Console.WriteLine(key + " ITEM FOUND");
                return true;
            }
            return false;
            
        }

        // UPDATE VALUE IF FOUND
        public void updateValue(string key, dynamic newValue){
            bool found = searchValue(key);
            if(!found){
                Console.WriteLine("404 Item not found!");
            }
            else{
                this.test[key] = newValue;
                Console.WriteLine(key + " ITEM UPDATED!");
            
            }
        }

        // PRINT DICTIONARY
        public void printContainer(){
            foreach (dynamic item in this.test)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
                }
        }
        
    }
}