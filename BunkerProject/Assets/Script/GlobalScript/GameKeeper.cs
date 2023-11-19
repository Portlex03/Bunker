using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BunkerProject;

internal static class GameKeeper
{
    public static string NickName;

    public static void RegisterUser(string nickName)
    {
        NickName = nickName;
    }
}
