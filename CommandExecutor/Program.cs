﻿using CommandExecutor.ClientCodeSample;
using CommandExecutor.Commands.SampleImplementations;
using CommandExecutor.Functional;
using System;

namespace CommandExecutor
{
    internal class Program
    {
        private static Result CommandDemo()
        {
            var cmd = new CreateUserCommand { username = "JP", password = "secure!" };

            var handler = GetHandler();

            var user = handler.Handle(cmd);
            return user;
        }

        private static CreateUserCommandHandler GetHandler()
        {
            return new CreateUserCommandHandler(new UserCreatorOk());
        }

        private static void Main(string[] args)
        {
            Result user = CommandDemo();

            Console.WriteLine($"User Created {user} ");
        }
    }
}