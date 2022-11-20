namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Formatting Rule.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IConditionalFormattingRuleExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColorScale))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDataBar))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IIconSet))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFormula))]
public interface IConditionalFormattingRule // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Type
  /// </summary>
  public ConditionalFormatValues? Type { get ; set; }
  
  /// <summary>
  /// Differential Formatting Id
  /// </summary>
  public uint? FormatId { get ; set; }
  
  /// <summary>
  /// Priority
  /// </summary>
  public int? Priority { get ; set; }
  
  /// <summary>
  /// Stop If True
  /// </summary>
  public bool? StopIfTrue { get ; set; }
  
  /// <summary>
  /// Above Or Below Average
  /// </summary>
  public bool? AboveAverage { get ; set; }
  
  /// <summary>
  /// Top 10 Percent
  /// </summary>
  public bool? Percent { get ; set; }
  
  /// <summary>
  /// Bottom N
  /// </summary>
  public bool? Bottom { get ; set; }
  
  /// <summary>
  /// Operator
  /// </summary>
  public ConditionalFormattingOperatorValues? Operator { get ; set; }
  
  /// <summary>
  /// Text
  /// </summary>
  public string? Text { get ; set; }
  
  /// <summary>
  /// Time Period
  /// </summary>
  public TimePeriodValues? TimePeriod { get ; set; }
  
  /// <summary>
  /// Rank
  /// </summary>
  public uint? Rank { get ; set; }
  
  /// <summary>
  /// StdDev
  /// </summary>
  public int? StdDev { get ; set; }
  
  /// <summary>
  /// Equal Average
  /// </summary>
  public bool? EqualAverage { get ; set; }
  
}
