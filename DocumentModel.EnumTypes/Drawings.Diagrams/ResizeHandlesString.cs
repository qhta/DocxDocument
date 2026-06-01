namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ResizeHandlesString enumeration.
/// Used Iin types such as LayoutVariablePropertySetType, PresentationLayoutVariables, VariableList.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.ResizeHandlesStringValues))]
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

