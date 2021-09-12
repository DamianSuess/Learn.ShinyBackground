using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Learn.ShinyBackground.Controls
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class CommandCell : ContentView
  {
    public CommandCell()
    {
      InitializeComponent();
      PrimaryCommandText = "Run";
      PrimaryCommandColor = Color.DodgerBlue;

      SecondaryCommandText = "Cancel";
      SecondaryCommandColor = Color.Red;
    }

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
      nameof(Text),
      typeof(string),
      typeof(CommandCell),
      String.Empty
    );

    public string Text
    {
      get => (string)GetValue(TextProperty);
      set => SetValue(TextProperty, value);
    }

    public static readonly BindableProperty DetailProperty = BindableProperty.Create(
      nameof(Detail),
      typeof(string),
      typeof(CommandCell),
      String.Empty
    );

    public string Detail
    {
      get => (string)GetValue(DetailProperty);
      set => SetValue(DetailProperty, value);
    }

    public static readonly BindableProperty PrimaryCommandTextProperty = BindableProperty.Create(
      nameof(PrimaryCommandText),
      typeof(string),
      typeof(CommandCell),
      "Run"
    );

    public string PrimaryCommandText
    {
      get => (string)GetValue(PrimaryCommandTextProperty);
      set => SetValue(PrimaryCommandTextProperty, value);
    }

    public static readonly BindableProperty PrimaryCommandColorProperty = BindableProperty.Create(
      nameof(PrimaryCommandColor),
      typeof(Color),
      typeof(CommandCell),
      Color.DodgerBlue
    );

    public Color PrimaryCommandColor
    {
      get => (Color)GetValue(PrimaryCommandColorProperty);
      set => SetValue(PrimaryCommandColorProperty, value);
    }

    public static readonly BindableProperty PrimaryCommandProperty = BindableProperty.Create(
        nameof(PrimaryCommandText),
        typeof(ICommand),
        typeof(CommandCell),
        null
    );

    public ICommand PrimaryCommand
    {
      get => (ICommand)GetValue(PrimaryCommandProperty);
      set => SetValue(PrimaryCommandProperty, value);
    }

    public static readonly BindableProperty SecondaryCommandTextProperty = BindableProperty.Create(
      nameof(SecondaryCommandText),
      typeof(string),
      typeof(CommandCell),
      "Cancel"
    );

    public string SecondaryCommandText
    {
      get => (string)GetValue(SecondaryCommandTextProperty);
      set => SetValue(SecondaryCommandTextProperty, value);
    }

    public static readonly BindableProperty SecondaryCommandColorProperty = BindableProperty.Create(
      nameof(SecondaryCommandColor),
      typeof(Color),
      typeof(CommandCell),
      Color.Red
    );

    public Color SecondaryCommandColor
    {
      get => (Color)GetValue(SecondaryCommandColorProperty);
      set => SetValue(SecondaryCommandColorProperty, value);
    }

    public static readonly BindableProperty SecondaryCommandProperty = BindableProperty.Create(
      nameof(SecondaryCommand),
      typeof(ICommand),
      typeof(CommandCell),
      null
    );

    public ICommand SecondaryCommand
    {
      get => (ICommand)GetValue(SecondaryCommandProperty);
      set => SetValue(SecondaryCommandProperty, value);
    }
  }
}
