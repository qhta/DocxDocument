namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScatterChartSeries Class.
/// </summary>
public class ScatterChartSeries1Impl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries>, ScatterChartSeries1
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
  
  public DataLabels1? DataLabels
  {
    get;
    set;
  }
  
  public XValues? XValues
  {
    get;
    set;
  }
  
  public YValues? YValues
  {
    get;
    set;
  }
  
  public ScatterSerExtensionList? ScatterSerExtensionList
  {
    get;
    set;
  }
  
}
