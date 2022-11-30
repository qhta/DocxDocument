namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormattingRule Class.
/// </summary>
public interface IConditionalFormattingRule // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.ConditionalFormatKind? Type { get ; set; }
  
  /// <summary>
  /// priority, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Priority { get ; set; }
  
  /// <summary>
  /// stopIfTrue, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? StopIfTrue { get ; set; }
  
  /// <summary>
  /// aboveAverage, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? AboveAverage { get ; set; }
  
  /// <summary>
  /// percent, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Percent { get ; set; }
  
  /// <summary>
  /// bottom, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Bottom { get ; set; }
  
  /// <summary>
  /// operator, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.ConditionalFormattingOperatorKind? Operator { get ; set; }
  
  /// <summary>
  /// text, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Text { get ; set; }
  
  /// <summary>
  /// timePeriod, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.TimePeriodKind? TimePeriod { get ; set; }
  
  /// <summary>
  /// rank, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Rank { get ; set; }
  
  /// <summary>
  /// stdDev, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? StandardDeviation { get ; set; }
  
  /// <summary>
  /// equalAverage, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? EqualAverage { get ; set; }
  
  /// <summary>
  /// activePresent, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? ActivePresent { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.String>? Formulas { get ; set; }
  
  public DocumentModel.Office2010.Excel.IColorScale? ColorScale { get ; set; }
  
  public DocumentModel.Office2010.Excel.IDataBar? DataBar { get ; set; }
  
  public DocumentModel.Office2010.Excel.IIconSet? IconSet { get ; set; }
  
  public DocumentModel.Office2010.Excel.IDifferentialType? DifferentialType { get ; set; }
  
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
