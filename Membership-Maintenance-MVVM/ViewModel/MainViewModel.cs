using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Membership_Maintenance_MVVM.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using Membership_Maintenance_MVVM.View;
using Membership_Maintenance_MVVM.ViewModel;

namespace Membership_Maintenance_MVVM.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Member> members;
        private Member selectedMember;
        Add_Membership add;
        Update_Membership mod;
        public ICommand AddButton { get; private set; }
        public ICommand RemoveButton { get; private set; }
        public ICommand CloseButton { get; private set; }
        public ICommand SelectMember { get; private set; }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            AddButton = new RelayCommand(Add_Employee);
            RemoveButton = new RelayCommand(Remove_Employee);
            CloseButton = new RelayCommand(Exit);
            members = new ObservableCollection<Member>();

        }

        /// <summary>
        /// Properties for Memberlist used by the Binding on the xaml
        /// </summary>
        public ObservableCollection<Member> MemberList
        {
            get
            {
                return members;
            }
        }

        /// <summary>
        /// The Member Object currently selected
        /// </summary>
        public Member SelectedMember
        {
            get
            {
                return selectedMember;
            }
            set
            {
                selectedMember = value;
                Modify_Handler();
                this.RaisePropertyChanged(() => MemberList);
            }
        }

        /// <summary>
        /// Event handler/function for the Add Button
        /// </summary>
        private void Add_Employee()
        {
            add = new Add_Membership();
            add.Show();
            Messenger.Default.Register<Member>(this, finishAdd);
        }



        /// <summary>
        /// Was going to insert validator stuff in here but
        /// too lazy to modify it for this use case
        /// not required anyways
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>boolean stating if the member is valid or not</returns>
        private bool isValid(Member obj)
        {
            return true;
        }




        /// <summary>
        /// Handler for Messenger Recieved for the Add_Employee
        /// Function
        /// </summary>
        /// <param name="obj"></param>
        private void finishAdd(Member obj)
        {
            add.Close();
            if (obj == null)
            {
                Messenger.Default.Unregister<Member>(this, finishAdd);
                return;
            }
            if (!members.Contains(obj) && isValid(obj))
            {
                members.Add(obj);
                this.RaisePropertyChanged(() => MemberList);
                Messenger.Default.Unregister<Member>(this, finishAdd);
                return;
                
            }
            else
            {
                MessageBox.Show("This Member is already in the list");
                Messenger.Default.Unregister<Member>(this, finishAdd);
                return;
            }
        }

        /// <summary>
        /// Remove the currently selected employee.
        /// </summary>
        private void Remove_Employee()
        {
            if (MemberList.Count > 0)
            {
                MemberList.Remove(SelectedMember);
            }
        }

        /// <summary>
        /// Handler for the on click
        /// </summary>
        private void Modify_Handler()
        {
            mod = new Update_Membership();
            mod.Show();
            Messenger.Default.Send(selectedMember);
            Messenger.Default.Register<Member>(this, finishMod);
        }

        /// <summary>
        /// Handler for Message Recieved from the 
        /// UpdateViewModel
        /// </summary>
        /// <param name="obj"></param>
        private void finishMod(Member obj)
        {
            mod.Close();
            if (obj == null)
            {
                this.RaisePropertyChanged(() => MemberList);
                Messenger.Default.Unregister(this);

            }
            else if (obj.FirstName == null && obj.LastName == null && obj.Email == null)
            {
                Remove_Employee();
                Messenger.Default.Unregister(this);

            }

            else if (isValid(obj))
            {
                if (MemberList.Count > 0)
                {
                    members[members.IndexOf(selectedMember)] = obj;
                }
                Messenger.Default.Unregister(this);

            }
            else
            {
                MessageBox.Show("Invalid Member not doing anything");
                Messenger.Default.Unregister(this);

            }
            selectedMember = null;
            this.RaisePropertyChanged(() => MemberList);
            this.RaisePropertyChanged(() => SelectedMember);
        }


        /// <summary>
        /// Exits the Program
        /// </summary>
        private void Exit()
        {
            Application.Current.Shutdown();
        }







    }
}