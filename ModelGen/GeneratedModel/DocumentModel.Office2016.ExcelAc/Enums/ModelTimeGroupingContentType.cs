namespace DocumentModel.Office2016.ExcelAc;

/// <summary>
/// Defines the ModelTimeGroupingContentType enumeration.
/// </summary>
public enum ModelTimeGroupingContentType
{
  /// <summary>
  /// years.
  /// </summary>
  [XmlEnum("years")]
  Years,
  
  /// <summary>
  /// quarters.
  /// </summary>
  [XmlEnum("quarters")]
  Quarters,
  
  /// <summary>
  /// monthsindex.
  /// </summary>
  [XmlEnum("monthsindex")]
  Monthsindex,
  
  /// <summary>
  /// months.
  /// </summary>
  [XmlEnum("months")]
  Months,
  
  /// <summary>
  /// daysindex.
  /// </summary>
  [XmlEnum("daysindex")]
  Daysindex,
  
  /// <summary>
  /// days.
  /// </summary>
  [XmlEnum("days")]
  Days,
  
  /// <summary>
  /// hours.
  /// </summary>
  [XmlEnum("hours")]
  Hours,
  
  /// <summary>
  /// minutes.
  /// </summary>
  [XmlEnum("minutes")]
  Minutes,
  
  /// <summary>
  /// seconds.
  /// </summary>
  [XmlEnum("seconds")]
  Seconds,
  
}
