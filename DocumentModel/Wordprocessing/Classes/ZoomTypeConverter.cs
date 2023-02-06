namespace DocumentModel.Wordprocessing;

/// <summary>
///   Magnification Setting.
/// </summary>
public class ZoomTypeConverter: TypeConverter
{
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    return destinationType == typeof(string);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is Zoom zoom)
    {
      if (zoom.Percent != null)
        return zoom.Percent.ToString() + "%";
      return zoom.Kind.ToString();
    }
    return base.ConvertTo(context, culture, value, destinationType);
  }

  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    return sourceType == typeof(string);
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      if (str.EndsWith('%'))
      {
        str = str.Substring(0, str.Length - 1);
        return new Zoom { Percent = int.Parse(str) };
      }
      else if (Enum.TryParse<PresetZoomKind>(str, out var kind))
      {
        return new Zoom { Kind = kind };
      }
    }
    return base.ConvertFrom(context, culture, value);
  }
}