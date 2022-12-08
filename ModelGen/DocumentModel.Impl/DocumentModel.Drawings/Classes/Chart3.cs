namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public class Chart3Impl: ModelElementImpl, Chart3
{
  public DocumentFormat.OpenXml.Drawing.Charts.Chart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Chart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Title data and formatting.
  /// </summary>
  public Title1? Title
  {
    get;
    set;
  }
  
  /// <summary>
  /// True if the chart automatic title has been deleted..
  /// </summary>
  public Boolean? AutoTitleDeleted
  {
    get;
    set;
  }
  
  /// <summary>
  /// pivot chart format persistence data.
  /// </summary>
  public PivotFormats? PivotFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// 3D view settings.
  /// </summary>
  public View3D? View3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// 3D floor formatting.
  /// </summary>
  public Floor2? Floor
  {
    get;
    set;
  }
  
  /// <summary>
  /// 3D side wall formatting.
  /// </summary>
  public SideWall? SideWall
  {
    get;
    set;
  }
  
  /// <summary>
  /// 3D back wall formatting.
  /// </summary>
  public BackWall? BackWall
  {
    get;
    set;
  }
  
  /// <summary>
  /// Plot data and formatting.
  /// </summary>
  public PlotArea2? PlotArea
  {
    get;
    set;
  }
  
  /// <summary>
  /// Legend data and formatting.
  /// </summary>
  public Legend2? Legend
  {
    get;
    set;
  }
  
  /// <summary>
  /// True if only visible cells are plotted..
  /// </summary>
  public Boolean? PlotVisibleOnly
  {
    get;
    set;
  }
  
  /// <summary>
  /// The way that blank cells are plotted on a chart..
  /// </summary>
  public DisplayBlanksAsKind? DisplayBlanksAs
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAs>();
        return (DisplayBlanksAsKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAs>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAs{ Val = (DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// True if we should render datalabels over the maximum scale.
  /// </summary>
  public Boolean? ShowDataLabelsOverMaximum
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extensibility container.
  /// </summary>
  public ChartExtensionList? ChartExtensionList
  {
    get;
    set;
  }
  
}
