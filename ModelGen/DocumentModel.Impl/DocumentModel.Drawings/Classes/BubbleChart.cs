namespace DocumentModel.Drawings;

/// <summary>
/// Bubble Charts.
/// </summary>
public class BubbleChartImpl: ModelElementImpl, BubbleChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BubbleChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors
  {
    get;
    set;
  }
  
  public Collection<BubbleChartSeries2>? BubbleChartSerieses
  {
    get;
    set;
  }
  
  public DataLabels2? DataLabels
  {
    get;
    set;
  }
  
  public Boolean? Bubble3D
  {
    get;
    set;
  }
  
  public UInt32? BubbleScale
  {
    get;
    set;
  }
  
  public Boolean? ShowNegativeBubbles
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
  
  public Collection<UInt32>? AxisIds
  {
    get;
    set;
  }
  
  public BubbleChartExtensionList? BubbleChartExtensionList
  {
    get;
    set;
  }
  
}
