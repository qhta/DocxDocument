namespace DocumentModel.Drawings;

/// <summary>
/// Radar Charts.
/// </summary>
public class RadarChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.RadarChart>, RadarChart
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public RadarStyleKind? RadarStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarStyle>();
        return (RadarStyleKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarStyle>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.RadarStyle{ Val = (DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues?)value };
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
  
  public RadarChartExtensionList? RadarChartExtensionList
  {
    get;
    set;
  }
  
}
