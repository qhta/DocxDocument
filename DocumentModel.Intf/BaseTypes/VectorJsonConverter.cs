using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
internal class VectorJsonConverter : JsonConverter
{
  public override bool CanConvert(Type objectType)
  {
    return objectType == typeof(VectorVariant);
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
    if (value is Variant variant)
      writer.WriteValue(variant.ToString(CultureInfo.InvariantCulture));
  }
}
