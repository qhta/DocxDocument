namespace DocumentModel.Drawings;

/// <summary>
/// Legend data and formatting.
/// </summary>
public class Legend1Impl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.Legend>, Legend1
{
  /// <summary>
  /// Legend Position.
  /// </summary>
  public LegendPositionKind? LegendPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LegendPosition>();
        return (LegendPositionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LegendPosition>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.LegendPosition{ Val = (DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Layout1? Layout
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
  
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
