namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SelectionTypeValues enumeration.
/// </summary>
public enum SelectionKind
{
  /// <summary>
  /// single.
  /// </summary>
  [XmlEnum("single")]
  Single,
  
  /// <summary>
  /// multi.
  /// </summary>
  [XmlEnum("multi")]
  Multiple,
  
  /// <summary>
  /// extended.
  /// </summary>
  [XmlEnum("extended")]
  Extended,
  
}
