namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the AxisPosition enumeration.
/// Used in types such as CategoryAxis, DateAxis, SeriesAxis.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.AxisPositionValues))]
public enum AxisPosition
{
  /// <summary>
  ///   Bottom.
  /// </summary>
  [OpenXmlEnumValue("Bottom")]
  Bottom,
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
  ///   Top.
  /// </summary>
  [OpenXmlEnumValue("Top")]
  Top
}
