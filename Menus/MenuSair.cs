﻿using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.WriteLine("Encerrando...");
        }
    }
}
