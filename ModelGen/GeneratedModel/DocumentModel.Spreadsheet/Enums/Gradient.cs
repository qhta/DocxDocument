namespace DocumentModel.Spreadsheet;

/// <summary>
/// Gradient Type
/// </summary>
public enum Gradient
{
  /// <summary>
  /// Linear Gradient.
  /// </summary>
  [XmlEnum("linear")]
  Linear,
  
  /// <summary>
  /// Path.
  /// </summary>
  [XmlEnum("path")]
  Path,
  
}
