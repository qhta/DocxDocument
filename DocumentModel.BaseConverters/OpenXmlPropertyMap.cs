namespace DocumentModel.OpenXml;

/// <summary>
/// Provides methods for mapping model element properties to their corresponding OpenXML properties.
/// </summary>
/// <remarks>This class is intended for use when working with custom model elements Ithat are mapped to OpenXML
/// types. It assists in resolving the correct OpenXML property based on model property metadata. All members are static
/// and thread safe.</remarks>
public static class OpenXmlPropertyMap
{



  /// <summary>
  /// Retrieves the corresponding OpenXML property for a given model element property from the specified OpenXML type.
  /// </summary>
  /// <remarks>If the model element property is decorated with an OpenXmlPropertyAttribute, its Method
  /// value is used to locate the OpenXML property; otherwise, the property name itself is used. The search is
  /// case-sensitive and limited to public instance properties.</remarks>
  /// <param name="modelProperty">The property of the model element for which to find the corresponding OpenXML property. Must not be null.</param>
  /// <param name="openXmlType">The OpenXML type to search for the property mapping. Must not be null.</param>
  /// <returns>A PropertyInfo object representing the OpenXML property Ithat corresponds to the specified model element property.</returns>
  /// <exception cref="ArgumentException">Thrown if no corresponding OpenXML property is found for the specified model element property.</exception>
  public static PropertyInfo? GetOpenXmlProperty(PropertyInfo modelProperty, Type openXmlType)
  {
    var openXmlPropertyName =
      modelProperty.GetCustomAttribute<OpenXmlPropertyAttribute>() is { } openXmlPropertyAttribute ?
        openXmlPropertyAttribute.PropertyName : modelProperty.Name;
    var result = openXmlType.GetProperty(openXmlPropertyName, BindingFlags.Public | BindingFlags.Instance);
    return result;
  }


  /// <summary>
  /// Retrieves the update data method information for the model property.
  /// This method is used to update the OpenXml element with the model property value.
  /// </summary>
  /// <param name="modelProperty">The property of the model element for which to find the appropriate method.</param>
  /// <param name="openXmlType">The OpenXml type to update data.</param>
  /// <remarks>
  /// Attempts to find a method name specified in the OpenXmlUpdateDataAttribute applied to the model property.
  /// </remarks>
  /// <returns>A method info is found; otherwise, null.</returns>
  public static MethodInfo? GetUpdateDataMethod(PropertyInfo modelProperty, Type openXmlType)
  {
    var sourceType = modelProperty.DeclaringType;
    var memberName = modelProperty.Name;
    if (sourceType == null || string.IsNullOrEmpty(memberName))
    {
      return null;
    }

    var methodName = modelProperty.GetCustomAttribute<OpenXmlUpdateDataAttribute>()?.MethodName;
    if (methodName != null)
    {
      var methodInfo = modelProperty.DeclaringType?
        .GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
      if (methodInfo != null)
        return methodInfo;
    }

    return null;
  }

  /// <summary>
  /// Retrieves the load data method information for the model property.
  /// This method is used to load data from the OpenXml element to the model property value.
  /// </summary>
  /// <param name="modelProperty">The property of the model element for which to find the appropriate method.</param>
  /// <param name="openXmlType">The OpenXml type to update data.</param>
  /// <remarks>
  /// Attempts to find a method name specified in the OpenXmlLoadDataAttribute applied to the model property.
  /// </remarks>
  /// <returns>A method info is found; otherwise, null.</returns>
  public static MethodInfo? GetLoadDataMethod(PropertyInfo modelProperty, Type openXmlType)
  {
    var sourceType = modelProperty.DeclaringType;
    var memberName = modelProperty.Name;
    if (sourceType == null || string.IsNullOrEmpty(memberName))
    {
      return null;
    }

    var methodName = modelProperty.GetCustomAttribute<OpenXmlLoadDataAttribute>()?.MethodName;
    if (methodName != null)
    {
      var methodInfo = modelProperty.DeclaringType?
        .GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
      if (methodInfo != null)
        return methodInfo;
    }

    return null;
  }
}
