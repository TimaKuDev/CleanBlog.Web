using CleanBlog.Core.Services;
using Umbraco.Core.Composing;
using Umbraco.Core;

namespace CleanBlog.Core.Composing
{
    public class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<ISmtpService,SmtpService>(Lifetime.Singleton);
            composition.Register<IArticleService,ArticleService>(Lifetime.Request);
        }

    }
}
