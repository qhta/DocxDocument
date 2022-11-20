namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Visibility Types
/// </summary>
public enum SheetStateValues
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
