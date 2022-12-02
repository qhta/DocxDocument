namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SparklineGroup Class.
/// </summary>
public interface ISparklineGroup // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// manualMax, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Double? ManualMax { get ; set; }
  
  /// <summary>
  /// manualMin, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Double? ManualMin { get ; set; }
  
  /// <summary>
  /// lineWeight, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Double? LineWeight { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.SparklineKind? Type { get ; set; }
  
  /// <summary>
  /// dateAxis, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? DateAxis { get ; set; }
  
  /// <summary>
  /// displayEmptyCellsAs, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.DisplayBlanksAsKind? DisplayEmptyCellsAs { get ; set; }
  
  /// <summary>
  /// markers, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Markers { get ; set; }
  
  /// <summary>
  /// high, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? High { get ; set; }
  
  /// <summary>
  /// low, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Low { get ; set; }
  
  /// <summary>
  /// first, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? First { get ; set; }
  
  /// <summary>
  /// last, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Last { get ; set; }
  
  /// <summary>
  /// negative, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Negative { get ; set; }
  
  /// <summary>
  /// displayXAxis, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? DisplayXAxis { get ; set; }
  
  /// <summary>
  /// displayHidden, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? DisplayHidden { get ; set; }
  
  /// <summary>
  /// minAxisType, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.SparklineAxisMinMaxKind? MinAxisType { get ; set; }
  
  /// <summary>
  /// maxAxisType, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.SparklineAxisMinMaxKind? MaxAxisType { get ; set; }
  
  /// <summary>
  /// rightToLeft, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? RightToLeft { get ; set; }
  
  /// <summary>
  /// SeriesColor.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? SeriesColor { get ; set; }
  
  /// <summary>
  /// NegativeColor.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? NegativeColor { get ; set; }
  
  /// <summary>
  /// AxisColor.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? AxisColor { get ; set; }
  
  /// <summary>
  /// MarkersColor.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? MarkersColor { get ; set; }
  
  /// <summary>
  /// FirstMarkerColor.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? FirstMarkerColor { get ; set; }
  
  /// <summary>
  /// LastMarkerColor.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? LastMarkerColor { get ; set; }
  
  /// <summary>
  /// HighMarkerColor.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? HighMarkerColor { get ; set; }
  
  /// <summary>
  /// LowMarkerColor.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? LowMarkerColor { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public System.String? Formula { get ; set; }
  
  /// <summary>
  /// Sparklines.
  /// </summary>
  public DocumentModel.Spreadsheet.ISparklines? Sparklines { get ; set; }
  
}
