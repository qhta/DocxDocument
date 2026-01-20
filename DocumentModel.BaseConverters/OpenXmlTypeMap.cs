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
  /// <param name="modelType">The type of the model element for which to obtain the mapped OpenXML type. Cannot be null.</param>
  /// <remarks>Corresponding OpenXML types are determined by the OpenXmlTypeAttribute applied to model element types.</remarks>
  /// <returns>The OpenXML type that is mapped to the specified model element type, or null if not found.</returns>
  public static Type? GetOpenXmlTypeForModelType(Type modelType)
  {
    if (modelType.GetCustomAttribute<OpenXmlTypeAttribute>() is { } openXmlTypeAttr)
      return openXmlTypeAttr.Type;

    var openXmlItemAttrs = modelType.GetCustomAttributes<OpenXmlItemAttribute>().ToArray();
    if (openXmlItemAttrs.Length > 1)
      throw new InvalidOperationException($"Multiple OpenXML item type mappings for model element type {modelType}");

    var openXmlItemAttr = openXmlItemAttrs.FirstOrDefault();
    if (openXmlItemAttr is not null)
      return openXmlItemAttr.Type;

    var typeCandidates = typeof(DXW.Document).Assembly.GetTypes().Where(t => t.Name == modelType.Name).ToList();
    if (typeCandidates.Count == 1)
      return typeCandidates[0];

    if (typeCandidates.Count > 1)
      throw new InvalidOperationException($"Ambiguous OpenXML type mapping for model element type {modelType}");

    return null;
  }
}