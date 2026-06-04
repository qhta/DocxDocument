namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the AxisPosition enumeration.
/// Used in types such as CategoryAxis, DateAxis, SeriesAxis.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues))]
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

