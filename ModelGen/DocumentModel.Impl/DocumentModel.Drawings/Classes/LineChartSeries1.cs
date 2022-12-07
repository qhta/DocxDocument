namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineChartSeries Class.
/// </summary>
public class LineChartSeries1Impl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>, LineChartSeries1
{
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
  
  public DataLabels1? DataLabels
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
  
  public LineSerExtensionList? LineSerExtensionList
  {
    get;
    set;
  }
  
}
