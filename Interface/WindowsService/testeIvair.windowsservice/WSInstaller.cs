using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;


namespace TesteIvair.windowsservice
{
    [RunInstaller(true)]
    public class WSInstaller : Installer
    {
        public static string ServiceName = "TesteIvair";
        public WSInstaller()
        {
            ServiceProcessInstaller process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.LocalSystem;
            ServiceInstaller serviceAdmin = new ServiceInstaller();
            serviceAdmin.StartType = ServiceStartMode.Manual;
            serviceAdmin.ServiceName = ServiceName;
            serviceAdmin.DisplayName = ServiceName;
            Installers.Add(process);
            Installers.Add(serviceAdmin);

        }



    }


}
