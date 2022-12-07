namespace DocumentModel.Drawings;

/// <summary>
/// 3D Bar Charts.
/// </summary>
public class Bar3DChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart>, Bar3DChart
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
  
  public ShapeKind2? Shape
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Shape>();
        return (ShapeKind2?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Shape>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.ShapeValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.Shape{ Val = (DocumentFormat.OpenXml.Drawing.Charts.ShapeValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Bar3DChartExtensionList? Bar3DChartExtensionList
  {
    get;
    set;
  }
  
}
