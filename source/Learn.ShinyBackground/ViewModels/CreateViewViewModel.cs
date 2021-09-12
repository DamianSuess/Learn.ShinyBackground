using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace Learn.ShinyBackground.ViewModels
{
  public class CreateViewViewModel : ViewModelBase
  {
    public CreateViewViewModel(INavigationService navigationService)
      : base(navigationService)
    {

    }
  }
}
