namespace DocumentModel;

/// <summary>
/// Provides methods for mapping model element properties to their corresponding OpenXML properties.
/// </summary>
/// <remarks>This class is intended for use when working with custom model elements that are mapped to OpenXML
/// types. It assists in resolving the correct OpenXML property based on model property metadata. All members are static
/// and thread safe.</remarks>
public static class OpenXmlPropertyMap
{
  /// <summary>
  /// Retrieves the corresponding OpenXML property for a given model element property from the specified OpenXML type.
  /// </summary>
  /// <remarks>If the model element property is decorated with an OpenXmlPropertyAttribute, its PropertyName
  /// value is used to locate the OpenXML property; otherwise, the property name itself is used. The search is
  /// case-sensitive and limited to public instance properties.</remarks>
  /// <param name="modelElementProperty">The property of the model element for which to find the corresponding OpenXML property. Must not be null.</param>
  /// <param name="openXmlType">The OpenXML type to search for the property mapping. Must not be null.</param>
  /// <returns>A PropertyInfo object representing the OpenXML property that corresponds to the specified model element property.</returns>
  /// <exception cref="ArgumentException">Thrown if no corresponding OpenXML property is found for the specified model element property.</exception>
  public static PropertyInfo GetOpenXmlPropertyForModelElementProperty(PropertyInfo modelElementProperty, Type openXmlType)
  {
    var openXmlPropertyName =
      modelElementProperty.GetCustomAttribute<OpenXmlPropertyAttribute>() is { } openXmlPropertyAttribute ?
        openXmlPropertyAttribute.PropertyName : modelElementProperty.Name;
    var result = openXmlType.GetProperty(openXmlPropertyName, BindingFlags.Public | BindingFlags.Instance);
    if (result is null)
    {
      throw new ArgumentException($"No OpenXML type mapping found for {modelElementProperty.Name}");
    }
    return result;
  }
}