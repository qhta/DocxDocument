namespace DocumentModel.Vml;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public class ShadowImpl: ModelElementImpl, Shadow
{
  public DocumentFormat.OpenXml.Vml.Shadow? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Shadow?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShadowImpl(): base() {}
  
  public ShadowImpl(DocumentFormat.OpenXml.Vml.Shadow openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  public Boolean? On
  {
    get => (Boolean?)OpenXmlElement?.On?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.On = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Shadow Type
  /// </summary>
  public ShadowKind? Type
  {
    get => (ShadowKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.ShadowValues?)value;
    }
  }
  
  /// <summary>
  /// Shadow Transparency
  /// </summary>
  public Boolean? Obscured
  {
    get => (Boolean?)OpenXmlElement?.Obscured?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Obscured = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Shadow Primary Color
  /// </summary>
  public String? Color
  {
    get => (String?)OpenXmlElement?.Color?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Color = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shadow Opacity
  /// </summary>
  public String? Opacity
  {
    get => (String?)OpenXmlElement?.Opacity?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Opacity = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shadow Primary Offset
  /// </summary>
  public String? Offset
  {
    get => (String?)OpenXmlElement?.Offset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Offset = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shadow Secondary Color
  /// </summary>
  public String? Color2
  {
    get => (String?)OpenXmlElement?.Color2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Color2 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shadow Secondary Offset
  /// </summary>
  public String? Offset2
  {
    get => (String?)OpenXmlElement?.Offset2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Offset2 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shadow Origin
  /// </summary>
  public String? Origin
  {
    get => (String?)OpenXmlElement?.Origin?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Origin = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shadow Perspective Matrix
  /// </summary>
  public String? Matrix
  {
    get => (String?)OpenXmlElement?.Matrix?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Matrix = (System.String?)value;
    }
  }
  
}
