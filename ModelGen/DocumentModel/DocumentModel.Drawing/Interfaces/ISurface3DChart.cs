namespace DocumentModel.Drawing;

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
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ISurfaceChartSeries>? SurfaceChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IBandFormats? BandFormats { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.ISurface3DChartExtensionList? Surface3DChartExtensionList { get ; set; }
  
}
