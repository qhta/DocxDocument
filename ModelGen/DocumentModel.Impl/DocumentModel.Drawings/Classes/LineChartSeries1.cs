namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineChartSeries Class.
/// </summary>
public class LineChartSeries1Impl: ModelElementImpl, LineChartSeries1
{
  public DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries?)_OpenXmlElement;
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
  /// Marker.
  /// </summary>
  public Marker1? Marker
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
  
  public Collection<Trendline>? Trendlines
  {
    get;
    set;
  }
  
  public ErrorBars? ErrorBars
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
  
  public Boolean? Smooth
  {
    get;
    set;
  }
  
  public LineSerExtensionList? LineSerExtensionList
  {
    get;
    set;
  }
  
}
