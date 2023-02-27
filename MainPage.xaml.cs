

using BindingToObject.Models;


namespace Collections;

public partial class MainPage : ContentPage
{

	public Student Student { get; set; }
	

	public MainPage()
	{
		
		Student = new () { Name="Roni", Image="roni.jpg", BirthDate=new DateTime(2006,2,19)};
		InitializeComponent();
		this.BindingContext = Student;
		
		

	}

	
}





