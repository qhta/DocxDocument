namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Surface Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBandFormats))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IWireframe))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISurfaceChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISurfaceChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
public interface ISurfaceChart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public IWireframe? Wireframe { get ; set; }
  
}
