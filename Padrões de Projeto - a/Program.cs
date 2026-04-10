using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrões_de_Projeto___a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigGlobal central = ConfigGlobal.GetConfig();
            central.SetConfig("Estelionato", "Correios", 10);

            Notificacao msg = FactoryServer.create("EMAIL");
            msg.Enviar("banana doce");

            msg = FactoryServer.create("SMS");
            msg.Enviar("melão pneu");

            //Console.WriteLine($"Nome da Aplicação: {central.nomeAplicacao}\n" + $"Servidor de Envio: {central.servidorEnvio}\n" + $"Quantidade Máxima de Envios: {central.qntdEnvio}");
        }
    }
}
