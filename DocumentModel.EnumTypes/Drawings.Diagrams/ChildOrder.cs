namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ChildOrder enumeration.
/// Used in types such as LayoutNode, LayoutNodeConverter.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues))]
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

