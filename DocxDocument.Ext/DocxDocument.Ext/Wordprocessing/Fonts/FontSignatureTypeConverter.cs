using System.Net.WebSockets;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Type converter for FontSignature type
/// </summary>
public class FontSignatureTypeConverter: TypeConverter
{
  /// <summary>
  /// Determines if a value can be converted from source type.
  /// </summary>
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  /// <summary>
  /// Determines if a value can be converted to destination type.
  /// </summary>
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(string))
      return true;
    return base.CanConvertTo(context, destinationType);
  }

  /// <summary>
  /// Converts the string value to FontSignature object.
  /// </summary>
  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    if (value is string str)
    {
      var result = new FontSignature();
      var ss = str.Split(" ");
      int i=0;
      foreach (var s in ss)
      {
        result.Items[i++] = s;
      }
      return result;
    }
    return base.ConvertFrom(context, culture, value);
  }

  /// <summary>
  /// Converts the FontSignature object to string value.
  /// </summary>
  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is FontSignature fontSignature)
    {
      return String.Join(" ",fontSignature.Items.Select(sig=>sig.ToString()));
    }
    return base.ConvertTo(context, culture, value, destinationType);
  }
}
