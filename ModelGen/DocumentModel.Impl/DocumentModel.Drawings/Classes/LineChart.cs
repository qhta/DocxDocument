namespace DocumentModel.Drawings;

/// <summary>
/// Line Charts.
/// </summary>
public class LineChartImpl: ModelElementImpl, LineChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.LineChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LineChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Grouping.
  /// </summary>
  public GroupingKind? Grouping
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Grouping>();
        return (GroupingKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Grouping>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.GroupingValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.Grouping{ Val = (DocumentFormat.OpenXml.Drawing.Charts.GroupingValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors
  {
    get;
    set;
  }
  
  public Collection<LineChartSeries1>? LineChartSerieses
  {
    get;
    set;
  }
  
  public DataLabels2? DataLabels
  {
    get;
    set;
  }
  
  public DropLines? DropLines
  {
    get;
    set;
  }
  
  public HighLowLines? HighLowLines
  {
    get;
    set;
  }
  
  public UpDownBars? UpDownBars
  {
    get;
    set;
  }
  
  public Boolean? ShowMarker
  {
    get;
    set;
  }
  
  public Boolean? Smooth
  {
    get;
    set;
  }
  
  public Collection<UInt32>? AxisIds
  {
    get;
    set;
  }
  
  public LineChartExtensionList? LineChartExtensionList
  {
    get;
    set;
  }
  
}
