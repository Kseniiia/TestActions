using System.Threading;
using Core.Enums;
using Core.UI.WebDriverWrapper;

namespace Core.UI.BrowserBuilder
{
    public class BrowserCreator
    {
        private static ThreadLocal<IBrowser> instance = new ThreadLocal<IBrowser>();

        public static IBrowser GetBrowser(BrowserName browserName)
        {
            if (instance.Value == null)
            {
                instance.Value = BrowserFactory.Create(browserName);
            }

            return instance.Value;
        }

        public static void ReleaseInstance()
        {
            instance.Value = null;
        }
    }
}