namespace DocumentModel.Drawings;

/// <summary>
/// Data Labels.
/// </summary>
public class DataLabels2Impl: ModelElementImpl, DataLabels2
{
  public DocumentFormat.OpenXml.Drawing.Charts.DataLabels? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DataLabels?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<DataLabel3>? Items
  {
    get;
    set;
  }
  
  public Boolean? Delete
  {
    get;
    set;
  }
  
  public NumberingFormat1? NumberingFormat
  {
    get;
    set;
  }
  
  public ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
  public TextProperties2? TextProperties
  {
    get;
    set;
  }
  
  public DataLabelPositionKind? DataLabelPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition>();
        return (DataLabelPositionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition{ Val = (DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Boolean? ShowLegendKey
  {
    get;
    set;
  }
  
  public Boolean? ShowValue
  {
    get;
    set;
  }
  
  public Boolean? ShowCategoryName
  {
    get;
    set;
  }
  
  public Boolean? ShowSeriesName
  {
    get;
    set;
  }
  
  public Boolean? ShowPercent
  {
    get;
    set;
  }
  
  public Boolean? ShowBubbleSize
  {
    get;
    set;
  }
  
  public String? Separator
  {
    get;
    set;
  }
  
  public Boolean? ShowLeaderLines
  {
    get;
    set;
  }
  
  public LeaderLines2? LeaderLines
  {
    get;
    set;
  }
  
  public DLblsExtensionList? DLblsExtensionList
  {
    get;
    set;
  }
  
}
