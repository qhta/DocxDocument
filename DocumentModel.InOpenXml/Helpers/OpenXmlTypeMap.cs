namespace DocumentModel;

/// <summary>
/// Provides a mapping between DocumentModel element types and their corresponding OpenXML types.
/// </summary>
public static class OpenXmlTypeMap
{
  private static readonly Dictionary<Type, Type> _typeMap = new()
  {
#pragma warning disable OOXML0001
    { typeof(CoreProperties), typeof(PackageProperties) },
    { typeof(ContentProperties), typeof(DXEP.Properties) },
    { typeof(StatisticProperties), typeof(DXEP.Properties) },
    { typeof(CustomProperties), typeof(DXEP.Properties) }
  };

  /// <summary>
  /// Retrieves the corresponding OpenXML type for the specified model element type.
  /// </summary>
  /// <param name="modelElementType">The type of the model element for which to obtain the mapped OpenXML type. Cannot be null.</param>
  /// <returns>The OpenXML type that is mapped to the specified model element type, or null if no mapping exists.</returns>
  public static Type? GetOpenXmlTypeForModelElementType(Type modelElementType)
  {
    if (_typeMap.TryGetValue(modelElementType, out var openXmlType))
    {
      return openXmlType;
    }
    if (modelElementType.GetCustomAttribute<OpenXmlTypeAttribute>() is { } openXmlTypeAttr)
    {
      return openXmlTypeAttr.Type;
    }
    return null;
  }
}