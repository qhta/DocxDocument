namespace DocumentModel.Drawing;

/// <summary>
/// Surface Charts.
/// </summary>
public interface ISurfaceChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public System.Boolean? Wireframe { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ISurfaceChartSeries>? SurfaceChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IBandFormats? BandFormats { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.ISurfaceChartExtensionList? SurfaceChartExtensionList { get ; set; }
  
}
