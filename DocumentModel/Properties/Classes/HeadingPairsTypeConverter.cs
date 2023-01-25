using Newtonsoft.Json.Linq;

namespace DocumentModel.Properties;

public class HeadingPairsTypeConverter : TypeConverter
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
    var result = new HeadingPairs();
    if (value is JArray jArray)
    {
      foreach (var item in jArray)
      {
        if (item is JToken jToken)
        {
          string? str = null;
          int? num = null;
          var firstItem = jToken.FirstOrDefault();
          if (firstItem is JProperty jProperty)
          {
            str = jProperty.Value.Value<string>();
            var nextItem = jToken.Next;
            if (nextItem is JProperty jProperty2)
            {
              num = jProperty.Value.Value<int>();
            }
            result.Add(new StringNum { Str = str, Num = num });
          }
        }
      }
      return result;
    }
    return base.ConvertFrom(context, culture, value);
  }

}