namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ColorMapOverride Class.
/// </summary>
public class ColorMapOverrideImpl: ModelElementImpl, ColorMapOverride
{
  public DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorMapOverrideImpl(): base() {}
  
  public ColorMapOverrideImpl(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Background 1
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Background1
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.Background1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Background1 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Text 1
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Text1
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.Text1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Text1 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Background 2
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Background2
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.Background2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Background2 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Text 2
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Text2
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.Text2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Text2 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent1
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.Accent1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent1 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent2
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.Accent2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent2 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent3
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.Accent3?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent3 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent4
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.Accent4?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent4 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent5
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.Accent5?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent5 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Accent6
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.Accent6?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent6 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? Hyperlink
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.Hyperlink?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hyperlink = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  public DocumentModel.Drawings.ColorSchemeIndexKind? FollowedHyperlink
  {
    get => (DocumentModel.Drawings.ColorSchemeIndexKind?)OpenXmlElement?.FollowedHyperlink?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FollowedHyperlink = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
