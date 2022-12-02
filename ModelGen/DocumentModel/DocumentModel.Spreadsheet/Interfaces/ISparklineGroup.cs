namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SparklineGroup Class.
/// </summary>
public interface ISparklineGroup // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// manualMax, this property is only available in Office 2010 and later.
  /// </summary>
  public Double? ManualMax { get ; set; }
  
  /// <summary>
  /// manualMin, this property is only available in Office 2010 and later.
  /// </summary>
  public Double? ManualMin { get ; set; }
  
  /// <summary>
  /// lineWeight, this property is only available in Office 2010 and later.
  /// </summary>
  public Double? LineWeight { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public SparklineKind? Type { get ; set; }
  
  /// <summary>
  /// dateAxis, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DateAxis { get ; set; }
  
  /// <summary>
  /// displayEmptyCellsAs, this property is only available in Office 2010 and later.
  /// </summary>
  public DisplayBlanksAsKind? DisplayEmptyCellsAs { get ; set; }
  
  /// <summary>
  /// markers, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Markers { get ; set; }
  
  /// <summary>
  /// high, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? High { get ; set; }
  
  /// <summary>
  /// low, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Low { get ; set; }
  
  /// <summary>
  /// first, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? First { get ; set; }
  
  /// <summary>
  /// last, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Last { get ; set; }
  
  /// <summary>
  /// negative, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Negative { get ; set; }
  
  /// <summary>
  /// displayXAxis, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DisplayXAxis { get ; set; }
  
  /// <summary>
  /// displayHidden, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DisplayHidden { get ; set; }
  
  /// <summary>
  /// minAxisType, this property is only available in Office 2010 and later.
  /// </summary>
  public SparklineAxisMinMaxKind? MinAxisType { get ; set; }
  
  /// <summary>
  /// maxAxisType, this property is only available in Office 2010 and later.
  /// </summary>
  public SparklineAxisMinMaxKind? MaxAxisType { get ; set; }
  
  /// <summary>
  /// rightToLeft, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? RightToLeft { get ; set; }
  
  /// <summary>
  /// SeriesColor.
  /// </summary>
  public IColorType? SeriesColor { get ; set; }
  
  /// <summary>
  /// NegativeColor.
  /// </summary>
  public IColorType? NegativeColor { get ; set; }
  
  /// <summary>
  /// AxisColor.
  /// </summary>
  public IColorType? AxisColor { get ; set; }
  
  /// <summary>
  /// MarkersColor.
  /// </summary>
  public IColorType? MarkersColor { get ; set; }
  
  /// <summary>
  /// FirstMarkerColor.
  /// </summary>
  public IColorType? FirstMarkerColor { get ; set; }
  
  /// <summary>
  /// LastMarkerColor.
  /// </summary>
  public IColorType? LastMarkerColor { get ; set; }
  
  /// <summary>
  /// HighMarkerColor.
  /// </summary>
  public IColorType? HighMarkerColor { get ; set; }
  
  /// <summary>
  /// LowMarkerColor.
  /// </summary>
  public IColorType? LowMarkerColor { get ; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// Sparklines.
  /// </summary>
  public ISparklines? Sparklines { get ; set; }
  
}
