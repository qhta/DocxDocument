namespace DocumentModel.OpenXml;

public delegate object? ConvertFromOpenXml(object? openXmlValue, Type modelType);
public delegate object? ConvertToOpenXml(object? modelValue, Type openXmlType);

/// <summary>
/// Provides a mapping between DocumentModel element types and their corresponding OpenXML types.
/// </summary>
public static class OpenXmlTypeMap
{

  /// <summary>
  /// Retrieves the corresponding OpenXML type for the specified model element type.
  /// </summary>
  /// <param name="modelElementType">The type of the model element for which to obtain the mapped OpenXML type. Cannot be null.</param>
  /// <returns>The OpenXML type that is mapped to the specified model element type, or null if no mapping exists.</returns>
  public static Type? GetOpenXmlTypeForModelElementType(Type modelElementType)
  {
    //if (_typeMap.TryGetValue(modelElementType, out var openXmlType))
    //{
    //  return openXmlType;
    //}
    if (modelElementType.GetCustomAttribute<OpenXmlTypeAttribute>() is { } openXmlTypeAttr)
    {
      return openXmlTypeAttr.Type;
    }
    return null;
  }
}