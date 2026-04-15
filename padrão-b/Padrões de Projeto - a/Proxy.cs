using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrões_de_Projeto___a
{
    internal class Proxy : Notificacao
    {
        private Notificacao nott;
        private int qntdTentativa = 0;

        public Proxy (Notificacao nott)
        {
            this.nott = nott;
        }

        public void Enviar(string mensagem)
        {
            ConfigGlobal config = ConfigGlobal.GetConfig();

            if (config.qntdEnvio == 0)
                config.qntdEnvio = 1;

            if (qntdTentativa >= config.qntdEnvio)
            {
                Console.WriteLine("[BLOQUEADO]: Limite de envios atingido");
                return;
            }

            Console.WriteLine($"[LOG]: Servidor de Envio {config.servidorEnvio}");
            nott.Enviar(mensagem);
        }
    }
}
