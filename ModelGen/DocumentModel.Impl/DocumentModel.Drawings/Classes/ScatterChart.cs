namespace DocumentModel.Drawings;

/// <summary>
/// Scatter Charts.
/// </summary>
public class ScatterChartImpl: ModelElementImpl, ScatterChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ScatterChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors
  {
    get;
    set;
  }
  
  public Collection<ScatterChartSeries2>? ScatterChartSerieses
  {
    get;
    set;
  }
  
  public DataLabels2? DataLabels
  {
    get;
    set;
  }
  
  public Collection<UInt32>? AxisIds
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
