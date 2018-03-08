using System.Text;

namespace VigenereWeb.Services
{

    public class VigenereSeguridadService : ISeguridadService<string>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");

        ///  Aquí deben hacer la parte del código necesario para Desencriptar el mensaje

        public string DesEncriptar(string Mensaje, string clave)
        {
            /// sirve para construir una cadena de manera dinamica
             StringBuilder msjEncriptado = new StringBuilder();
           int qpex=0;
                int a=0;
                  clave=clave.ToUpper();
            foreach (var letra in Mensaje)
            {
                
              
                if (char.IsLetter(letra))
                {
                   if(a>=clave.Length){
                       a=0;
                   }
                   for(int i=0;i<ABECEDARIO.Length;i++){
                       if(clave[a]==ABECEDARIO[i]){
                           qpex=i;
                       }
                   }
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraEnc = (posLetra - qpex) % ABECEDARIO.Length;
                    var letrEnc = ABECEDARIO[posLetraEnc];
                    if (char.IsUpper(letra))
                    {
                        msjEncriptado.Append(letrEnc);
                    }
                    else
                    {
                        msjEncriptado.Append(char.ToLower(letrEnc));
                    }
                    a++;
                    }


                
                else
                {
                    msjEncriptado.Append(letra);
                }}
            
            return msjEncriptado.ToString();
             


        }



        //  Aquí deben hacer la parte del código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, string clave)
        {
            /// sirve para construir una cadena de manera dinamica
           StringBuilder msjEncriptado = new StringBuilder();
           int qpex=0;
                int a=0;
                  clave=clave.ToUpper();
            foreach (var letra in Mensaje)
            {
                
              
                if (char.IsLetter(letra))
                {
                   if(a>=clave.Length){
                       a=0;
                   }
                   for(int i=0;i<ABECEDARIO.Length;i++){
                       if(clave[a]==ABECEDARIO[i]){
                           qpex=i;
                       }
                   }
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraEnc = (posLetra + qpex) % ABECEDARIO.Length;
                    var letrEnc = ABECEDARIO[posLetraEnc];
                    if (char.IsUpper(letra))
                    {
                        msjEncriptado.Append(letrEnc);
                    }
                    else
                    {
                        msjEncriptado.Append(char.ToLower(letrEnc));
                    }
                    a++;
                    }


                
                else
                {
                    msjEncriptado.Append(letra);
                }}
            
            return msjEncriptado.ToString();
        }
    }


}