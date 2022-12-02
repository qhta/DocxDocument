namespace DocumentModel.Drawing;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public interface IOfPieChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  public DocumentModel.Drawing.OfPieKind? OfPieType { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IPieChartSeries>? PieChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public System.UInt16? GapWidth { get ; set; }
  
  public DocumentModel.Drawing.SplitKind? SplitType { get ; set; }
  
  public System.Double? SplitPosition { get ; set; }
  
  public DocumentModel.Drawing.ICustomSplit? CustomSplit { get ; set; }
  
  public System.UInt16? SecondPieSize { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ISeriesLines>? SeriesLineses { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
