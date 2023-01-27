using Newtonsoft.Json.Linq;

namespace DocumentModel;

public class VectorVariantTypeConverter : TypeConverter
{
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == null)
      return false;
    if (destinationType == typeof(string)) return true;
    return base.CanConvertTo(destinationType);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    return Variant.ConvertTo(context, culture, value, destinationType);
  }

  public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
  {
    if (sourceType == typeof(string))
      return true;
    if (sourceType == typeof(JArray))
      return true;
    return base.CanConvertFrom(context, sourceType);
  }

  public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
  {
    var result = new VectorVariant();
    if (value is JArray jArray)
    {
      foreach (var item in jArray)
      {
        if (item is JValue jValue)
        {
          result.Add(jValue.Value);
        //  string? str = null;
        //  int? num = null;
        //  var firstItem = jToken.FirstOrDefault();
        //  if (firstItem is JProperty jProperty)
        //  {
        //    str = jProperty.Value.Value<string>();
        //    var nextItem = jToken.Next;
        //    if (nextItem is JProperty jProperty2)
        //    {
        //      num = jProperty.Value.Value<int>();
        //    }
        //    result.Add(new StringNum { Str = str, Num = num });
        //  }
        }
      }
      return result;
    }
    if (value is Variant variant)
      return variant;
    return base.ConvertFrom(context, culture, value);
  }

}