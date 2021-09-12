﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace Learn.ShinyBackground.Converters
{
  public class InverseBooleanConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => !(bool)value;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => !(bool)value;
  }
}
