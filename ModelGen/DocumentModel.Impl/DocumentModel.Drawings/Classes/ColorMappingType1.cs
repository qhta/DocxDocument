namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorMappingType Class.
/// </summary>
public class ColorMappingType1Impl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType>, ColorMappingType1
{
  /// <summary>
  /// Background 1
  /// </summary>
  public ColorSchemeIndexKind? Background1
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.Background1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Background1 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Text 1
  /// </summary>
  public ColorSchemeIndexKind? Text1
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.Text1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Text1 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Background 2
  /// </summary>
  public ColorSchemeIndexKind? Background2
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.Background2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Background2 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Text 2
  /// </summary>
  public ColorSchemeIndexKind? Text2
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.Text2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Text2 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 1
  /// </summary>
  public ColorSchemeIndexKind? Accent1
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.Accent1?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent1 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 2
  /// </summary>
  public ColorSchemeIndexKind? Accent2
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.Accent2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent2 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 3
  /// </summary>
  public ColorSchemeIndexKind? Accent3
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.Accent3?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent3 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 4
  /// </summary>
  public ColorSchemeIndexKind? Accent4
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.Accent4?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent4 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 5
  /// </summary>
  public ColorSchemeIndexKind? Accent5
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.Accent5?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent5 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Accent 6
  /// </summary>
  public ColorSchemeIndexKind? Accent6
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.Accent6?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Accent6 = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Hyperlink
  /// </summary>
  public ColorSchemeIndexKind? Hyperlink
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.Hyperlink?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hyperlink = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// Followed Hyperlink
  /// </summary>
  public ColorSchemeIndexKind? FollowedHyperlink
  {
    get => (ColorSchemeIndexKind?)OpenXmlElement?.FollowedHyperlink?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FollowedHyperlink = (DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
