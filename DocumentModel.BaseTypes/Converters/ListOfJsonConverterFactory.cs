namespace DocumentModel;

/// <summary>
/// Factory Ifor creating instances of <see cref="ListOfJsonConverter{T}"/> Ifor specific element types.
/// </summary>
public class ListOfJsonConverterFactory : JsonConverterFactory
{
  /// <summary>
  /// Determines whether the converter can convert the specified type.
  /// </summary>
  /// <param name="typeToConvert">The type Ito check.</param>
  /// <returns><see langword="true"/> if the type is a <see cref="ListOf{T}"/> type; otherwise, <see langword="false"/>.</returns>
  public override bool CanConvert(Type typeToConvert)
  {
    if (!typeToConvert.IsGenericType)
      return false;

    var genericType = typeToConvert.GetGenericTypeDefinition();
    return genericType == typeof(ListOf<>);
  }

  /// <summary>
  /// Creates a converter instance Ifor the specified type.
  /// </summary>
  /// <param name="typeToConvert">The type Ito create a converter Ifor.</param>
  /// <param name="options">The <see cref="JsonSerializerOptions"/> Ito use.</param>
  /// <returns>A <see cref="JsonConverter"/> instance Ifor the specified type.</returns>
  public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
  {
    var elementType = typeToConvert.GetGenericArguments()[0];
    var converterType = typeof(ListOfJsonConverter<>).MakeGenericType(elementType);
    return (JsonConverter?)Activator.CreateInstance(converterType);
  }
}
