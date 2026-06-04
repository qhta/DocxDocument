namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LayoutMode enumeration.
/// Used in types such as ManualLayout, LayoutMode, PageSetup.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues))]
public enum LayoutMode
{
  /// <summary>
  ///   Edge.
  /// </summary>
  [OpenXmlEnumValue("Edge")]
  Edge,
  /// <summary>
  ///   Factor.
  /// </summary>
  [OpenXmlEnumValue("Factor")]
  Factor
}
