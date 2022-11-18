namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Surface Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBandFormats))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IWireframe))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISurface3DChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISurfaceChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
public interface ISurface3DChart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public IWireframe? Wireframe { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
