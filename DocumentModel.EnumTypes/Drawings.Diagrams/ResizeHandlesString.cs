namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ResizeHandlesString enumeration.
/// Used in types such as LayoutVariablePropertySetType, PresentationLayoutVariables, VariableList.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues))]
public enum ResizeHandlesString
{
  /// <summary>
  ///   Exact.
  /// </summary>
  [OpenXmlEnumValue("Exact")]
  Exact,
  /// <summary>
  ///   Relative.
  /// </summary>
  [OpenXmlEnumValue("Relative")]
  Relative
}

