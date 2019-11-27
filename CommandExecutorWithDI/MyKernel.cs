using CommandExecutor.Commands.BaseStructure;
using CommandExecutor.Functional;
using Ninject;
using System;

namespace CommandExecutorWithDI
{
    /// <summary>
    /// we use ninject as the DI injector, we could change this to whatever (autofac,unity, etc)
    /// </summary>
    public static class MyKernel
    {
        private static IKernel kernel;

        public static void Destroy()
        {
            if (kernel != null)
            {
                kernel.Dispose();
                kernel = null;
            }
        }

        public static IKernel GetKernel()
        {
            if (kernel == null)
            {
                kernel = new StandardKernel();
                try
                {
                    LoadModules();

                    return kernel;
                }
                catch
                {
                    kernel.Dispose();
                    throw;
                }
            }
            else
            {
                return kernel;
            }
        }

        private static void LoadModules()
        {
            //Special case, we need to bind the commandbus to some interface, nice thing here is:
            //interface is public, implementation is quite private (see below ;-) )
            kernel.Bind<ICommandBus>().To(typeof(CommandBus));

            kernel.Load(new MyModule());
        }

        /// <summary>
        /// this is the command bus implementation, it is a private class within a class... doesnt get much private than this...
        /// 
        /// Service locator "pattern", this is considered ok as it is encapsulated WITHIN the DI composition root
        /// info command bus: 
        ///     https://culttt.com/2014/11/10/creating-using-command-bus/
        ///     ESB (same principle applied to commands here): https://en.wikipedia.org/wiki/Enterprise_service_bus
        ///     https://www.sitepoint.com/command-buses-demystified-a-look-at-the-tactician-package/
        ///     
        /// info service locator: 
        ///     https://blog.ploeh.dk/2011/08/25/ServiceLocatorrolesvs.mechanics/
        /// </summary>
        private class CommandBus : ICommandBus
        {
            /// <summary>
            /// we get a hold of the kernel to implement the service locator "pattern"
            /// </summary>
            private readonly IKernel container;

            public CommandBus(IKernel container)
            {
                if (container == null)
                    throw new ArgumentNullException("container");

                this.container = container;
            }

            public TResult SendCommand<T, TResult>(T command) where TResult : Result where T : ICommand
            {
                //try and find the handler for a given command...
                //keep in mind that the client code should provide the return and input types, this identifies the handler uniquely
                //this is troublesome of course, as what happens when we have 2 diff handlers with same input output?
                //thus a better approach is required here
                var commandHandler = this.container.Get<ICommandHandler<TResult, T>>();
                return commandHandler.Handle(command);
            }
        }
    }
}