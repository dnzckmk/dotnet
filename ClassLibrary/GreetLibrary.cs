using System;

namespace ClassLibrary
{
    public class GreetLibrary
    {
        public static string GreetUser(string username)
        {
            return $"{DateTime.Now.ToString("hh:mm:ss tt")}: Hello, {username}!";
        }
    }
}
