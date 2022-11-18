namespace DocumentModel.Spreadsheet;

/// <summary>
/// Visibility Types
/// </summary>
public enum Visibility
{
  /// <summary>
  /// Visible.
  /// </summary>
  [XmlEnum("visible")]
  Visible,
  
  /// <summary>
  /// Hidden.
  /// </summary>
  [XmlEnum("hidden")]
  Hidden,
  
  /// <summary>
  /// Very Hidden.
  /// </summary>
  [XmlEnum("veryHidden")]
  VeryHidden,
  
}
