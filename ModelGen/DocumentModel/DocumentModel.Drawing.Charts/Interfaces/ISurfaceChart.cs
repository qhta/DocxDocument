namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Surface Charts.
/// </summary>
public interface ISurfaceChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public System.Boolean? Wireframe { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ISurfaceChartSeries>? SurfaceChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IBandFormats? BandFormats { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.Charts.ISurfaceChartExtensionList? SurfaceChartExtensionList { get ; set; }
  
}
