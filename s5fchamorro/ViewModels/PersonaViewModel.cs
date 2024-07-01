using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Input;

using Microsoft.EntityFrameworkCore;
using s5fchamorro.DTOs;
using s5fchamorro.Utils;
using s5fchamorro.Models;

namespace s5fchamorro.ViewModels
{
    public partial  class PersonaViewModel:ObservableObject, IQueryAttributable
    {
        //private readonnly Em
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            throw new NotImplementedException();

        }
    }
}
