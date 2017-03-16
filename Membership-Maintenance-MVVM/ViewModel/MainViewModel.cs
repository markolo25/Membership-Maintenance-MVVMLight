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
            SelectMember = new RelayCommand(Update);
            members = new ObservableCollection<Member>();

        }

        public ObservableCollection<Member> MemberList
        {
            get
            {
                return members;
            }
        }

        public Member SelectedMember
        {
            get
            {
                return selectedMember;
            }
            set
            {
                selectedMember = value;
                this.RaisePropertyChanged(() => MemberList);
            }
        }

        private void Add_Employee()
        {
            add = new Add_Membership();
            add.Show();
            Messenger.Default.Register<Member>(this, OnReceiveMessageAction);
        }

        private bool isValid(Member obj)
        {
            return true;
        }
        private void OnReceiveMessageAction(Member obj)
        {
            add.Close();
            if (obj == null)
            {
                Messenger.Default.Unregister<Member>(this, OnReceiveMessageAction);
                return;
            }
            if (!members.Contains(obj) && isValid(obj))
            {
                members.Add(obj);
                this.RaisePropertyChanged(() => MemberList);
                Messenger.Default.Unregister<Member>(this, OnReceiveMessageAction);
                return;
                
            }
            else
            {
                MessageBox.Show("This Member is already in the list");
                Messenger.Default.Unregister<Member>(this, OnReceiveMessageAction);
                return;
            }
        }

        private void Remove_Employee()
        {
            if (MemberList.Count > 0)
            {
                MemberList.Remove(SelectedMember);
            }
        }

        private void Exit()
        {
            Application.Current.Shutdown();
        }

        public void Update()
        {

        }

  
    }
}