namespace DocumentModel.Drawings;

/// <summary>
/// Pie Chart Series.
/// </summary>
public class PieChartSeries1Impl: ModelElementImpl, PieChartSeries1
{
  public DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries?)_OpenXmlElement;
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
  /// Explosion.
  /// </summary>
  public UInt32? Explosion
  {
    get;
    set;
  }
  
  public Collection<DataPoint2>? DataPoints
  {
    get;
    set;
  }
  
  public DataLabels2? DataLabels
  {
    get;
    set;
  }
  
  public CategoryAxisData? CategoryAxisData
  {
    get;
    set;
  }
  
  public Values? Values
  {
    get;
    set;
  }
  
  public PieSerExtensionList? PieSerExtensionList
  {
    get;
    set;
  }
  
}
