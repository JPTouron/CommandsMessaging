using System.Collections;
using System.Collections.Generic;
using CommandExecutor.ClientCodeSample;
using CommandExecutor.Commands.BaseStructure;
using CommandExecutor.Commands.SampleImplementations;
using CommandExecutor.Functional;
using Ninject.Modules;

namespace CommandExecutorWithDI
{
    internal class MyModule : NinjectModule
    {
        /// <summary>
        /// register stuff to the ninject container
        /// </summary>
        public override void Load()
        {

            Bind<ICommandHandler<Result<User>, CreateUserCommand>>().To<CreateUserCommandHandler>();
            Bind<ICommandHandler<Result<User>, GetByCommand>>().To<GetByCommandHandler>();
            
            Bind<IUserCreator>().To<UserCreatorOk>();
            Bind<IUserRepo>().To<UserRepository>();
            
            Bind<ClientCode>().ToSelf();
        }
    }
}