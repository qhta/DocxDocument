namespace DocumentModel;

/// <summary>
/// Provides methods for mapping model element properties to their corresponding OpenXML properties.
/// </summary>
/// <remarks>This class is intended for use when working with custom model elements that are mapped to OpenXML
/// types. It assists in resolving the correct OpenXML property based on model property metadata. All members are static
/// and thread safe.</remarks>
public static class OpenXmlPropertyMap
{

  //  private static readonly Dictionary<(Type, string), (Type, string)> propertyMap = new()
  //  {
  //#pragma warning disable OOXML0001
  //    { (typeof(DMW.Document), nameof(DMW.Document.CoreProperties)), (typeof(DXPP.WordprocessingDocument), "M`ainDocumentPart.OpenXmlPackage.PackageProperties") },
  //  };


  /// <summary>
  /// Retrieves the corresponding OpenXML property for a given model element property from the specified OpenXML type.
  /// </summary>
  /// <remarks>If the model element property is decorated with an OpenXmlPropertyAttribute, its MethodName
  /// value is used to locate the OpenXML property; otherwise, the property name itself is used. The search is
  /// case-sensitive and limited to public instance properties.</remarks>
  /// <param name="modelElementProperty">The property of the model element for which to find the corresponding OpenXML property. Must not be null.</param>
  /// <param name="openXmlType">The OpenXML type to search for the property mapping. Must not be null.</param>
  /// <returns>A PropertyInfo object representing the OpenXML property that corresponds to the specified model element property.</returns>
  /// <exception cref="ArgumentException">Thrown if no corresponding OpenXML property is found for the specified model element property.</exception>
  public static PropertyInfo? GetOpenXmlPropertyForModelProperty(PropertyInfo modelElementProperty, Type openXmlType)
  {
    var openXmlPropertyName =
      modelElementProperty.GetCustomAttribute<OpenXmlPropertyAttribute>() is { } openXmlPropertyAttribute ?
        openXmlPropertyAttribute.PropertyName : modelElementProperty.Name;
    var result = openXmlType.GetProperty(openXmlPropertyName, BindingFlags.Public | BindingFlags.Instance);
    return result;
  }


  /// <summary>
  /// Retrieves the get method information for the model property in the given OpenXml type.
  /// </summary>
  /// <param name="modelElementProperty">The property of the model element for which to find the appropriate set method. Must not be null.</param>
  /// <param name="openXmlType">The OpenXml type to search for property set method. Must not be null</param>
  /// <remarks>
  /// First openXmlType is search for a method with a name of "Set" + propertyName.
  /// Next modelType type of model property is searched or a method with a name of "Set" + propertyName +"InOpenXml.
  /// </remarks>
  /// <returns>A set method info is found; otherwise, null.</returns>
  public static MethodInfo? GetSetMethod(PropertyInfo modelElementProperty, Type openXmlType)
  {
    var sourceType = modelElementProperty.DeclaringType;
    var memberName = modelElementProperty.Name;
    if (sourceType == null || string.IsNullOrEmpty(memberName))
    {
      return null;
    }

    var methodName = "Set" + modelElementProperty.Name;

    var methodInfo = openXmlType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);
    if (methodInfo == null)
    {
      methodName = "Set" + modelElementProperty.Name + "InOpenXml";
      methodInfo = modelElementProperty.DeclaringType?.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);
    }
    if (methodInfo != null)
      return methodInfo;

    return null;
  }

  /// <summary>
  /// Retrieves the get method information for the model property in the given OpenXml type.
  /// </summary>
  /// <param name="modelElementProperty">The property of the model element for which to find the appropriate get method. Must not be null.</param>
  /// <param name="openXmlType">The OpenXml type to search for property get method. Must not be null</param>
  /// <remarks>
  /// First openXmlType is search for a method with a name of "Get" + propertyName.
  /// Next modelType type of model property is searched or a method with a name of "Get" + propertyName +"InOpenXml.
  /// </remarks>
  /// <returns>A get method info is found; otherwise, null.</returns>
  public static MethodInfo? GetGetMethod(PropertyInfo modelElementProperty, Type openXmlType)
  {
    var sourceType = modelElementProperty.DeclaringType;
    var memberName = modelElementProperty.Name;
    if (sourceType == null || string.IsNullOrEmpty(memberName))
    {
      return null;
    }

    var methodName = "Get" + modelElementProperty.Name;

    var methodInfo = openXmlType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);
    if (methodInfo == null)
    {
      methodName = "Get" + modelElementProperty.Name + "InOpenXml";
      methodInfo = modelElementProperty.DeclaringType?.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public);
    }
    if (methodInfo != null)
      return methodInfo;

    return null;
  }
}