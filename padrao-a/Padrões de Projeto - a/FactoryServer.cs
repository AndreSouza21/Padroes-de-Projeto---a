using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrões_de_Projeto___a
{
    public interface Notificacao
    {
        void Enviar(string mensagem);   
    }

    public class Email : Notificacao 
    {
        public void Enviar(string mensagem) 
        {
            Console.WriteLine("[EMAIL]: " + mensagem);
        }
    }

    public class SMS : Notificacao
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine("[SMS]: " + mensagem);
        }
    }

    public class Push : Notificacao
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine("[PUSH]: " + mensagem);
        }
    }

    internal class FactoryServer
    {
        public static Notificacao create(string tipo) 
        {
            switch (tipo)
            {
                case "EMAIL":
                    return new Email();                    
                case "SMS":
                    return new SMS();
                case "Push":
                    return new Push();           
                default: return null;
            }                
        }
    }

    internal class ConfigGlobal
    {
        private ConfigGlobal() { }
        private static ConfigGlobal config;

        public string nomeAplicacao;
        public string servidorEnvio;
        public int qntdEnvio;


        public static ConfigGlobal GetConfig()
        {
            if (config == null) 
                config = new ConfigGlobal();
            return config;
        }

        public void SetConfig(string nomeAplicacao, string servidorEnvio, int qntdEnvio)
        {
            this.nomeAplicacao = nomeAplicacao;
            this.servidorEnvio = servidorEnvio;
            this.qntdEnvio = qntdEnvio;
        }
    }

}
