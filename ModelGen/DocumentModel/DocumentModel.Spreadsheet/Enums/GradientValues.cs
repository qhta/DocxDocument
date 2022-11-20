namespace DocumentModel.Spreadsheet;

/// <summary>
/// Gradient Type
/// </summary>
public enum GradientValues
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
