namespace DocumentModel.Vml;

/// <summary>
/// Defines the ImageData Class.
/// </summary>
public class ImageDataImpl: ModelElementImpl, ImageData
{
  public DocumentFormat.OpenXml.Vml.ImageData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.ImageData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  /// Image Transparency Color
  /// </summary>
  public String? ChromAKey
  {
    get => (String?)OpenXmlElement?.ChromAKey?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ChromAKey = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Left Crop
  /// </summary>
  public String? CropLeft
  {
    get => (String?)OpenXmlElement?.CropLeft?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CropLeft = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Top Crop
  /// </summary>
  public String? CropTop
  {
    get => (String?)OpenXmlElement?.CropTop?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CropTop = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Right Crop
  /// </summary>
  public String? CropRight
  {
    get => (String?)OpenXmlElement?.CropRight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CropRight = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Bottom Crop
  /// </summary>
  public String? CropBottom
  {
    get => (String?)OpenXmlElement?.CropBottom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CropBottom = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Intensity
  /// </summary>
  public String? Gain
  {
    get => (String?)OpenXmlElement?.Gain?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Gain = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Brightness
  /// </summary>
  public String? BlackLevel
  {
    get => (String?)OpenXmlElement?.BlackLevel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlackLevel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Gamma Correction
  /// </summary>
  public String? Gamma
  {
    get => (String?)OpenXmlElement?.Gamma?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Gamma = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Grayscale Toggle
  /// </summary>
  public Boolean? Grayscale
  {
    get => (Boolean?)OpenXmlElement?.Grayscale?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Grayscale = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Image Bilevel Toggle
  /// </summary>
  public Boolean? BiLevel
  {
    get => (Boolean?)OpenXmlElement?.BiLevel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BiLevel = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Embossed Color
  /// </summary>
  public String? EmbossColor
  {
    get => (String?)OpenXmlElement?.EmbossColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EmbossColor = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Black Recoloring Color
  /// </summary>
  public String? RecolorTarget
  {
    get => (String?)OpenXmlElement?.RecolorTarget?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RecolorTarget = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Data Title
  /// </summary>
  public String? Title
  {
    get => (String?)OpenXmlElement?.Title?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Title = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  public Boolean? DetectMouseClick
  {
    get => (Boolean?)OpenXmlElement?.DetectMouseClick?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DetectMouseClick = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? RelId
  {
    get => (String?)OpenXmlElement?.RelId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Explicit Relationship to Image Data
  /// </summary>
  public String? RelationshipId
  {
    get => (String?)OpenXmlElement?.RelationshipId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelationshipId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Explicit Relationship to Alternate Image Data
  /// </summary>
  public String? Picture
  {
    get => (String?)OpenXmlElement?.Picture?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Picture = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Explicit Relationship to Hyperlink Target
  /// </summary>
  public String? RelHref
  {
    get => (String?)OpenXmlElement?.RelHref?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelHref = (System.String?)value;
    }
  }
  
}
