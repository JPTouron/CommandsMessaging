using System;

namespace CommandClassicImplementation
{
    public sealed class ReceiverHandler : IDisposable
    {
        private Action<int> callBack;
        private bool isDisposed = false;
        private Receiver rcv;

        public void Dispose()
        {
            if (!isDisposed)
            {
                if (rcv != null)
                {
                    UnsubscribeReceiver();
                }
            }
        }

        public Receiver GetReceiver()
        {
            if (rcv == null)
            {
                var dependency = new IntegerSumDependency();
                rcv = new Receiver(dependency);
            }

            SubscribeReceiver();

            return rcv;
        }

        public void SubscribeClient(Action<int> callBack)
        {
            this.callBack = callBack;
        }

        public void UnsubscribeClient()
        {
            callBack = null;
        }

        private void Rcv_CalculatedResult(int result)
        {
            callBack(result);
        }

        private void SubscribeReceiver()
        {
            rcv.CalculatedResult += Rcv_CalculatedResult;
        }

        private void UnsubscribeReceiver()
        {
            rcv.CalculatedResult -= Rcv_CalculatedResult;
        }
    }
}