namespace DocumentModel.Drawings;

/// <summary>
/// Data Label.
/// </summary>
public class DataLabel2Impl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabel>, DataLabel2
{
  public Layout1? Layout
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
  
  public TextProperties1? TextProperties
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
  
  public DLblExtensionList? DLblExtensionList
  {
    get;
    set;
  }
  
}
