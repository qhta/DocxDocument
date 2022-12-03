namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ConditionalFormattingRule Class.
/// </summary>
public interface ConditionalFormattingRule // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public ConditionalFormatKind? Type { get ; set; }
  
  /// <summary>
  /// priority, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Priority { get ; set; }
  
  /// <summary>
  /// stopIfTrue, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? StopIfTrue { get ; set; }
  
  /// <summary>
  /// aboveAverage, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? AboveAverage { get ; set; }
  
  /// <summary>
  /// percent, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Percent { get ; set; }
  
  /// <summary>
  /// bottom, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Bottom { get ; set; }
  
  /// <summary>
  /// operator, this property is only available in Office 2010 and later.
  /// </summary>
  public ConditionalFormattingOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// text, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Text { get ; set; }
  
  /// <summary>
  /// timePeriod, this property is only available in Office 2010 and later.
  /// </summary>
  public TimePeriodKind? TimePeriod { get ; set; }
  
  /// <summary>
  /// rank, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? Rank { get ; set; }
  
  /// <summary>
  /// stdDev, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? StandardDeviation { get ; set; }
  
  /// <summary>
  /// equalAverage, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? EqualAverage { get ; set; }
  
  /// <summary>
  /// activePresent, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ActivePresent { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  public Collection<String>? Formulas { get ; set; }
  
  public ColorScale? ColorScale { get ; set; }
  
  public DataBar? DataBar { get ; set; }
  
  public IconSet? IconSet { get ; set; }
  
  public DifferentialType? DifferentialType { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
