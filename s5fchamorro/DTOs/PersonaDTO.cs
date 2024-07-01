using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s5fchamorro.DTOs
{
    public partial class PersonaDTO : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public string nombre;

    }
}
