using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EventsToBehaviors
{
	public class MainPageViewModel
	{
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
		public ICommand ButtonCommand { get; } = new Command(async () =>
		{
			await App.Current.MainPage.DisplayAlert("Command", "Hey there from ButtonCommand", "Ok");
		});

		public MainPageViewModel()
        {
            People.Add(new Person { Name = "George", Age = 20 });
			People.Add(new Person { Name = "Marty", Age = 30 });
            People.Add(new Person { Name = "Sam", Age = 40 });
		}

		public ICommand ItemTappedCommand { get; } = new Command(async () =>
		{
			await App.Current.MainPage.DisplayAlert("Item Tapped", "You have touched an item in the list", "Ok");
		});
	}
}
