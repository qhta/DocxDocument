namespace DocumentModel;

/// <summary>
/// Factory for creating instances of <see cref="ListOfJsonConverter{T}"/> for specific element types.
/// </summary>
public class ListOfJsonConverterFactory : JsonConverterFactory
{
  /// <summary>
  /// Determines whether the converter can convert the specified type.
  /// </summary>
  /// <param name="typeToConvert">The type to check.</param>
  /// <returns><see langword="true"/> if the type is a <see cref="List{T}"/> type; otherwise, <see langword="false"/>.</returns>
  public override bool CanConvert(Type typeToConvert)
  {
    if (!typeToConvert.IsGenericType)
      return false;

    //var genericType = typeToConvert.GetGenericTypeDefinition();
    //var result = genericType == typeof(List<>);
    return true;
  }

  /// <summary>
  /// Creates a converter instance for the specified type.
  /// </summary>
  /// <param name="typeToConvert">The type to create a converter for.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> to use.</param>
  /// <returns>A <see cref="JsonConverter"/> instance for the specified type.</returns>
  public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
  {
    var elementType = typeToConvert.GetGenericArguments()[0];
    var converterType = typeof(ListOfJsonConverter<>).MakeGenericType(elementType);
    return (JsonConverter?)Activator.CreateInstance(converterType);
  }
}
