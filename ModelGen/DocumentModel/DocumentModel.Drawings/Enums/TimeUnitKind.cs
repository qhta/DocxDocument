namespace DocumentModel.Drawings;

/// <summary>
/// Time Unit
/// </summary>
public enum TimeUnitKind
{
  /// <summary>
  /// Days.
  /// </summary>
  [XmlEnum("days")]
  Days,
  
  /// <summary>
  /// Months.
  /// </summary>
  [XmlEnum("months")]
  Months,
  
  /// <summary>
  /// Years.
  /// </summary>
  [XmlEnum("years")]
  Years,
  
}
