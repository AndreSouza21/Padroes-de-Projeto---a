using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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


    public class SMSAdapter : Notificacao 
    {
        private SMSExterno sms = new SMSExterno();

        public void Enviar(string mensagem)
        {
            sms.SendMessage(mensagem);
        }
    }

    public class SMSExterno
    {
        public SMSExterno() { }

        public void SendMessage(string mensagem)
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
            Notificacao nott;

            switch (tipo)
            {
                case "EMAIL":
                    nott =  new Email();
                    break;
                case "SMS":
                    nott = new SMSAdapter();
                    break;
                case "Push":
                    nott = new Push();
                    break;
                default: return null;
            }                
            
            return new Proxy(nott);
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
