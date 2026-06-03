namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the HierarchyBranchStyle enumeration.
/// Used in types such as LayoutVariablePropertySetType, PresentationLayoutVariables, VariableList.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.HierarchyBranchStyleValues))]
public enum HierarchyBranchStyle
{
  /// <summary>
  ///   Left.
  /// </summary>
  [OpenXmlEnumValue("Left")]
  Left,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue("Right")]
  Right,
  /// <summary>
  ///   Hanging.
  /// </summary>
  [OpenXmlEnumValue("Hanging")]
  Hanging,
  /// <summary>
  ///   Standard.
  /// </summary>
  [OpenXmlEnumValue("Standard")]
  Standard,
  /// <summary>
  ///   Initial.
  /// </summary>
  [OpenXmlEnumValue("Initial")]
  Initial
}

