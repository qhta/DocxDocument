namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the PlotSurface Class.
/// </summary>
public interface IPlotSurface // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
