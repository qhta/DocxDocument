namespace DocumentModel.Drawing;

/// <summary>
/// Surface Charts.
/// </summary>
public interface ISurfaceChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public Boolean? Wireframe { get ; set; }
  
  public Collection<ISurfaceChartSeries>? SurfaceChartSerieses { get ; set; }
  
  public IBandFormats? BandFormats { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public ISurfaceChartExtensionList? SurfaceChartExtensionList { get ; set; }
  
}
