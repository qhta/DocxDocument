namespace DocumentModel.Drawings;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public class OfPieChartImpl: ModelElementImpl, OfPieChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.OfPieChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  public OfPieKind? OfPieType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieType>();
        return (OfPieKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.OfPieValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.OfPieType{ Val = (DocumentFormat.OpenXml.Drawing.Charts.OfPieValues?)value };
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
  
  public Collection<PieChartSeries1>? PieChartSerieses
  {
    get;
    set;
  }
  
  public DataLabels2? DataLabels
  {
    get;
    set;
  }
  
  public UInt16? GapWidth
  {
    get;
    set;
  }
  
  public SplitKind? SplitType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SplitType>();
        return (SplitKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SplitType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.SplitValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.SplitType{ Val = (DocumentFormat.OpenXml.Drawing.Charts.SplitValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Double? SplitPosition
  {
    get;
    set;
  }
  
  public CustomSplit? CustomSplit
  {
    get;
    set;
  }
  
  public UInt16? SecondPieSize
  {
    get;
    set;
  }
  
  public Collection<SeriesLines>? SeriesLineses
  {
    get;
    set;
  }
  
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
