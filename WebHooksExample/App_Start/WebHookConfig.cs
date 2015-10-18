using System.Web.Http;

namespace WebHooksExample
{
    public static class WebHookConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.InitializeReceiveGitHubWebHooks();
            config.InitializeReceiveDropboxWebHooks();
        }
    }
}
