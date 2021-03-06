﻿using System;
using Windows.UI.Xaml.Data;

namespace BandBridge.Converters
{
    /// <summary>
    /// Negates given boolean value.
    /// </summary>
    public class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (targetType != typeof(bool)) throw new InvalidOperationException("The target must be boolean");
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
