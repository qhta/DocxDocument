namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the SurfaceChartExtensionList Class.
/// </summary>
public interface ISurfaceChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ISurfaceChartExtension>? SurfaceChartExtensions { get ; set; }
  
}
