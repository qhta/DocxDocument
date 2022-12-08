namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public class DataLabel2Impl: ModelElementImpl, DataLabel2
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel?)_OpenXmlElement;
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
  
  public Boolean? Delete
  {
    get;
    set;
  }
  
  public Layout2? Layout
  {
    get;
    set;
  }
  
  public ChartText1? ChartText
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
  
  public DLblExtensionList? DLblExtensionList
  {
    get;
    set;
  }
  
}
