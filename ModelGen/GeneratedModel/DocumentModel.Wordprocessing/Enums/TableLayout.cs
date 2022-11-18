namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableLayoutValues enumeration.
/// </summary>
public enum TableLayout
{
  /// <summary>
  /// Fixed Width Table Layout.
  /// </summary>
  [XmlEnum("fixed")]
  Fixed,
  
  /// <summary>
  /// AutoFit Table Layout.
  /// </summary>
  [XmlEnum("autofit")]
  Autofit,
  
}
