using System.Threading.Tasks;

namespace NickPortfolio.Messaging
{
   public interface IMessageService
    {
      Task SendEmailAsync(
         string fromDisplayName,
         string fromEmailAddress,
         string toName,
         string toEmailAddress,
         string subject,
         string message,
         params Attachment[] attachments);
    }
}
