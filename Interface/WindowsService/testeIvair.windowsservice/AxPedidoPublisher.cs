using TesteIvair.application;
using TesteIvair.infrastructure.log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace TesteIvair.windowsservice
{
    partial class AxPedidoPublisher : ServiceBase
    {
        private static readonly string hostName = ConfigurationManager.AppSettings["HostName"];
        private static readonly string virtualHost = ConfigurationManager.AppSettings["VirtualHost"];
        private static readonly string userName = ConfigurationManager.AppSettings["UserName"];
        private static readonly string password = ConfigurationManager.AppSettings["Password"];
        private static readonly string exchange = ConfigurationManager.AppSettings["Exchange"];
        private static readonly string queuePedido = ConfigurationManager.AppSettings["QueuePedido"];
        private static readonly string routingKeyPedido = ConfigurationManager.AppSettings["RoutingKeyPedido"];
        private static readonly string queueConfirmacaoPedido01 = ConfigurationManager.AppSettings["QueueConfirmacaoPedido01"];
        private static readonly string routingKeyConfirmacaoPedido01 = ConfigurationManager.AppSettings["RoutingKeyConfirmacaoPedido01"];
        private static readonly string queueConfirmacaoPedido03 = ConfigurationManager.AppSettings["QueueConfirmacaoPedido03"];
        private static readonly string routingKeyConfirmacaoPedido03 = ConfigurationManager.AppSettings["RoutingKeyConfirmacaoPedido03"];

        private Dictionary<string, string> _rabbitMQConn;
        private static System.Timers.Timer _aTimer;

        public AxPedidoPublisher()
        {
            Log.RecordInfo("===============================================================");
            Log.RecordInfo("# INÍCIO - RECUPERANDO CONFIGURAÇÕES DE FILA");
            _rabbitMQConn = new Dictionary<string, string>();
            _rabbitMQConn.Add("HostName", hostName);
            _rabbitMQConn.Add("UserName", userName);
            _rabbitMQConn.Add("Password", password);
            _rabbitMQConn.Add("VirtualHost", virtualHost);
            Log.RecordInfo("# FIM - RECUPERANDO CONFIGURAÇÕES DE FILA");

            _aTimer = new System.Timers.Timer(Convert.ToInt32(ConfigurationManager.AppSettings["Intervalo"]));
            _aTimer.Enabled = true;
            _aTimer.Elapsed += new System.Timers.ElapsedEventHandler(EnvioPedido);

           // EnvioPedido(null, null);

            InitializeComponent();
        }
        public void Start()
        {
            _aTimer.Start();
        }
        //Custom method to Stop the timer
        public new void Stop()
        {
            _aTimer.Stop();
        }
        protected override void OnStart(string[] args)
        {
            Log.RecordInfo("# INICIO DO PROCESSAMENTO");
            Log.RecordInfo("****************************************");
            Log.RecordInfo("****************************************");
            Log.RecordInfo(string.Empty);

            this.Start();
        }
        protected override void OnStop()
        {
            Log.RecordInfo(string.Empty);
            Log.RecordInfo("****************************************");
            Log.RecordInfo("****************************************");
            Log.RecordInfo("# Fim DO PROCESSAMENTO");

            this.Stop();
        }
        void EnvioPedido(object sender, System.Timers.ElapsedEventArgs e)
        {

            PedidoFacade pedidoFacade = new PedidoFacade(_rabbitMQConn);

            Log.RecordInfo(string.Empty);

            Log.RecordInfo("# INÍCIO -  ENVIANDO PEDIDO - PECENVIADO01");
            pedidoFacade.Enviar_PecEnviado01(exchange, queuePedido, routingKeyPedido);
            Log.RecordInfo("# FIM - ENVIANDO PEDIDO - PECENVIADO01");

            ConfirmacaoFacade confirmacaoFacade = new ConfirmacaoFacade(_rabbitMQConn);

            Log.RecordInfo(string.Empty);

            Log.RecordInfo("# INÍCIO - ENVIANDO CONFIRMAÇÃO - CONFPEDIDOS01");
            confirmacaoFacade.Enviar_ConfPedidos01(exchange, queueConfirmacaoPedido01, routingKeyConfirmacaoPedido01);
            Log.RecordInfo("# FIM - ENVIANDO CONFIRMAÇÃO - CONFPEDIDOS01");

            Log.RecordInfo(string.Empty);

            Log.RecordInfo("# INÍCIO - ENVIANDO CONFIRMAÇÃO - CONFPEDIDOS03");
            confirmacaoFacade.Enviar_ConfPedidos03(exchange, queueConfirmacaoPedido03, routingKeyConfirmacaoPedido03);
            Log.RecordInfo("# FIM - ENVIANDO CONFIRMAÇÃO - CONFPEDIDOS03");

            Log.RecordInfo(string.Empty);

        }
    }
}
