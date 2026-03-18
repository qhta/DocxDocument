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
  ///   Best Fit.
  /// </summary>
  [OpenXmlEnumValue("BestFit")]
  BestFit,
  /// <summary>
  ///   Bottom.
  /// </summary>
  [OpenXmlEnumValue("Bottom")]
  Bottom,
  /// <summary>
  ///   Center.
  /// </summary>
  [OpenXmlEnumValue("Center")]
  Center,
  /// <summary>
  ///   Inside Base.
  /// </summary>
  [OpenXmlEnumValue("InsideBase")]
  InsideBase,
  /// <summary>
  ///   Inside End.
  /// </summary>
  [OpenXmlEnumValue("InsideEnd")]
  InsideEnd,
  /// <summary>
  ///   Left.
  /// </summary>
  [OpenXmlEnumValue("Left")]
  Left,
  /// <summary>
  ///   Outside End.
  /// </summary>
  [OpenXmlEnumValue("OutsideEnd")]
  OutsideEnd,
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
