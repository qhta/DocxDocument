using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Qhta.TypeUtils;
namespace DocumentModel;
internal class VariantJsonConverter : JsonConverter
{
  public override bool CanConvert(Type objectType)
  {
    return objectType.IsEqualOrSubclassOf(typeof(Variant));
  }
  public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
  {
    var val = reader.Value;
    if (val == null)
      return null;
    return new Variant(val);
  }
  public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
  {
    if (value is VectorVariant vector)
      writer.WriteValue(vector.ToString(CultureInfo.InvariantCulture));
    else if (value is Variant variant)
      writer.WriteValue(variant.ToString(CultureInfo.InvariantCulture));
  }
}
