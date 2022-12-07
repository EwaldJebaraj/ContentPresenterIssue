using System.Collections.ObjectModel;

namespace ContentTemplateIssue
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			
		}
	}

	public class Model
	{
		public string Name { get; set; }

		public View NewContent {  get; set; }

		public Model()
		{ 
		}
	}

	public class ViewModel
	{
		public ObservableCollection<Model> Models { get; set; }

		public ViewModel()
		{
			Models = new ObservableCollection<Model>()
			{
				new Model() {Name = "First",NewContent = new Label(){ Text = "Margin",} },
				new Model() {Name = "Second",NewContent = new Label(){ Text = "Test",} },
				new Model() {Name = "Third",NewContent = new StackLayout(){ Background = Colors.Yellow,} },
			};


		}
	}
}

