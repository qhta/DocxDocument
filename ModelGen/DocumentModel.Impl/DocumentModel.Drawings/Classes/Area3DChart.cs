namespace DocumentModel.Drawings;

/// <summary>
/// 3D Area Charts.
/// </summary>
public class Area3DChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.Area3DChart>, Area3DChart
{
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
  
  public DataLabels1? DataLabels
  {
    get;
    set;
  }
  
  public DropLines? DropLines
  {
    get;
    set;
  }
  
  public Area3DChartExtensionList? Area3DChartExtensionList
  {
    get;
    set;
  }
  
}
