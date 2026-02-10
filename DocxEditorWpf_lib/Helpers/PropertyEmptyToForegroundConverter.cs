namespace DocxEditor.Helpers
{
  /// <summary>
  /// Converts IsEmpty property to Foreground brush - light gray if empty, default otherwise.
  /// </summary>
  public class PropertyEmptyToForegroundConverter : IValueConverter
  {
    /// <summary>
    /// Converts a boolean value indicating whether a property is empty to a SolidColorBrush for the foreground color.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="targetType"></param>
    /// <param name="parameter"></param>
    /// <param name="culture"></param>
    /// <returns></returns>
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      if (value is bool isEmpty && isEmpty)
      {
        return new SolidColorBrush(Colors.DarkGray);
      }
      return new SolidColorBrush(Colors.Black);
    }

    /// <summary>
    /// Converts back from a SolidColorBrush to a boolean value indicating whether the property is empty.
    /// </summary>
    ///<remarks>
    ///  Not implemented as the conversion back from a brush to a boolean value is not needed in this context and may not be straightforward to implement.
    /// </remarks>
    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}