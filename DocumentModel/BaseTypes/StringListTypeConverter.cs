using Newtonsoft.Json.Linq;

namespace DocumentModel;

public class StringListTypeConverter : TypeConverter
{
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == null)
      return false;
    if (destinationType == typeof(String))
      return true;
    if (destinationType == typeof(JArray))
      return true;
    return base.CanConvertFrom(context, destinationType);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    if (value is StringList stringList)
    {
      if (destinationType == typeof(string))
      {
        return String.Join(" ", stringList.Select(item=>"\""+item+"\""));
      }
    }
    return base.ConvertTo(context, culture, value, destinationType);
  }

  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(String))
      return true;
    if (sourceType == typeof(JArray))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    var result = new StringList();
    if (value is JArray jArray)
    {
      foreach (var item in jArray)
      {
        string? str = (item as JValue)?.Value<string>();
        if (str != null)
          result.Add(str);
      }
      return result;
    }
    return base.ConvertFrom(context, culture, value);
  }

}