namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the TickLabelPosition enumeration.
/// Used in types such as CategoryAxis, DateAxis, SeriesAxis.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.TickLabelPositionValues))]
public enum TickLabelPosition
{
  /// <summary>
  ///   High.
  /// </summary>
  [OpenXmlEnumValue("High")]
  High,
  /// <summary>
  ///   Low.
  /// </summary>
  [OpenXmlEnumValue("Low")]
  Low,
  /// <summary>
  ///   Next To.
  /// </summary>
  [OpenXmlEnumValue("NextTo")]
  NextTo,
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None
}
