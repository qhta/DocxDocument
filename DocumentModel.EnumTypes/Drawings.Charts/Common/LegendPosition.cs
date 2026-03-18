namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LegendPosition enumeration.
/// Used in types such as Legend, LegendConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.LegendPositionValues))]
public enum LegendPosition
{
  /// <summary>
  ///   Bottom.
  /// </summary>
  [OpenXmlEnumValue("Bottom")]
  Bottom,
  /// <summary>
  ///   Top Right.
  /// </summary>
  [OpenXmlEnumValue("TopRight")]
  TopRight,
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
