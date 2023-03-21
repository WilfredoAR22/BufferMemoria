using System;
using System.Text;

class Compilador
{
    //se define el tamaño maximo del buffer de entrada y de salida
    const int MAX_INPUT_SIZE = 1000;
    const int MAX_OUTPUT_SIZE = 1000;

    static void Main()
    {
        //definición de variables para almacenar los buffers
        //y el indice para acceder a ellos por medio de un arreglo de bytes
        byte[] input_buffer = new byte[MAX_INPUT_SIZE];
        byte[] output_buffer = new byte[MAX_OUTPUT_SIZE];
        int input_buffer_index = 0;
        int output_buffer_index = 0;

        //le pedimos al usuario que ingrese el codigo fuente (en una sola linea)
        Console.WriteLine("Ingrese el código fuente:");
        
        //se lee el codigo en el buffer de entrada byte por byte
        //si en dado caso el programa fuente es menor al tamaño del buffer se da la instruccion
        //que el codigo termina con el simbolo Ç
        while (input_buffer_index < MAX_INPUT_SIZE)
        {
            byte b = (byte)Console.Read();
            if (b == 'Ç' )
            {
                break;
            }
            input_buffer[input_buffer_index++] = b;
        }

        //prueba del analisis sintatico
        Parse(input_buffer, output_buffer);

        //escritura del buffer de salida
        Console.WriteLine("\nCódigo compilado:");
        while (output_buffer_index < MAX_OUTPUT_SIZE)
        {
            byte b = output_buffer[output_buffer_index++];
            Console.Write((char)b);
        }
    }

    static void Parse(byte[] input_buffer, byte[] output_buffer)
    {
        //en este caso como no contamos con lexemas definidos solamente copiamos la entrada al buffer de salida
        //pero esta funcion me serviria como un analizador sintactico y asi avisar si hay un error
        Array.Copy(input_buffer, output_buffer, input_buffer.Length);
    }
}

