using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HmhengXamBot.Core
{
	public class WebPage : ContentPage
	{
		public WebPage ()
		{
			
            var browser = new WebView();
            browser.Source = "https://webchat.botframework.com/embed/<BOT_NAME_HERE>?s=<BOT_SECRET_KEY_HERE>";
            this.Content = browser;

        }
    }
}