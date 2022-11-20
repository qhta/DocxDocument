namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SelectionTypeValues enumeration.
/// </summary>
public enum SelectionTypeValues
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
