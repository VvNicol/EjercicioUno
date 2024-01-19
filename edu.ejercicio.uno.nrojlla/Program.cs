namespace edu.ejercicio.uno.nrojlla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el primer apellido:");
            string apellido1 = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo apellido:");
            string apellido2 = Console.ReadLine();

            if(nombre.Equals(apellido1)  || nombre.Equals(apellido2))
            {
                Console.WriteLine("Su apellido es igual a su nombre.");
                Console.WriteLine("* Intentelo denuevo");               
            }
            
           Console.WriteLine("Ingrese los numeros de su DNI 8 digitos: ");
           int dni = Convert.ToInt32(Console.ReadLine());

           int[] resto = { 0, 1, 2, 3, 4, 5 , 6  ,  7 ,  8 ,  9,   10,  11, 12 , 13 , 14 , 15 , 16 , 17 , 18 , 19 , 20 , 21,  22};
           string[] letra = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };

           int divisor = 23;           
           int operacion = dni % divisor;

           int posicionResto = resto[operacion];

           Console.WriteLine("Ingrese la letra de su DNI en Mayus: ");
           string letraDni = Console.ReadLine();

           if (letraDni == letra[posicionResto])
           {
               Console.WriteLine("DNI valido");
           }  else
           {
               Console.WriteLine("La letra ingresada no coincide con la letra calculada.");
           }


           Console.WriteLine("Ingrese el codigo postal de Sevilla: ");
           int cp = Convert.ToInt32(Console.ReadLine());

           int[] cpSevilla = { 41001, 41002, 41003, 41004, 41005, 41006, 41007, 41008, 41009, 41010, 41011, 41012, 41013, 41014, 41015, 41016, 41017, 41018, 41019, 41020, 41092, 41500, 41520 ,
           41900, 41910, 41073, 41080, 41086, 41089, 41700, 41701, 41702, 41703, 41704, 41728, 41927, 41720, 41727, 41728, 41600, 41339,41410, 41740, 41620, 41300,41309,41471, 41710, 41719 ,41720 ,41727, 41728 ,
           41930,41100,41510,41530,41920, 41400, 41409, 41563, 41567 };

           if (cpSevilla.Contains(cp))
           {
               Console.WriteLine("CP correcto");
           } else
           {
               Console.WriteLine("su CP no es de Sevilla, intentelo de nuevo");
           }  
           
            string nombreCompleto = apellido1 + apellido2 + nombre + ".";
            string apellidosCompleto = apellido1 + apellido2;

            string nombreCompletoConcatenado = String.Concat(apellido1, " ", apellido2, ", ", nombre, ".");
            Console.WriteLine(nombreCompletoConcatenado);

            char decimaLetraApellido = apellidosCompleto[9];

            int buscarLetraA = nombreCompleto.IndexOf("a");
            if (buscarLetraA== -1)
            {
                Console.WriteLine("No se encuentra");

            }
            else
            {
                Console.WriteLine("Primera vez que aparece la letra 'a' en el nombre completo: " + buscarLetraA);
            }

            int buscarR = nombreCompleto.IndexOf("r", 3, 8);
            Console.WriteLine("La letra 'r' aparece por primera vez en la posición: " + buscarR );

            char[] caracteres = nombreCompleto.ToCharArray();

            foreach (char letraSeparado in caracteres)
            {
                Console.Write(letraSeparado+ " ");
            }

            int posicionARC = nombre.IndexOf("arc");
            if (posicionARC == -1)
            {
                Console.WriteLine("la posicion de arc es: " + posicionARC);

            }
            else
            {
                Console.WriteLine("No se encontro arc");
            }



        }
    }
}
