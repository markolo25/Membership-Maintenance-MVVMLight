using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Membership_Maintenance_MVVM.Model;
using GalaSoft.MvvmLight.Messaging;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using System.Windows;
using GalaSoft.MvvmLight.Command;

namespace Membership_Maintenance_MVVM.ViewModel
{
    public class UpdateViewModel : ViewModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICommand saveButton { get; private set; }
        public ICommand cancelButton { get; private set; }
        public ICommand deleteButton { get; private set; }

        public UpdateViewModel()
        {
            Messenger.Default.Register<Member>(this, recieve);
            saveButton = new RelayCommand(save);
            deleteButton = new RelayCommand(delete);
            cancelButton = new RelayCommand(cancel);

        }

        private void recieve(Member m)
        {
            this.FirstName = m.FirstName;
            this.LastName = m.LastName;
            this.Email = m.Email;
            this.RaisePropertyChanged(() => FirstName);
            this.RaisePropertyChanged(() => LastName);
            this.RaisePropertyChanged(() => Email);
        }

        private void save()
        {
            Member message = new Member(this.FirstName, this.LastName, this.Email);
            Messenger.Default.Unregister<Member>(this,recieve);
            Messenger.Default.Send(message);
        }

        private void cancel()
        {
            Member ret = null;
            Messenger.Default.Unregister<Member>(this, recieve);
            Messenger.Default.Send(ret);
        }

        private void delete()
        {
            Messenger.Default.Unregister<Member>(this, recieve);
            Messenger.Default.Send(new Member(null, null, null));
        }

    }
}
