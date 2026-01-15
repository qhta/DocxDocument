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
  /// Provides a mapping between a source type and member name and a corresponding target type and method name.
  /// </summary>
  /// <remarks>This dictionary is used to associate specific members of one type with related methods on another
  /// type, enabling dynamic lookup or invocation scenarios. The mapping is static and intended for internal use to
  /// facilitate method resolution based on type and member name pairs.</remarks>
  private static readonly Dictionary<(Type, string), (Type, string)> methodMap = new()
  {
#pragma warning disable OOXML0001
 //   { (typeof(DMW.Document), nameof(DMW.Document.CoreProperties)), (typeof(DMW.Document), nameof(DMW.Document.SetCoreProperties)) },
  };

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
  public static PropertyInfo? GetOpenXmlPropertyForModelElementProperty(PropertyInfo modelElementProperty, Type openXmlType)
  {
    var openXmlPropertyName =
      modelElementProperty.GetCustomAttribute<OpenXmlPropertyAttribute>() is { } openXmlPropertyAttribute ?
        openXmlPropertyAttribute.PropertyName : modelElementProperty.Name;
    var result = openXmlType.GetProperty(openXmlPropertyName, BindingFlags.Public | BindingFlags.Instance);
    return result;
  }

  /// <summary>
  /// Retrieves the mapped method information for the specified member name on the given source type, if a mapping
  /// exists.
  /// </summary>
  /// <param name="modelElementProperty">The property of the model element for which to find the corresponding OpenXML property. Must not be null.</param>
  /// <returns>A tuple containing the mapped method's type and name if a mapping exists; otherwise, null.</returns>
  public static MethodInfo? GetMappedMethod(PropertyInfo modelElementProperty)
  {
    var sourceType = modelElementProperty.DeclaringType;
    var memberName = modelElementProperty.Name;
    if (sourceType == null || string.IsNullOrEmpty(memberName))
    {
      return null;
    }
    if (methodMap.TryGetValue((sourceType, memberName), out var targetEntry))
    {
      return targetEntry.Item1.GetMethod(targetEntry.Item2);
    }
    return null;
  }
}