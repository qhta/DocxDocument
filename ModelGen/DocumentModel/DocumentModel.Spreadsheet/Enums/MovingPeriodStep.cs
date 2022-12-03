namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MovingPeriodStep enumeration.
/// </summary>
public enum MovingPeriodStep
{
  /// <summary>
  /// year.
  /// </summary>
  [XmlEnum("year")]
  Year,
  
  /// <summary>
  /// quarter.
  /// </summary>
  [XmlEnum("quarter")]
  Quarter,
  
  /// <summary>
  /// month.
  /// </summary>
  [XmlEnum("month")]
  Month,
  
  /// <summary>
  /// week.
  /// </summary>
  [XmlEnum("week")]
  Week,
  
  /// <summary>
  /// day.
  /// </summary>
  [XmlEnum("day")]
  Day,
  
}
