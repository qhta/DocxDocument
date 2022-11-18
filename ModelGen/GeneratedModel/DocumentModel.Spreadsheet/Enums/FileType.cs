namespace DocumentModel.Spreadsheet;

/// <summary>
/// File Type
/// </summary>
public enum FileType
{
  /// <summary>
  /// Macintosh.
  /// </summary>
  [XmlEnum("mac")]
  Mac,
  
  /// <summary>
  /// Windows (ANSI).
  /// </summary>
  [XmlEnum("win")]
  Win,
  
  /// <summary>
  /// DOS.
  /// </summary>
  [XmlEnum("dos")]
  Dos,
  
}
