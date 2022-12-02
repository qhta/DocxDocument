namespace DocumentModel.Drawing;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public interface IOfPieChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  public OfPieKind? OfPieType { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<IPieChartSeries>? PieChartSerieses { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public UInt16? GapWidth { get ; set; }
  
  public SplitKind? SplitType { get ; set; }
  
  public Double? SplitPosition { get ; set; }
  
  public ICustomSplit? CustomSplit { get ; set; }
  
  public UInt16? SecondPieSize { get ; set; }
  
  public Collection<ISeriesLines>? SeriesLineses { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
