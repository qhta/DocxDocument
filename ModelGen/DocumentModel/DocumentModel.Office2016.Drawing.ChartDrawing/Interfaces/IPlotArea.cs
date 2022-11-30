namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
public interface IPlotArea // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PlotAreaRegion.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IPlotAreaRegion? PlotAreaRegion { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2016.Drawing.ChartDrawing.IAxis>? Axises { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
