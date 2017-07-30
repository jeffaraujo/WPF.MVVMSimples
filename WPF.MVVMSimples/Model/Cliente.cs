using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVMSimples.Annotations;

namespace WPF.MVVMSimples.Model
{
    public class Cliente : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; OnPropertyChanged(nameof(Nome)); }
        }


        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }






        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
