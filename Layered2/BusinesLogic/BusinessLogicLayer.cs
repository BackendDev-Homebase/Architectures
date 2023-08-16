﻿using Layered.DataAcess;
using Layered2.BusinesLogic;
using Layered2.DataAcess;

namespace Layered.BusinesLogic
{
    internal class BusinessLogicLayer : IBusinessLogicLayer
    {
        private readonly IDataAcessLayer _dal;

        public BusinessLogicLayer(IDataAcessLayer dal)
        {
            _dal = dal;
        }

        public async Task<string> Greet(string name)
        {
            var userCounts = await _dal.LoadUserCounts();
            string greetingMessage;
            if (!userCounts.ContainsKey(name))
            {
                userCounts[name] = 1;
                greetingMessage = "Hello, {name}!";
            }
            else
            {
                userCounts[name]++;
                int count = userCounts[name];
                if (count <= 3)
                {
                    greetingMessage = $"Welcome back, {name}!";
                }
                else
                {
                    greetingMessage = $"Hello, my good friend {name}!";
                }
            }
            await _dal.StoreUserCounts(userCounts);
            return greetingMessage;
        }
    }
}