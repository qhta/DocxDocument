namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DropStyleValues enumeration.
/// </summary>
public enum DropStyleKind
{
  /// <summary>
  /// combo.
  /// </summary>
  [XmlEnum("combo")]
  Combo,
  
  /// <summary>
  /// comboedit.
  /// </summary>
  [XmlEnum("comboedit")]
  ComboEdit,
  
  /// <summary>
  /// simple.
  /// </summary>
  [XmlEnum("simple")]
  Simple,
  
}
