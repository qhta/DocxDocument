namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Visibility Types
/// </summary>
public enum SheetState
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
