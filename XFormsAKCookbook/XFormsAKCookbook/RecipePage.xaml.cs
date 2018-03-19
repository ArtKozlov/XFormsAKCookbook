using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XFormsAKCookbook.DataModel;

namespace XFormsAKCookbook
{
	public partial class RecipePage : ContentPage
	{
		public RecipePage()
		{
			InitializeComponent();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			this.BindingContext = (await ((App)Application.Current).GetRecipeViewModelAsync()).Recipe;
		}
	}
}
