using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading.Tasks;

namespace WebHooksExample.WebHookHandlers
{
    public class DropboxWebHookHandler : WebHookHandler
    {
        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
			// make sure we're only processing the intended type of hook
			if("Dropbox".Equals(receiver, System.StringComparison.CurrentCultureIgnoreCase))
			{
				// todo: replace this placeholder functionality with your own code
				string action = context.Actions.First();
				JObject incoming = context.GetDataOrDefault<JObject>();
			}
            
            return Task.FromResult(true);
        }
    }
}
