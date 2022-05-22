using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal abstract class AccountsHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }

        public virtual object Handle(object request)
        {
            if(this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }

    internal class FirstBankAccountHandler : AccountsHandler
    {
        private readonly int moneyInWallet = 10;

        public override object Handle(object request)
        {
            if(request as int? <= moneyInWallet)
            {
                return $"FIRST";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    internal class SecondBankAccountHandler : AccountsHandler
    {
        private readonly int moneyInWallet = 20;

        public override object Handle(object request)
        {
            if(request as int? <= moneyInWallet)
            {
                return $"SECOND";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    internal class ThirdBankAccountHandler : AccountsHandler
    {
        private readonly int moneyInWallet = 999;

        public override object Handle(object request)
        {
            if(request as int? <= moneyInWallet)
            {
                return $"THIRD";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}