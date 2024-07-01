using CommunityToolkit.Mvvm.Messaging.Messages;
using s5fchamorro.Models;

namespace s5fchamorro.Utils
{
    public class PersonaMensajeria : ValueChangedMessage<PersonaMensaje>
    {
        public PersonaMensajeria(PersonaMensaje value):base(value) 
        { 
        
        }
    }
}
