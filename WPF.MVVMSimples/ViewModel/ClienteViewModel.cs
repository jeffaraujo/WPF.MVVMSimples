using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.MVVMSimples.Model;

namespace WPF.MVVMSimples.ViewModel
{
    public class ClienteViewModel
    {
        public ObservableCollection<Cliente> Clientes { get; set; }

        public void LoadClientes()
        {
            var clientes = new ObservableCollection<Cliente>
            {
                new Cliente() {Nome = "Jeferson", Email = "email@server1.com", ID = 1},
                new Cliente() {Nome = "Jefão", Email = "email@server2.com", ID = 1},
                new Cliente() {Nome = "Mario", Email = "email@server3.com", ID = 1},
                new Cliente() {Nome = "Pedro", Email = "email@server4.com", ID = 1},
                new Cliente() {Nome = "Henrique", Email = "email@server5.com", ID = 1},
                new Cliente() {Nome = "Marina", Email = "email@server6.com", ID = 1}
            };

            this.Clientes = clientes;
        }
    }
}
