namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DropStyleValues enumeration.
/// </summary>
public enum DropStyle
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
