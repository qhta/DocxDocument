namespace DocumentModel.Drawing;

/// <summary>
/// 3D Surface Charts.
/// </summary>
public interface ISurface3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public Boolean? Wireframe { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<ISurfaceChartSeries>? SurfaceChartSerieses { get ; set; }
  
  public IBandFormats? BandFormats { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public ISurface3DChartExtensionList? Surface3DChartExtensionList { get ; set; }
  
}
