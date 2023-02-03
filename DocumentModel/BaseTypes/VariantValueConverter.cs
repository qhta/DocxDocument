using System.Xml;

using Newtonsoft.Json.Linq;

namespace DocumentModel;

public class VariantValueConverter : TypeConverter
{
  public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
  {
    if (destinationType == typeof(String))
      return true;
    return base.CanConvertTo(context, destinationType);
  }

  public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
  {
    object? result = null;
    if (destinationType == typeof(String))
    {
      if (value is Variant variant)
        result = variant.ToString(CultureInfo.InvariantCulture);
      else if (value != null)
      {
        var valueTypeConverter = new ValueTypeConverter(value.GetType());
        if (valueTypeConverter.CanConvertTo(context, destinationType))
          result = valueTypeConverter.ConvertTo(context, null, value, destinationType);
        else
          result = value.ToString();
      }
    }
    else
      result = base.ConvertTo(context, culture, value, destinationType);
    return result;
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

    if (value is string str)
    {
      var result = Variant.ConvertFrom(context, culture, str);
      return result;
    }
    else
    if (value is JArray jArray)
    {
      var result = new VectorVariant();
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
    return base.ConvertFrom(context, culture, value);
  }


}