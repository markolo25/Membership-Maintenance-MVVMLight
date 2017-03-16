using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Membership_Maintenance_MVVM.Model;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace Membership_Maintenance_MVVM.ViewModel
{
    public class AddViewModel : ViewModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICommand saveButton { get; private set; }
        public ICommand cancelButton { get; private set; }

        public AddViewModel()
        {
            saveButton = new RelayCommand(save);
            cancelButton = new RelayCommand(cancel);
        }

        private void save()
        {
            Member message = new Member(this.FirstName, this.LastName, this.Email);
            nullval();
            Messenger.Default.Send(message);
        }

        private void cancel()
        {
            Member ret = null;
            Messenger.Default.Send(ret);
        }
        private void nullval()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
        }

        
    }
}