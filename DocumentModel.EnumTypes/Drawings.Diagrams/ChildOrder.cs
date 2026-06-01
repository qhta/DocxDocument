namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ChildOrder enumeration.
/// Used Iin types such as LayoutNode, LayoutNodeConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.ChildOrderValues))]
public enum ChildOrder
{
  /// <summary>
  ///   Bottom.
  /// </summary>
  [OpenXmlEnumValue("Bottom")]
  Bottom,
  /// <summary>
  ///   Top.
  /// </summary>
  [OpenXmlEnumValue("Top")]
  Top
}

