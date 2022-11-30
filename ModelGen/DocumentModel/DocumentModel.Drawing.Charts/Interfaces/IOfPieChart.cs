namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public interface IOfPieChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  public DocumentModel.Drawing.Charts.OfPieKind? OfPieType { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IPieChartSeries>? PieChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public System.UInt16? GapWidth { get ; set; }
  
  public DocumentModel.Drawing.Charts.SplitKind? SplitType { get ; set; }
  
  public System.Double? SplitPosition { get ; set; }
  
  public DocumentModel.Drawing.Charts.ICustomSplit? CustomSplit { get ; set; }
  
  public System.UInt16? SecondPieSize { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ISeriesLines>? SeriesLineses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
