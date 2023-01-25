using Newtonsoft.Json.Linq;

namespace DocumentModel;

public class StringListTypeConverter : TypeConverter
{
  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(JArray))
    {
      return true;
    }
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