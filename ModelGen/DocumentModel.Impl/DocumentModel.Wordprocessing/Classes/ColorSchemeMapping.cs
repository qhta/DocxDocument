namespace DocumentModel.Wordprocessing;

/// <summary>
/// Theme Color Mappings.
/// </summary>
public partial class ColorSchemeMappingImpl: ModelElementImpl, ColorSchemeMapping
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ColorSchemeMappingImpl(): base() {}
  
  public ColorSchemeMappingImpl(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Background 1 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Background1
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.Background1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Background1 = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Text 1 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Text1
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.Text1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Text1 = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Background 2 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Background2
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.Background2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Background2 = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Text 2 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Text2
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.Text2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Text2 = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 1 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent1
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.Accent1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent1 = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 2 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent2
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.Accent2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent2 = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent3 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent3
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.Accent3?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent3 = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent4 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent4
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.Accent4?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent4 = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent5 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent5
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.Accent5?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent5 = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent6 Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Accent6
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.Accent6?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent6 = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Hyperlink Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? Hyperlink
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.Hyperlink?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hyperlink = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Followed Hyperlink Theme Color Mapping
  /// </summary>
  public DocumentModel.Wordprocessing.ColorSchemeIndexKind? FollowedHyperlink
  {
    get => (DocumentModel.Wordprocessing.ColorSchemeIndexKind?)OpenXmlElement?.FollowedHyperlink?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FollowedHyperlink = (DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues?)value;
    }
  }
  
}
