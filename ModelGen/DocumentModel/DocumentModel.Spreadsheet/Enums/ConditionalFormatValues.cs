namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Format Type
/// </summary>
public enum ConditionalFormatValues
{
  /// <summary>
  /// Expression.
  /// </summary>
  [XmlEnum("expression")]
  Expression,
  
  /// <summary>
  /// Cell Is.
  /// </summary>
  [XmlEnum("cellIs")]
  CellIs,
  
  /// <summary>
  /// Color Scale.
  /// </summary>
  [XmlEnum("colorScale")]
  ColorScale,
  
  /// <summary>
  /// Data Bar.
  /// </summary>
  [XmlEnum("dataBar")]
  DataBar,
  
  /// <summary>
  /// Icon Set.
  /// </summary>
  [XmlEnum("iconSet")]
  IconSet,
  
  /// <summary>
  /// Top 10.
  /// </summary>
  [XmlEnum("top10")]
  Top10,
  
  /// <summary>
  /// Unique Values.
  /// </summary>
  [XmlEnum("uniqueValues")]
  UniqueValues,
  
  /// <summary>
  /// Duplicate Values.
  /// </summary>
  [XmlEnum("duplicateValues")]
  DuplicateValues,
  
  /// <summary>
  /// Contains Text.
  /// </summary>
  [XmlEnum("containsText")]
  ContainsText,
  
  /// <summary>
  /// Does Not Contain Text.
  /// </summary>
  [XmlEnum("notContainsText")]
  NotContainsText,
  
  /// <summary>
  /// Begins With.
  /// </summary>
  [XmlEnum("beginsWith")]
  BeginsWith,
  
  /// <summary>
  /// Ends With.
  /// </summary>
  [XmlEnum("endsWith")]
  EndsWith,
  
  /// <summary>
  /// Contains Blanks.
  /// </summary>
  [XmlEnum("containsBlanks")]
  ContainsBlanks,
  
  /// <summary>
  /// Contains No Blanks.
  /// </summary>
  [XmlEnum("notContainsBlanks")]
  NotContainsBlanks,
  
  /// <summary>
  /// Contains Errors.
  /// </summary>
  [XmlEnum("containsErrors")]
  ContainsErrors,
  
  /// <summary>
  /// Contains No Errors.
  /// </summary>
  [XmlEnum("notContainsErrors")]
  NotContainsErrors,
  
  /// <summary>
  /// Time Period.
  /// </summary>
  [XmlEnum("timePeriod")]
  TimePeriod,
  
  /// <summary>
  /// Above or Below Average.
  /// </summary>
  [XmlEnum("aboveAverage")]
  AboveAverage,
  
}
