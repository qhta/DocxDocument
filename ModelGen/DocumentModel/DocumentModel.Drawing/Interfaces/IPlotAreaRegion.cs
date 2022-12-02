namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public interface IPlotAreaRegion // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public DocumentModel.Drawing.IPlotSurface? PlotSurface { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ISeries>? Serieses { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
