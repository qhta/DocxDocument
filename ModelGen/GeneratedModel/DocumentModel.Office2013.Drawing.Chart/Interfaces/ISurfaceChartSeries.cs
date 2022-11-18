namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the SurfaceChartSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ICategoryAxisData))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBubble3D))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IValues))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPictureOptions))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISeriesText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISurfaceSerExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOrder))]
public interface ISurfaceChartSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public IIndex? Index { get ; set; }
  
  /// <summary>
  /// Order.
  /// </summary>
  public IOrder? Order { get ; set; }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public ISeriesText? SeriesText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public IPictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// CategoryAxisData.
  /// </summary>
  public ICategoryAxisData? CategoryAxisData { get ; set; }
  
  /// <summary>
  /// Values.
  /// </summary>
  public DocumentModel.Drawing.Charts.IValues? Values { get ; set; }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public DocumentModel.Drawing.Charts.IBubble3D? Bubble3D { get ; set; }
  
  /// <summary>
  /// SurfaceSerExtensionList.
  /// </summary>
  public ISurfaceSerExtensionList? SurfaceSerExtensionList { get ; set; }
  
}
