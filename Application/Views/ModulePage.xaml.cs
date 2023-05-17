//using Android.OS;
using System.Diagnostics;

namespace Glossa_App.Views;

[QueryProperty(nameof(DownloadLink), "downloadLink")]
public partial class ModulePage : ContentPage
{
    private string downloadLink;

    public string DownloadLink
    {
        get => downloadLink;
        set {
            downloadLink = value;
            //viewmodel.DownloadLink = downloadLink;
            System.Diagnostics.Debug.WriteLine("I " + downloadLink);
        }
    }
    public ModulePage()
	{
		InitializeComponent();
	}

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();

    //    System.Diagnostics.Debug.WriteLine(downloadLink);
        
    //}
}