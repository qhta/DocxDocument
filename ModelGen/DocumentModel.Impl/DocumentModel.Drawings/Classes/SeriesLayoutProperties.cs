namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public class SeriesLayoutPropertiesImpl: ModelElementImpl, SeriesLayoutProperties
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  public ParentLabelLayout? ParentLabelLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  public RegionLabelLayoutEnum? RegionLabelLayout
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayout>();
        return (RegionLabelLayoutEnum?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayout>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayout{ Val = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  public SeriesElementVisibilities? SeriesElementVisibilities
  {
    get;
    set;
  }
  
  public Boolean? Aggregation
  {
    get;
    set;
  }
  
  public Binning? Binning
  {
    get;
    set;
  }
  
  public Geography? Geography
  {
    get;
    set;
  }
  
  public Statistics? Statistics
  {
    get;
    set;
  }
  
  public Subtotals? Subtotals
  {
    get;
    set;
  }
  
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
