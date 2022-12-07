namespace DocumentModel.Vml;

/// <summary>
/// Document Background.
/// </summary>
public class BackgroundImpl: ModelElement<DocumentFormat.OpenXml.Vml.Background>, Background
{
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? BlackWhiteMode
  {
    get => (BlackAndWhiteMode?)OpenXmlElement?.BlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlackWhiteMode = (DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? PureBlackWhiteMode
  {
    get => (BlackAndWhiteMode?)OpenXmlElement?.PureBlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PureBlackWhiteMode = (DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public BlackAndWhiteMode? NormalBlackWhiteMode
  {
    get => (BlackAndWhiteMode?)OpenXmlElement?.NormalBlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NormalBlackWhiteMode = (DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// Target Screen Size
  /// </summary>
  public ScreenSizeKind? TargetScreenSize
  {
    get => (ScreenSizeKind?)OpenXmlElement?.TargetScreenSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TargetScreenSize = (DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues?)value;
    }
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public Fill? Fill
  {
    get;
    set;
  }
  
}
