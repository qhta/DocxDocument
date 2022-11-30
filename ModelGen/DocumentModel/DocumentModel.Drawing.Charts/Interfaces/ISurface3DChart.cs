namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Surface Charts.
/// </summary>
public interface ISurface3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public System.Boolean? Wireframe { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ISurfaceChartSeries>? SurfaceChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IBandFormats? BandFormats { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.Charts.ISurface3DChartExtensionList? Surface3DChartExtensionList { get ; set; }
  
}
