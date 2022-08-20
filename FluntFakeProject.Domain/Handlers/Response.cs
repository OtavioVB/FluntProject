using Flunt.Notifications;
using Flunt.Validations;

namespace FluntFakeProject.Domain.Handlers
{
    public class Response : Notifiable
    {
        public string Message { get; private set; }

        public Response(string message, IReadOnlyCollection<INotification> notifications) 
        { 
            Message = message;
            AddNotifications(notifications);
        }

        public Response(string message)
        {
            Message = message;
        }
    }
}
