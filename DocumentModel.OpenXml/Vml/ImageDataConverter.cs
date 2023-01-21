namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the ImageData Class.
/// </summary>
public static class ImageDataConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Image Transparency Color
  /// </summary>
  private static String? GetChromAKey(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.ChromAKey?.Value;
  }
  
  private static void SetChromAKey(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ChromAKey = new StringValue { Value = value };
    else
      openXmlElement.ChromAKey = null;
  }
  
  /// <summary>
  /// Image Left Crop
  /// </summary>
  private static String? GetCropLeft(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.CropLeft?.Value;
  }
  
  private static void SetCropLeft(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropLeft = new StringValue { Value = value };
    else
      openXmlElement.CropLeft = null;
  }
  
  /// <summary>
  /// Image Top Crop
  /// </summary>
  private static String? GetCropTop(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.CropTop?.Value;
  }
  
  private static void SetCropTop(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropTop = new StringValue { Value = value };
    else
      openXmlElement.CropTop = null;
  }
  
  /// <summary>
  /// Image Right Crop
  /// </summary>
  private static String? GetCropRight(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.CropRight?.Value;
  }
  
  private static void SetCropRight(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropRight = new StringValue { Value = value };
    else
      openXmlElement.CropRight = null;
  }
  
  /// <summary>
  /// Image Bottom Crop
  /// </summary>
  private static String? GetCropBottom(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.CropBottom?.Value;
  }
  
  private static void SetCropBottom(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.CropBottom = new StringValue { Value = value };
    else
      openXmlElement.CropBottom = null;
  }
  
  /// <summary>
  /// Image Intensity
  /// </summary>
  private static String? GetGain(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.Gain?.Value;
  }
  
  private static void SetGain(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Gain = new StringValue { Value = value };
    else
      openXmlElement.Gain = null;
  }
  
  /// <summary>
  /// Image Brightness
  /// </summary>
  private static String? GetBlackLevel(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.BlackLevel?.Value;
  }
  
  private static void SetBlackLevel(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.BlackLevel = new StringValue { Value = value };
    else
      openXmlElement.BlackLevel = null;
  }
  
  /// <summary>
  /// Image Gamma Correction
  /// </summary>
  private static String? GetGamma(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.Gamma?.Value;
  }
  
  private static void SetGamma(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Gamma = new StringValue { Value = value };
    else
      openXmlElement.Gamma = null;
  }
  
  /// <summary>
  /// Image Grayscale Toggle
  /// </summary>
  private static Boolean? GetGrayscale(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.Grayscale?.Value;
  }
  
  private static void SetGrayscale(DXVml.ImageData openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Grayscale = value;
    else
      openXmlElement.Grayscale = null;
  }
  
  /// <summary>
  /// Image Bilevel Toggle
  /// </summary>
  private static Boolean? GetBiLevel(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.BiLevel?.Value;
  }
  
  private static void SetBiLevel(DXVml.ImageData openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.BiLevel = value;
    else
      openXmlElement.BiLevel = null;
  }
  
  /// <summary>
  /// Embossed Color
  /// </summary>
  private static String? GetEmbossColor(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.EmbossColor?.Value;
  }
  
  private static void SetEmbossColor(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EmbossColor = new StringValue { Value = value };
    else
      openXmlElement.EmbossColor = null;
  }
  
  /// <summary>
  /// Black Recoloring Color
  /// </summary>
  private static String? GetRecolorTarget(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.RecolorTarget?.Value;
  }
  
  private static void SetRecolorTarget(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RecolorTarget = new StringValue { Value = value };
    else
      openXmlElement.RecolorTarget = null;
  }
  
  /// <summary>
  /// Image Data Title
  /// </summary>
  private static String? GetTitle(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  private static Boolean? GetDetectMouseClick(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.DetectMouseClick?.Value;
  }
  
  private static void SetDetectMouseClick(DXVml.ImageData openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DetectMouseClick = value;
    else
      openXmlElement.DetectMouseClick = null;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetRelId(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.RelId?.Value;
  }
  
  private static void SetRelId(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RelId = new StringValue { Value = value };
    else
      openXmlElement.RelId = null;
  }
  
  /// <summary>
  /// Explicit Relationship to Image Data
  /// </summary>
  private static String? GetRelationshipId(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.RelationshipId?.Value;
  }
  
  private static void SetRelationshipId(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RelationshipId = new StringValue { Value = value };
    else
      openXmlElement.RelationshipId = null;
  }
  
  /// <summary>
  /// Explicit Relationship to Alternate Image Data
  /// </summary>
  private static String? GetPicture(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.Picture?.Value;
  }
  
  private static void SetPicture(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Picture = new StringValue { Value = value };
    else
      openXmlElement.Picture = null;
  }
  
  /// <summary>
  /// Explicit Relationship to Hyperlink Target
  /// </summary>
  private static String? GetRelHref(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.RelHref?.Value;
  }
  
  private static void SetRelHref(DXVml.ImageData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RelHref = new StringValue { Value = value };
    else
      openXmlElement.RelHref = null;
  }
  
  public static DMVml.ImageData? CreateModelElement(DXVml.ImageData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.ImageData();
      value.Id = GetId(openXmlElement);
      value.ChromAKey = GetChromAKey(openXmlElement);
      value.CropLeft = GetCropLeft(openXmlElement);
      value.CropTop = GetCropTop(openXmlElement);
      value.CropRight = GetCropRight(openXmlElement);
      value.CropBottom = GetCropBottom(openXmlElement);
      value.Gain = GetGain(openXmlElement);
      value.BlackLevel = GetBlackLevel(openXmlElement);
      value.Gamma = GetGamma(openXmlElement);
      value.Grayscale = GetGrayscale(openXmlElement);
      value.BiLevel = GetBiLevel(openXmlElement);
      value.EmbossColor = GetEmbossColor(openXmlElement);
      value.RecolorTarget = GetRecolorTarget(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.DetectMouseClick = GetDetectMouseClick(openXmlElement);
      value.RelId = GetRelId(openXmlElement);
      value.RelationshipId = GetRelationshipId(openXmlElement);
      value.Picture = GetPicture(openXmlElement);
      value.RelHref = GetRelHref(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.ImageData? value)
    where OpenXmlElementType: DXVml.ImageData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetChromAKey(openXmlElement, value?.ChromAKey);
      SetCropLeft(openXmlElement, value?.CropLeft);
      SetCropTop(openXmlElement, value?.CropTop);
      SetCropRight(openXmlElement, value?.CropRight);
      SetCropBottom(openXmlElement, value?.CropBottom);
      SetGain(openXmlElement, value?.Gain);
      SetBlackLevel(openXmlElement, value?.BlackLevel);
      SetGamma(openXmlElement, value?.Gamma);
      SetGrayscale(openXmlElement, value?.Grayscale);
      SetBiLevel(openXmlElement, value?.BiLevel);
      SetEmbossColor(openXmlElement, value?.EmbossColor);
      SetRecolorTarget(openXmlElement, value?.RecolorTarget);
      SetTitle(openXmlElement, value?.Title);
      SetDetectMouseClick(openXmlElement, value?.DetectMouseClick);
      SetRelId(openXmlElement, value?.RelId);
      SetRelationshipId(openXmlElement, value?.RelationshipId);
      SetPicture(openXmlElement, value?.Picture);
      SetRelHref(openXmlElement, value?.RelHref);
      return openXmlElement;
    }
    return default;
  }
}
