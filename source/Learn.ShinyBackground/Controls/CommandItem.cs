using System.Windows.Input;

namespace Learn.ShinyBackground.Controls
{
  public class CommandItem
  {
    public string ImageUri { get; set; }

    // Observable?
    public string Text { get; set; }

    public string Detail { get; set; }

    public ICommand PrimaryCommand { get; set; }

    public ICommand SecondaryCommand { get; set; }

    public object Data { get; set; }
  }
}
