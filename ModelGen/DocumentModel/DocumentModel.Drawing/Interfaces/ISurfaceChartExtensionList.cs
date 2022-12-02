namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SurfaceChartExtensionList Class.
/// </summary>
public interface ISurfaceChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ISurfaceChartExtension>? SurfaceChartExtensions { get ; set; }
  
}
