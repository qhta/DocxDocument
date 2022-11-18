namespace DocumentModel.Spreadsheet;

/// <summary>
/// Font scheme Styles
/// </summary>
public enum FontScheme
{
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Major Font.
  /// </summary>
  [XmlEnum("major")]
  Major,
  
  /// <summary>
  /// Minor Font.
  /// </summary>
  [XmlEnum("minor")]
  Minor,
  
}
