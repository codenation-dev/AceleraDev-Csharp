using System;

namespace Generics
{
    public static class MeuExtensionMethod
    {
        public static int ContadorDePalavras(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                              StringSplitOptions.RemoveEmptyEntries).Length;

        }
    }
}
