namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Formatting Rule.
/// </summary>
public interface IConditionalFormattingRule // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Type
  /// </summary>
  public DocumentModel.Spreadsheet.ConditionalFormatKind? Type { get ; set; }
  
  /// <summary>
  /// Differential Formatting Id
  /// </summary>
  public System.UInt32? FormatId { get ; set; }
  
  /// <summary>
  /// Priority
  /// </summary>
  public System.Int32? Priority { get ; set; }
  
  /// <summary>
  /// Stop If True
  /// </summary>
  public System.Boolean? StopIfTrue { get ; set; }
  
  /// <summary>
  /// Above Or Below Average
  /// </summary>
  public System.Boolean? AboveAverage { get ; set; }
  
  /// <summary>
  /// Top 10 Percent
  /// </summary>
  public System.Boolean? Percent { get ; set; }
  
  /// <summary>
  /// Bottom N
  /// </summary>
  public System.Boolean? Bottom { get ; set; }
  
  /// <summary>
  /// Operator
  /// </summary>
  public DocumentModel.Spreadsheet.ConditionalFormattingOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// Text
  /// </summary>
  public System.String? Text { get ; set; }
  
  /// <summary>
  /// Time Period
  /// </summary>
  public DocumentModel.Spreadsheet.TimePeriodKind? TimePeriod { get ; set; }
  
  /// <summary>
  /// Rank
  /// </summary>
  public System.UInt32? Rank { get ; set; }
  
  /// <summary>
  /// StdDev
  /// </summary>
  public System.Int32? StdDev { get ; set; }
  
  /// <summary>
  /// Equal Average
  /// </summary>
  public System.Boolean? EqualAverage { get ; set; }
  
}
