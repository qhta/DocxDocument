namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SparklineGroup Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISeriesColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.INegativeColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IAxisColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IMarkersColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IFirstMarkerColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ILastMarkerColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IHighMarkerColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ILowMarkerColor))]
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IFormula))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISparklines))]
public class SparklineGroup: ISparklineGroup
{
  /// <summary>
  /// manualMax, this property is only available in Office 2010 and later.
  /// </summary>
  public double? ManualMax
  {
    get;
    set;
  }
  
  /// <summary>
  /// manualMin, this property is only available in Office 2010 and later.
  /// </summary>
  public double? ManualMin
  {
    get;
    set;
  }
  
  /// <summary>
  /// lineWeight, this property is only available in Office 2010 and later.
  /// </summary>
  public double? LineWeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public SparklineTypeValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// dateAxis, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? DateAxis
  {
    get;
    set;
  }
  
  /// <summary>
  /// displayEmptyCellsAs, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Excel.DisplayBlanksAsValues? DisplayEmptyCellsAs
  {
    get;
    set;
  }
  
  /// <summary>
  /// markers, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Markers
  {
    get;
    set;
  }
  
  /// <summary>
  /// high, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? High
  {
    get;
    set;
  }
  
  /// <summary>
  /// low, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Low
  {
    get;
    set;
  }
  
  /// <summary>
  /// first, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? First
  {
    get;
    set;
  }
  
  /// <summary>
  /// last, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Last
  {
    get;
    set;
  }
  
  /// <summary>
  /// negative, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Negative
  {
    get;
    set;
  }
  
  /// <summary>
  /// displayXAxis, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? DisplayXAxis
  {
    get;
    set;
  }
  
  /// <summary>
  /// displayHidden, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? DisplayHidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// minAxisType, this property is only available in Office 2010 and later.
  /// </summary>
  public SparklineAxisMinMaxValues? MinAxisType
  {
    get;
    set;
  }
  
  /// <summary>
  /// maxAxisType, this property is only available in Office 2010 and later.
  /// </summary>
  public SparklineAxisMinMaxValues? MaxAxisType
  {
    get;
    set;
  }
  
  /// <summary>
  /// rightToLeft, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? RightToLeft
  {
    get;
    set;
  }
  
  /// <summary>
  /// SeriesColor.
  /// </summary>
  public ISeriesColor? SeriesColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// NegativeColor.
  /// </summary>
  public INegativeColor? NegativeColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// AxisColor.
  /// </summary>
  public IAxisColor? AxisColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// MarkersColor.
  /// </summary>
  public IMarkersColor? MarkersColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// FirstMarkerColor.
  /// </summary>
  public IFirstMarkerColor? FirstMarkerColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// LastMarkerColor.
  /// </summary>
  public ILastMarkerColor? LastMarkerColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// HighMarkerColor.
  /// </summary>
  public IHighMarkerColor? HighMarkerColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// LowMarkerColor.
  /// </summary>
  public ILowMarkerColor? LowMarkerColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Office.Excel.IFormula? Formula
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sparklines.
  /// </summary>
  public ISparklines? Sparklines
  {
    get;
    set;
  }
  
}
