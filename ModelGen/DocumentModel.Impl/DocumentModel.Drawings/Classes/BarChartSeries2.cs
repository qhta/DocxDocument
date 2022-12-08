namespace DocumentModel.Drawings;

/// <summary>
/// Bar Chart Series.
/// </summary>
public class BarChartSeries2Impl: ModelElementImpl, BarChartSeries2
{
  public DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries?)_OpenXmlElement;
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
  /// InvertIfNegative.
  /// </summary>
  public Boolean? InvertIfNegative
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
  
  public ShapeKind1? Shape
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Shape>();
        return (ShapeKind1?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Shape>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.ShapeValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.Shape{ Val = (DocumentFormat.OpenXml.Drawing.Charts.ShapeValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public BarSerExtensionList? BarSerExtensionList
  {
    get;
    set;
  }
  
}
