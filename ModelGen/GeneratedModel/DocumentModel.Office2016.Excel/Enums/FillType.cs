namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the FillType enumeration.
/// </summary>
public enum FillType
{
  /// <summary>
  /// fill.
  /// </summary>
  [XmlEnum("fill")]
  Fill,
  
  /// <summary>
  /// array.
  /// </summary>
  [XmlEnum("array")]
  Array,
  
  /// <summary>
  /// future.
  /// </summary>
  [XmlEnum("future")]
  Future,
  
}
