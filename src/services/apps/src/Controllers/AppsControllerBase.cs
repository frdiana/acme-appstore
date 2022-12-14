using Acme.AppStore.Apps.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Acme.AppStore.Apps.Controllers
{

    public class AppsControllerBase : ControllerBase
    {
        protected App[] Apps => new App[] { new App("WhatsApp", "Messaging"), new App("TikTok", "Social Network"), new App("Youtube", "Media"), new App("Twitter", "Social Network"), new App("Spotify", "Music") };
    }
}
