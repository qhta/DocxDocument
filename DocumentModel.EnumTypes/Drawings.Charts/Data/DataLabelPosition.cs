namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DataLabelPosition enumeration.
/// Used in types such as DataLabel, DataLabel3, DataLabels.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.DataLabelPositionValues))]
public enum DataLabelPosition
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  ///   Office application controls position of data label.
  /// </summary>
  [OpenXmlEnumValue("BestFit")]
  BestFit = 5,
  /// <summary>
  ///    Data label positioned below point.
  /// </summary>
  [OpenXmlEnumValue("Bottom")]
  Below = 1,
  /// <summary>
  ///   Data label centered on data point or inside bar or pie.
  /// </summary>
  [OpenXmlEnumValue("Center")]
  Center = -4108,
  /// <summary>
  ///   Inside Base.
  /// </summary>
  [OpenXmlEnumValue("InsideBase")]
  InsideBase = 4,
  /// <summary>
  ///   Inside End.
  /// </summary>
  [OpenXmlEnumValue("InsideEnd")]
  InsideEnd = 3,
  /// <summary>
  ///   Left.
  /// </summary>
  [OpenXmlEnumValue("Left")]
  Left = -4131,
  /// <summary>
  ///   Outside End.
  /// </summary>
  [OpenXmlEnumValue("OutsideEnd")]
  OutsideEnd = 2,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue("Right")]
  Right = -4152,
  /// <summary>
  ///    Data label positioned above point.
  /// </summary>
  [OpenXmlEnumValue("Top")]
  Above = 0,
  /// <summary>
  /// Data label centered on data point or inside bar or pie.
  /// </summary>
  Custom = 7
}
