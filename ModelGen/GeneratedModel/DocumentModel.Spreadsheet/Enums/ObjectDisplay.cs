namespace DocumentModel.Spreadsheet;

/// <summary>
/// Object Display Types
/// </summary>
public enum ObjectDisplay
{
  /// <summary>
  /// All.
  /// </summary>
  [XmlEnum("all")]
  All,
  
  /// <summary>
  /// Show Placeholders.
  /// </summary>
  [XmlEnum("placeholders")]
  Placeholders,
  
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
