namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public interface IChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ChartTitle.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IChartTitle? ChartTitle { get ; set; }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IPlotArea? PlotArea { get ; set; }
  
  /// <summary>
  /// Legend.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.ILegend? Legend { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
