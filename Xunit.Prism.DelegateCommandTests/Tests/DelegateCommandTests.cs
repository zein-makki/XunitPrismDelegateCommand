using System;

namespace Xunit.Prism.DelegateCommandTests
{
    public class DelegateCommandTests
    {
        ClassWithDelegateCommand sut;
        bool delegateCommand1CanExecuteChangedFired = false;

        public DelegateCommandTests()
        {
            sut = new ClassWithDelegateCommand();

            sut.delegateCommand1.CanExecuteChanged += DelegateCommand1_CanExecuteChanged;
        }

        [Fact]
        public void DelegateCommand1Test()
        {
            sut.RaiseCanExecuteChanged();

            Assert.True(delegateCommand1CanExecuteChangedFired);
        }

        private void DelegateCommand1_CanExecuteChanged(object sender, EventArgs e)
        {
            delegateCommand1CanExecuteChangedFired = true;
        }
    }
    // Generate more of the same test class to reproduce the issue by running 20 similar tests

    public class DelegateCommandTests02 : DelegateCommandTests { }
    public class DelegateCommandTests03 : DelegateCommandTests { }
    public class DelegateCommandTests04 : DelegateCommandTests { }
    public class DelegateCommandTests05 : DelegateCommandTests { }
    public class DelegateCommandTests06 : DelegateCommandTests { }
    public class DelegateCommandTests07 : DelegateCommandTests { }
    public class DelegateCommandTests08 : DelegateCommandTests { }
    public class DelegateCommandTests09 : DelegateCommandTests { }
    public class DelegateCommandTests10 : DelegateCommandTests { }
    public class DelegateCommandTests11 : DelegateCommandTests { }
    public class DelegateCommandTests12 : DelegateCommandTests { }
    public class DelegateCommandTests13 : DelegateCommandTests { }
    public class DelegateCommandTests14 : DelegateCommandTests { }
    public class DelegateCommandTests15 : DelegateCommandTests { }
    public class DelegateCommandTests16 : DelegateCommandTests { }
    public class DelegateCommandTests17 : DelegateCommandTests { }
    public class DelegateCommandTests18 : DelegateCommandTests { }
    public class DelegateCommandTests19 : DelegateCommandTests { }
    public class DelegateCommandTests20 : DelegateCommandTests { }
}
