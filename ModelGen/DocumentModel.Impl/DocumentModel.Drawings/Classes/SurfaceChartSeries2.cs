namespace DocumentModel.Drawings;

/// <summary>
/// Surface Chart Series.
/// </summary>
public class SurfaceChartSeries2Impl: ModelElementImpl, SurfaceChartSeries2
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  public UInt32? Order
  {
    get;
    set;
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public SeriesText? SeriesText
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public PictureOptions? PictureOptions
  {
    get;
    set;
  }
  
  /// <summary>
  /// CategoryAxisData.
  /// </summary>
  public CategoryAxisData? CategoryAxisData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Values.
  /// </summary>
  public Values? Values
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public Boolean? Bubble3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// SurfaceSerExtensionList.
  /// </summary>
  public SurfaceSerExtensionList? SurfaceSerExtensionList
  {
    get;
    set;
  }
  
}
