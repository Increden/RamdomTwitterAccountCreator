using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RamdomTwitterAccountCreator.ViewModel.Collection;
using RamdomTwitterAccountCreator.ViewModel.Command;
using RamdomTwitterAccountCreator.Model;

namespace RamdomTwitterAccountCreator.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        ObservableCollectionEx<CreatedAccount> _CreatedAccounts { get; set; }
        public ObservableCollectionEx<CreatedAccount> CreatedAccounts { get { return _CreatedAccounts; } }
    }
}
