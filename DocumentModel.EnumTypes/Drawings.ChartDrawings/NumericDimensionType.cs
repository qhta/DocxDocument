namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericDimensionType enumeration.
/// Used in types such as NumericDimension, NumericDimensionType, NumericDimensionConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum NumericDimensionType
{
  /// <summary>
  ///   val.
  /// </summary>
  [OpenXmlEnumValue("Val")]
  Val,
  /// <summary>
  ///   x.
  /// </summary>
  [OpenXmlEnumValue("X")]
  X,
  /// <summary>
  ///   y.
  /// </summary>
  [OpenXmlEnumValue("Y")]
  Y,
  /// <summary>
  ///   size.
  /// </summary>
  [OpenXmlEnumValue("Size")]
  Size,
  /// <summary>
  ///   colorVal.
  /// </summary>
  [OpenXmlEnumValue("ColorVal")]
  ColorVal
}
