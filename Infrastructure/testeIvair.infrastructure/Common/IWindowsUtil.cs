using System.IO;

namespace testeIvair.infrastructure.common
{
    public interface IWindowsUtil
    {
        
        string ObterChaveRegistro(string nomeChave, string valorChave);
    }
}