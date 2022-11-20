namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IInvertIfNegative))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBubble3D))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMarker))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPictureOptions))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExplosion))]
public interface IDataPoint // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public IIndex? Index { get ; set; }
  
  /// <summary>
  /// Invert if Negative.
  /// </summary>
  public IInvertIfNegative? InvertIfNegative { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawing.Charts.IMarker? Marker { get ; set; }
  
  /// <summary>
  /// 3D Bubble.
  /// </summary>
  public DocumentModel.Drawing.Charts.IBubble3D? Bubble3D { get ; set; }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExplosion? Explosion { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public IPictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
