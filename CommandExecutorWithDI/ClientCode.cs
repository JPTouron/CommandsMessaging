using CommandExecutor.ClientCodeSample;
using CommandExecutor.Commands.SampleImplementations;
using CommandExecutor.Functional;

namespace CommandExecutorWithDI
{
    public class ClientCode
    {
        /// <summary>
        /// take a dependency on the command bus instead of all the possible handlers this client may depend upon
        /// </summary>
        private readonly ICommandBus bus;

        public ClientCode(ICommandBus bus)
        {
            this.bus = bus;
        }

        /// <summary>
        /// some sample action to perform by a client code of the command
        /// </summary>
        public Result<User> DoIt(CreateUserCommand cmd)
        {

            //send out the request for the CreateUserCommand fullfillment...(ie: execute the handler for this command)
            var result = bus.SendCommand<CreateUserCommand, Result<User>>(cmd);

            //this sample uses a synchronous communication style
            //for async stuff we would be better of with Events pub/sub architectural pattern
            return result;
        }


        public Result<User> FindBy(GetByCommand cmd) {

            var result = bus.SendCommand<GetByCommand, Result<User>>(cmd);

            return result;
        }
    }
}