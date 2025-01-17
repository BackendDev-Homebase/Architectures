﻿using Layered2.BusinesLogic;

namespace Layered2.Presentation
{
    internal class PresentationLayer
    {
        private readonly IBusinessLogicLayer _bll;

        internal PresentationLayer(IBusinessLogicLayer bll)
        {
            _bll = bll;
        }

        internal async Task Greet()
        {
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine() ?? string.Empty;
            var greetingMessage = await _bll.GetGreetingMessage(name);
            Console.WriteLine(greetingMessage);
        }
    }
}
