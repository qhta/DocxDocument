namespace DocumentModel.Drawings;

/// <summary>
/// Bar Charts.
/// </summary>
public class BarChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.BarChart>, BarChart
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public BarDirectionKind? BarDirection
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarDirection>();
        return (BarDirectionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarDirection>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.BarDirection{ Val = (DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public BarGroupingKind? BarGrouping
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarGrouping>();
        return (BarGroupingKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarGrouping>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.BarGrouping{ Val = (DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues?)value };
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
  
  public BarChartExtensionList? BarChartExtensionList
  {
    get;
    set;
  }
  
}
