namespace DocumentModel.Spreadsheet;

/// <summary>
/// Values Group By
/// </summary>
public enum GroupBy
{
  /// <summary>
  /// Group By Numeric Ranges.
  /// </summary>
  [XmlEnum("range")]
  Range,
  
  /// <summary>
  /// Seconds.
  /// </summary>
  [XmlEnum("seconds")]
  Seconds,
  
  /// <summary>
  /// Minutes.
  /// </summary>
  [XmlEnum("minutes")]
  Minutes,
  
  /// <summary>
  /// Hours.
  /// </summary>
  [XmlEnum("hours")]
  Hours,
  
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
  /// Quarters.
  /// </summary>
  [XmlEnum("quarters")]
  Quarters,
  
  /// <summary>
  /// Years.
  /// </summary>
  [XmlEnum("years")]
  Years,
  
}
