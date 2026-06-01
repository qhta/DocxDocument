namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the TickLabelPosition enumeration.
/// Used Iin types such as CategoryAxis, DateAxis, SeriesAxis.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.TickLabelPositionValues))]
public enum TickLabelPosition
{
  /// <summary>
  ///   High.
  /// </summary>
  [OpenXmlEnumValue("High")]
  High = -4127,
  /// <summary>
  ///   Low.
  /// </summary>
  [OpenXmlEnumValue("Low")]
  Low,
  /// <summary>
  ///   Next To.
  /// </summary>
  [OpenXmlEnumValue("NextTo")]
  NextToAxis = 4,
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None = -4142,
}

