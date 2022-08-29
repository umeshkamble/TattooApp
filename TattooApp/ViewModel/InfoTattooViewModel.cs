using System;
using System.Web;
using TattooApp.ViewModel.Base;

namespace TattooApp.ViewModel
{
	public class InfoTattooViewModel:BaseViewModel, IQueryAttributable
    {
		public InfoTattooViewModel()
		{

		}

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            var name = HttpUtility.UrlDecode((string)query["name"]);
            //LoadAnimal(name);
        }
    }
}

