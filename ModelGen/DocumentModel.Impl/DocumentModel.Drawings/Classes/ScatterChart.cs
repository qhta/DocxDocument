namespace DocumentModel.Drawings;

/// <summary>
/// Scatter Charts.
/// </summary>
public class ScatterChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterChart>, ScatterChart
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public ScatterStyleKind? ScatterStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyle>();
        return (ScatterStyleKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyle>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.ScatterStyle{ Val = (DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public DataLabels1? DataLabels
  {
    get;
    set;
  }
  
  public ScatterChartExtensionList? ScatterChartExtensionList
  {
    get;
    set;
  }
  
}
