using SlackBotMessages;
using SlackBotMessages.Models;
using System.Collections.Generic;
using System.Web.Configuration;
using Umbraco.Core.Composing;
using System;

namespace CleanBlog.Core.Composing
{
    public class ApplicationComposer : ComponentComposer<ApplicationComponent>, IUserComposer
    {
    }

    public class ApplicationComponent : IComponent
    {
        public void Initialize()
        {
            try
            {
                var client = new SbmClient(WebConfigurationManager.AppSettings["SlackBotMessagesWebHookUrl"]);

                var message = new Message
                {
                    Username = "Tima Kukushkin",
                    Text = "Hello from Tima",
                    IconEmoji = Emoji.Dog,
                    Attachments = new List<Attachment>()
                {
                    new Attachment()
                    {
                        Fallback = "Clean Blog Website Started.",
                        Color = "good",
                        Fields = new List<Field>()
                        {
                            new Field()
                            {
                                Value = " Clean Blog Website Started"
                            }
                        }
                    }
                }
                };

                client.Send(message);
            }
            catch(Exception ex)
            {
                Current.Logger.Error(typeof(ApplicationComponent), ex, "Unable to send slack message to notify site starting up.");
            }
        }
        public void Terminate()
        {
        }
    }
}
