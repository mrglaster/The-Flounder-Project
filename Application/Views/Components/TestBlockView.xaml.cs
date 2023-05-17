using System.Windows.Input;

namespace Glossa_App.Views.Components;

public partial class TestBlockView : ContentView
{

    //public event EventHandler Tapped;
    public static readonly BindableProperty TappedCommandProperty =
        BindableProperty.Create(nameof(TappedCommand), typeof(ICommand), typeof(TestBlockView));

    public ICommand TappedCommand
    {
        get { return (ICommand)GetValue(TappedCommandProperty); }
        set { SetValue(TappedCommandProperty, value); }
    }
    public TestBlockView()
	{
		InitializeComponent();

        /*var tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += OnTapped;
        module.GestureRecognizers.Add(tapGestureRecognizer);*/
    }

    private void OnTapped(object sender, EventArgs e)
    {
        if (TappedCommand != null)
            TappedCommand.Execute(null);
    }
}