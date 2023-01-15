using DocumentFormat.OpenXml.Vml;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Defines the ImageData Class.
/// </summary>
public static class ImageDataConverter
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public static String? GetId(ImageData? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Image Transparency Color
  /// </summary>
  public static String? GetChromAKey(ImageData? openXmlElement)
  {
    return openXmlElement?.ChromAKey?.Value;
  }

  public static void SetChromAKey(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ChromAKey = new StringValue { Value = value };
      else
        openXmlElement.ChromAKey = null;
  }

  /// <summary>
  ///   Image Left Crop
  /// </summary>
  public static String? GetCropLeft(ImageData? openXmlElement)
  {
    return openXmlElement?.CropLeft?.Value;
  }

  public static void SetCropLeft(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CropLeft = new StringValue { Value = value };
      else
        openXmlElement.CropLeft = null;
  }

  /// <summary>
  ///   Image Top Crop
  /// </summary>
  public static String? GetCropTop(ImageData? openXmlElement)
  {
    return openXmlElement?.CropTop?.Value;
  }

  public static void SetCropTop(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CropTop = new StringValue { Value = value };
      else
        openXmlElement.CropTop = null;
  }

  /// <summary>
  ///   Image Right Crop
  /// </summary>
  public static String? GetCropRight(ImageData? openXmlElement)
  {
    return openXmlElement?.CropRight?.Value;
  }

  public static void SetCropRight(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CropRight = new StringValue { Value = value };
      else
        openXmlElement.CropRight = null;
  }

  /// <summary>
  ///   Image Bottom Crop
  /// </summary>
  public static String? GetCropBottom(ImageData? openXmlElement)
  {
    return openXmlElement?.CropBottom?.Value;
  }

  public static void SetCropBottom(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CropBottom = new StringValue { Value = value };
      else
        openXmlElement.CropBottom = null;
  }

  /// <summary>
  ///   Image Intensity
  /// </summary>
  public static String? GetGain(ImageData? openXmlElement)
  {
    return openXmlElement?.Gain?.Value;
  }

  public static void SetGain(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Gain = new StringValue { Value = value };
      else
        openXmlElement.Gain = null;
  }

  /// <summary>
  ///   Image Brightness
  /// </summary>
  public static String? GetBlackLevel(ImageData? openXmlElement)
  {
    return openXmlElement?.BlackLevel?.Value;
  }

  public static void SetBlackLevel(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BlackLevel = new StringValue { Value = value };
      else
        openXmlElement.BlackLevel = null;
  }

  /// <summary>
  ///   Image Gamma Correction
  /// </summary>
  public static String? GetGamma(ImageData? openXmlElement)
  {
    return openXmlElement?.Gamma?.Value;
  }

  public static void SetGamma(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Gamma = new StringValue { Value = value };
      else
        openXmlElement.Gamma = null;
  }

  /// <summary>
  ///   Image Grayscale Toggle
  /// </summary>
  public static Boolean? GetGrayscale(ImageData? openXmlElement)
  {
    return openXmlElement?.Grayscale?.Value;
  }

  public static void SetGrayscale(ImageData? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Grayscale = value;
      else
        openXmlElement.Grayscale = null;
  }

  /// <summary>
  ///   Image Bilevel Toggle
  /// </summary>
  public static Boolean? GetBiLevel(ImageData? openXmlElement)
  {
    return openXmlElement?.BiLevel?.Value;
  }

  public static void SetBiLevel(ImageData? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BiLevel = value;
      else
        openXmlElement.BiLevel = null;
  }

  /// <summary>
  ///   Embossed Color
  /// </summary>
  public static String? GetEmbossColor(ImageData? openXmlElement)
  {
    return openXmlElement?.EmbossColor?.Value;
  }

  public static void SetEmbossColor(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EmbossColor = new StringValue { Value = value };
      else
        openXmlElement.EmbossColor = null;
  }

  /// <summary>
  ///   Black Recoloring Color
  /// </summary>
  public static String? GetRecolorTarget(ImageData? openXmlElement)
  {
    return openXmlElement?.RecolorTarget?.Value;
  }

  public static void SetRecolorTarget(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RecolorTarget = new StringValue { Value = value };
      else
        openXmlElement.RecolorTarget = null;
  }

  /// <summary>
  ///   Image Data Title
  /// </summary>
  public static String? GetTitle(ImageData? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }

  public static void SetTitle(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }

  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  public static Boolean? GetDetectMouseClick(ImageData? openXmlElement)
  {
    return openXmlElement?.DetectMouseClick?.Value;
  }

  public static void SetDetectMouseClick(ImageData? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DetectMouseClick = value;
      else
        openXmlElement.DetectMouseClick = null;
  }

  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public static String? GetRelId(ImageData? openXmlElement)
  {
    return openXmlElement?.RelId?.Value;
  }

  public static void SetRelId(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RelId = new StringValue { Value = value };
      else
        openXmlElement.RelId = null;
  }

  /// <summary>
  ///   Explicit Relationship to Image Data
  /// </summary>
  public static String? GetRelationshipId(ImageData? openXmlElement)
  {
    return openXmlElement?.RelationshipId?.Value;
  }

  public static void SetRelationshipId(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RelationshipId = new StringValue { Value = value };
      else
        openXmlElement.RelationshipId = null;
  }

  /// <summary>
  ///   Explicit Relationship to Alternate Image Data
  /// </summary>
  public static String? GetPicture(ImageData? openXmlElement)
  {
    return openXmlElement?.Picture?.Value;
  }

  public static void SetPicture(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Picture = new StringValue { Value = value };
      else
        openXmlElement.Picture = null;
  }

  /// <summary>
  ///   Explicit Relationship to Hyperlink Target
  /// </summary>
  public static String? GetRelHref(ImageData? openXmlElement)
  {
    return openXmlElement?.RelHref?.Value;
  }

  public static void SetRelHref(ImageData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RelHref = new StringValue { Value = value };
      else
        openXmlElement.RelHref = null;
  }

  public static DocumentModel.Vml.ImageData? CreateModelElement(ImageData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ImageData();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ImageData? value)
    where OpenXmlElementType : ImageData, new()
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