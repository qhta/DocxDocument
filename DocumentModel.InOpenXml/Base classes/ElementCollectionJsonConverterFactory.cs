using System;
using System.Text.Json.Serialization;

namespace DocumentModel
{
  /// <summary>
  ///   Provides a custom JSON converter factory for <c>ElementCollection&lt;T&gt;</c> types, enabling correct serialization and deserialization of collection elements in the document model.
  ///   Supports both direct and derived types of <c>ElementCollection&lt;T&gt;</c>.
  /// </summary>
  public class ElementCollectionJsonConverterFactory : JsonConverterFactory
  {
    /// <summary>
    ///   Determines whether the specified type can be converted by this factory (i.e., is or derives from <c>ElementCollection&lt;T&gt;</c>).
    /// </summary>
    /// <param name="typeToConvert">The type to check for conversion support.</param>
    /// <returns>True if the type is or derives from <c>ElementCollection&lt;T&gt;</c>; otherwise, false.</returns>
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

    /// <summary>
    ///   Creates a JSON converter for the specified <c>ElementCollection&lt;T&gt;</c> type.
    /// </summary>
    /// <param name="typeToConvert">The type of the collection to convert.</param>
    /// <param name="options">The serializer options to use for conversion.</param>
    /// <returns>A <see cref="JsonConverter"/> instance for the specified collection type.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the type parameters cannot be determined.</exception>
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
