namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ConditionalFormattingRule Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IDifferentialType))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IFormula))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IColorScale))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IDataBar))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IIconSet))]
public interface IConditionalFormattingRule // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public ConditionalFormat? Type { get ; set; }
  
  /// <summary>
  /// priority, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Priority { get ; set; }
  
  /// <summary>
  /// stopIfTrue, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? StopIfTrue { get ; set; }
  
  /// <summary>
  /// aboveAverage, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? AboveAverage { get ; set; }
  
  /// <summary>
  /// percent, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Percent { get ; set; }
  
  /// <summary>
  /// bottom, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Bottom { get ; set; }
  
  /// <summary>
  /// operator, this property is only available in Office 2010 and later.
  /// </summary>
  public ConditionalFormattingOperator? Operator { get ; set; }
  
  /// <summary>
  /// text, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Text { get ; set; }
  
  /// <summary>
  /// timePeriod, this property is only available in Office 2010 and later.
  /// </summary>
  public TimePeriod? TimePeriod { get ; set; }
  
  /// <summary>
  /// rank, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Rank { get ; set; }
  
  /// <summary>
  /// stdDev, this property is only available in Office 2010 and later.
  /// </summary>
  public int? StandardDeviation { get ; set; }
  
  /// <summary>
  /// equalAverage, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? EqualAverage { get ; set; }
  
  /// <summary>
  /// activePresent, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ActivePresent { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get ; set; }
  
}
