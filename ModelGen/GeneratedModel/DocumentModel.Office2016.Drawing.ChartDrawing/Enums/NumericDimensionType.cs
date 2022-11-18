namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the NumericDimensionType enumeration.
/// </summary>
public enum NumericDimensionType
{
  /// <summary>
  /// val.
  /// </summary>
  [XmlEnum("val")]
  Val,
  
  /// <summary>
  /// x.
  /// </summary>
  [XmlEnum("x")]
  X,
  
  /// <summary>
  /// y.
  /// </summary>
  [XmlEnum("y")]
  Y,
  
  /// <summary>
  /// size.
  /// </summary>
  [XmlEnum("size")]
  Size,
  
  /// <summary>
  /// colorVal.
  /// </summary>
  [XmlEnum("colorVal")]
  ColorVal,
  
}
