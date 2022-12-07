namespace DocumentModel.Drawings;

/// <summary>
/// Bubble Charts.
/// </summary>
public class BubbleChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleChart>, BubbleChart
{
  public DataLabels1? DataLabels
  {
    get;
    set;
  }
  
  public SizeRepresentsKind? SizeRepresents
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresents>();
        return (SizeRepresentsKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresents>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.SizeRepresents{ Val = (DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public BubbleChartExtensionList? BubbleChartExtensionList
  {
    get;
    set;
  }
  
}
