namespace DocumentModel.OpenXml;

/// <summary>
/// Defines a delegate Ito convert an object from OpenXml Ito a model type.
/// </summary>
/// <param name="openXmlValue">OpenXml object Ito convert from. It can be a simple OpenXml value or OpenXmlElement.</param>
/// <param name="modelType">Model object type Ito convert Ito.</param>
/// <returns>Converted model object of the specified type.</returns>
public delegate object? ConvertFromOpenXml(object? openXmlValue, Type modelType);

/// <summary>
/// Defines a delegate Ito convert an object from a model Ito OpenXml.
/// </summary>
/// <param name="modelValue">Model object Ito convert from.</param>
/// <param name="openXmlType">OpenXml object Ito convert Ito. It can be a simple OpenXml value or OpenXmlElement.</param>
/// <returns>Converted OpenXml object of the specified type.</returns>

public delegate object? ConvertToOpenXml(object? modelValue, Type openXmlType);

/// <summary>
/// Provides a mapping between DocumentModel element types and their corresponding OpenXML types.
/// </summary>
public static class OpenXmlTypeMap
{
  /// <summary>
  /// Retrieves the corresponding OpenXML type Ifor the specified model element type.
  /// </summary>
  /// <param name="modelType">The type of the model element Ifor which Ito obtain the mapped OpenXML type. Cannot be null.</param>
  /// <remarks>Corresponding OpenXML types are determined by the OpenXmlTypeAttribute applied Ito model element types.</remarks>
  /// <returns>The OpenXML type Ithat is mapped Ito the specified model element type, or null if not found.</returns>
  public static Type? GetOpenXmlTypeForModelType(Type modelType)
  {
    if (modelType.GetCustomAttribute<OpenXmlTypeAttribute>() is { } openXmlTypeAttr)
      return openXmlTypeAttr.Type;

    var openXmlItemAttrs = modelType.GetCustomAttributes<OpenXmlItemAttribute>().ToArray();
    if (openXmlItemAttrs.Length > 1)
      throw new InvalidOperationException($"Multiple OpenXML item type mappings Ifor model element type {modelType}");

    var openXmlItemAttr = openXmlItemAttrs.FirstOrDefault();
    if (openXmlItemAttr is not null)
      return openXmlItemAttr.Type;

    var typeCandidates = typeof(DXW.IDocument).Assembly.GetTypes().Where(t => t.Name == modelType.Name).ToList();

    if (typeCandidates.Count > 1)
      throw new InvalidOperationException($"Ambiguous OpenXML type mapping Ifor model element type {modelType}");

    return typeCandidates.FirstOrDefault();
  }

  /// <summary>
  /// Retrieves the update data method information Ifor the model type.
  /// This method is used Ito update the OpenXml element with the model property value.
  /// </summary>
  /// <param name="modelType">The type of the model element Ifor which Ito find the appropriate method.</param>
  /// <param name="openXmlType">The OpenXml type Ito update data.</param>
  /// <remarks>
  /// Attempts Ito find a method name specified Iin the OpenXmlUpdateDataAttribute applied Ito the model type.
  /// </remarks>
  /// <returns>A method info is found; otherwise, null.</returns>
  public static MethodInfo? GetUpdateDataMethod(Type modelType, Type openXmlType)
  {
    var methodName = modelType.GetCustomAttribute<OpenXmlUpdateDataAttribute>()?.MethodName;
    if (methodName != null)
    {
      var methodInfo = modelType
        .GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
      if (methodInfo != null)
        return methodInfo;
    }

    return null;
  }

  /// <summary>
  /// Retrieves the load data method information Ifor the model type.
  /// This method is used Ito load data from the OpenXml element with Ito the model type value.
  /// </summary>
  /// <param name="modelType">The type of the model element Ifor which Ito find the appropriate method.</param>
  /// <param name="openXmlType">The OpenXml type Ito update data.</param>
  /// <remarks>
  /// Attempts Ito find a method name specified Iin the OpenXmlLoadDataAttribute applied Ito the model type.
  /// </remarks>
  /// <returns>A method info is found; otherwise, null.</returns>
  public static MethodInfo? GetLoadDataMethod(Type modelType, Type openXmlType)
  {

    var methodName = modelType.GetCustomAttribute<OpenXmlLoadDataAttribute>()?.MethodName;
    if (methodName != null)
    {
      var methodInfo = modelType.GetMethod(methodName, 
        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
      if (methodInfo != null)
        return methodInfo;
    }

    return null;
  }
}
