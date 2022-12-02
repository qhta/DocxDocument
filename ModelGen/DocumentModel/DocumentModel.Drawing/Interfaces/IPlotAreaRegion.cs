namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public interface IPlotAreaRegion // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public IPlotSurface? PlotSurface { get ; set; }
  
  public Collection<ISeries>? Serieses { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
