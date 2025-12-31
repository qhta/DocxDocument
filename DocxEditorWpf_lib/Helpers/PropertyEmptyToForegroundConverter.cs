namespace DocxEditor.Helpers
{
  /// <summary>
  /// Converts IsEmpty property to Foreground brush - light gray if empty, default otherwise.
  /// </summary>
  public class PropertyEmptyToForegroundConverter : IValueConverter
  {
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      if (value is bool isEmpty && isEmpty)
      {
        return new SolidColorBrush(Colors.DarkGray);
      }
      return new SolidColorBrush(Colors.Black);
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}