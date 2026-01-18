using System;
using System.Text.Json.Serialization;

namespace DocumentModel
{
  public class ElementCollectionJsonConverterFactory : JsonConverterFactory
  {
    public override bool CanConvert(Type typeToConvert)
    {
      // Check if typeToConvert inherits from ElementCollection<T>
      if (!typeToConvert.IsGenericType)
        return false;

      var genericDef = typeToConvert.GetGenericTypeDefinition();
      return genericDef == typeof(ElementCollection<>)
          || typeToConvert.BaseType != null && typeToConvert.BaseType.IsGenericType &&
             typeToConvert.BaseType.GetGenericTypeDefinition() == typeof(ElementCollection<>);
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
      // Find the T in ElementCollection<T>
      Type? itemType = null;
      Type? collectionType = null;

      if (typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(ElementCollection<>))
      {
        itemType = typeToConvert.GetGenericArguments()[0];
        collectionType = typeToConvert;
      }
      else
      {
        // For derived types
        var baseType = typeToConvert;
        while (baseType != null && baseType != typeof(object))
        {
          if (baseType.IsGenericType && baseType.GetGenericTypeDefinition() == typeof(ElementCollection<>))
          {
            itemType = baseType.GetGenericArguments()[0];
            collectionType = typeToConvert;
            break;
          }
          baseType = baseType.BaseType;
        }
      }

      if (itemType == null || collectionType == null)
        throw new InvalidOperationException("Cannot determine ElementCollection<T> type parameters.");

      var converterType = typeof(ElementCollectionJsonConverter<,>).MakeGenericType(collectionType, itemType);
      return (JsonConverter)Activator.CreateInstance(converterType)!;
    }
  }
}