namespace DocumentModel.Vml;

/// <summary>
/// Document Background.
/// </summary>
public class BackgroundImpl: ModelElementImpl, Background
{
  public DocumentFormat.OpenXml.Vml.Background? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Background?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackgroundImpl(): base() {}
  
  public BackgroundImpl(DocumentFormat.OpenXml.Vml.Background openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public Boolean? Filled
  {
    get => (System.Boolean?)OpenXmlElement?.Filled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Filled = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Fill Color
  /// </summary>
  public String? Fillcolor
  {
    get => (System.String?)OpenXmlElement?.Fillcolor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Fillcolor = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? BlackWhiteMode
  {
    get => (DocumentModel.Vml.BlackAndWhiteMode?)OpenXmlElement?.BlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlackWhiteMode = (DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// Pure Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? PureBlackWhiteMode
  {
    get => (DocumentModel.Vml.BlackAndWhiteMode?)OpenXmlElement?.PureBlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PureBlackWhiteMode = (DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// Normal Black-and-White Mode
  /// </summary>
  public DocumentModel.Vml.BlackAndWhiteMode? NormalBlackWhiteMode
  {
    get => (DocumentModel.Vml.BlackAndWhiteMode?)OpenXmlElement?.NormalBlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NormalBlackWhiteMode = (DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// Target Screen Size
  /// </summary>
  public DocumentModel.Vml.ScreenSizeKind? TargetScreenSize
  {
    get => (DocumentModel.Vml.ScreenSizeKind?)OpenXmlElement?.TargetScreenSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TargetScreenSize = (DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues?)value;
    }
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public DocumentModel.Vml.Fill? Fill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
