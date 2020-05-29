namespace SS_POO
{
    public class Celular
    {
        public string cor;

        public string modelo;

        public float tamanho;

        public bool ligado;

        
    /// <summary>
    /// Liga o celular
    /// </summary>
    /// <returns>texto de celular ligado</returns>

        public string Ligar (){
            ligado = true;

            return "O celular está ligado!"
           
        }

           
    /// <summary>
    /// Enviar Mensagem
    /// </summary>
    /// <returns>texto para enviar mensagem</returns>


        public string EnviarMensagem (){

            if (ligado){

                return "Enivar uma mensagem para x";
            }
            else{
                
                return "O celular esta desligado";
            }

        }

    /// <summary>
    /// Ligar para alguém
    /// </summary>
    /// <returns>texto ligando para</returns>


        public string FazerLigacao (){

            if (!ligado);
            {
                
                return "O celular está desligado!";
            }
            else{

                return "Ligando para x";
            }
        }


    /// <summary>
    /// Celular Desligado
    /// </summary>
    /// <returns>texto de celular desligado</returns>

           public string Desligar(){

           ligado = false;


            return "O celular está Desligado!";
       }

    }


    
}