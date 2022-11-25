namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Format Type
/// </summary>
public enum ConditionalFormatKind
{
  /// <summary>
  /// Expression.
  /// </summary>
  Expression,
  
  /// <summary>
  /// Cell Is.
  /// </summary>
  CellIs,
  
  /// <summary>
  /// Color Scale.
  /// </summary>
  ColorScale,
  
  /// <summary>
  /// Data Bar.
  /// </summary>
  DataBar,
  
  /// <summary>
  /// Icon Set.
  /// </summary>
  IconSet,
  
  /// <summary>
  /// Top 10.
  /// </summary>
  Top10,
  
  /// <summary>
  /// Unique Values.
  /// </summary>
  UniqueValues,
  
  /// <summary>
  /// Duplicate Values.
  /// </summary>
  DuplicateValues,
  
  /// <summary>
  /// Contains Text.
  /// </summary>
  ContainsText,
  
  /// <summary>
  /// Does Not Contain Text.
  /// </summary>
  NotContainsText,
  
  /// <summary>
  /// Begins With.
  /// </summary>
  BeginsWith,
  
  /// <summary>
  /// Ends With.
  /// </summary>
  EndsWith,
  
  /// <summary>
  /// Contains Blanks.
  /// </summary>
  ContainsBlanks,
  
  /// <summary>
  /// Contains No Blanks.
  /// </summary>
  NotContainsBlanks,
  
  /// <summary>
  /// Contains Errors.
  /// </summary>
  ContainsErrors,
  
  /// <summary>
  /// Contains No Errors.
  /// </summary>
  NotContainsErrors,
  
  /// <summary>
  /// Time Period.
  /// </summary>
  TimePeriod,
  
  /// <summary>
  /// Above or Below Average.
  /// </summary>
  AboveAverage,
  
}
