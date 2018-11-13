using Microsoft.Practices.Prism.Commands;
using System;
using System.Threading;

namespace Xunit.Prism.DelegateCommandTests
{
    public class ClassWithDelegateCommand
    {
        public DelegateCommand delegateCommand1;

        public ClassWithDelegateCommand()
        {
            delegateCommand1 = new DelegateCommand(() => { }, () => true);
        }

        public void RaiseCanExecuteChanged(int commandNumber)
        {
            SomeLongRunningCode();

            delegateCommand1.RaiseCanExecuteChanged();
        }

        private void SomeLongRunningCode()
        {
            //Thread.Sleep(TimeSpan.FromSeconds(new Random().Next(4, 6)));
            for (int i = 0, j = 0; i < int.MaxValue; i++)
                j++;
        }
    }
}
