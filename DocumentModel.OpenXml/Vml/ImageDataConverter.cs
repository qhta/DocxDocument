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
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Transparency Color
  /// </summary>
  private static String? GetChromAKey(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ChromAKey);
  }
  
  private static bool CmpChromAKey(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ChromAKey, value, diffs, objName, "ChromAKey");
  }
  
  private static void SetChromAKey(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.ChromAKey = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Left Crop
  /// </summary>
  private static String? GetCropLeft(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CropLeft);
  }
  
  private static bool CmpCropLeft(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CropLeft, value, diffs, objName, "CropLeft");
  }
  
  private static void SetCropLeft(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.CropLeft = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Top Crop
  /// </summary>
  private static String? GetCropTop(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CropTop);
  }
  
  private static bool CmpCropTop(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CropTop, value, diffs, objName, "CropTop");
  }
  
  private static void SetCropTop(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.CropTop = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Right Crop
  /// </summary>
  private static String? GetCropRight(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CropRight);
  }
  
  private static bool CmpCropRight(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CropRight, value, diffs, objName, "CropRight");
  }
  
  private static void SetCropRight(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.CropRight = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Bottom Crop
  /// </summary>
  private static String? GetCropBottom(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.CropBottom);
  }
  
  private static bool CmpCropBottom(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.CropBottom, value, diffs, objName, "CropBottom");
  }
  
  private static void SetCropBottom(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.CropBottom = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Intensity
  /// </summary>
  private static String? GetGain(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Gain);
  }
  
  private static bool CmpGain(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Gain, value, diffs, objName, "Gain");
  }
  
  private static void SetGain(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.Gain = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Brightness
  /// </summary>
  private static String? GetBlackLevel(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.BlackLevel);
  }
  
  private static bool CmpBlackLevel(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.BlackLevel, value, diffs, objName, "BlackLevel");
  }
  
  private static void SetBlackLevel(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.BlackLevel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Gamma Correction
  /// </summary>
  private static String? GetGamma(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Gamma);
  }
  
  private static bool CmpGamma(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Gamma, value, diffs, objName, "Gamma");
  }
  
  private static void SetGamma(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.Gamma = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Grayscale Toggle
  /// </summary>
  private static Boolean? GetGrayscale(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.Grayscale?.Value;
  }
  
  private static bool CmpGrayscale(DXVml.ImageData openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Grayscale?.Value == value) return true;
    diffs?.Add(objName, "Grayscale", openXmlElement?.Grayscale?.Value, value);
    return false;
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
  
  private static bool CmpBiLevel(DXVml.ImageData openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BiLevel?.Value == value) return true;
    diffs?.Add(objName, "BiLevel", openXmlElement?.BiLevel?.Value, value);
    return false;
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
    return StringValueConverter.GetValue(openXmlElement?.EmbossColor);
  }
  
  private static bool CmpEmbossColor(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EmbossColor, value, diffs, objName, "EmbossColor");
  }
  
  private static void SetEmbossColor(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.EmbossColor = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Black Recoloring Color
  /// </summary>
  private static String? GetRecolorTarget(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RecolorTarget);
  }
  
  private static bool CmpRecolorTarget(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RecolorTarget, value, diffs, objName, "RecolorTarget");
  }
  
  private static void SetRecolorTarget(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.RecolorTarget = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Image Data Title
  /// </summary>
  private static String? GetTitle(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  private static Boolean? GetDetectMouseClick(DXVml.ImageData openXmlElement)
  {
    return openXmlElement?.DetectMouseClick?.Value;
  }
  
  private static bool CmpDetectMouseClick(DXVml.ImageData openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DetectMouseClick?.Value == value) return true;
    diffs?.Add(objName, "DetectMouseClick", openXmlElement?.DetectMouseClick?.Value, value);
    return false;
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
    return StringValueConverter.GetValue(openXmlElement?.RelId);
  }
  
  private static bool CmpRelId(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RelId, value, diffs, objName, "RelId");
  }
  
  private static void SetRelId(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.RelId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Explicit Relationship to Image Data
  /// </summary>
  private static String? GetRelationshipId(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RelationshipId);
  }
  
  private static bool CmpRelationshipId(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RelationshipId, value, diffs, objName, "RelationshipId");
  }
  
  private static void SetRelationshipId(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.RelationshipId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Explicit Relationship to Alternate Image Data
  /// </summary>
  private static String? GetPicture(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Picture);
  }
  
  private static bool CmpPicture(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Picture, value, diffs, objName, "Picture");
  }
  
  private static void SetPicture(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.Picture = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Explicit Relationship to Hyperlink Target
  /// </summary>
  private static String? GetRelHref(DXVml.ImageData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RelHref);
  }
  
  private static bool CmpRelHref(DXVml.ImageData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RelHref, value, diffs, objName, "RelHref");
  }
  
  private static void SetRelHref(DXVml.ImageData openXmlElement, String? value)
  {
    openXmlElement.RelHref = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.ImageData? CreateModelElement(DXVml.ImageData? openXmlElement)
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
  
  public static bool CompareModelElement(DXVml.ImageData? openXmlElement, DMVml.ImageData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpChromAKey(openXmlElement, value.ChromAKey, diffs, objName))
        ok = false;
      if (!CmpCropLeft(openXmlElement, value.CropLeft, diffs, objName))
        ok = false;
      if (!CmpCropTop(openXmlElement, value.CropTop, diffs, objName))
        ok = false;
      if (!CmpCropRight(openXmlElement, value.CropRight, diffs, objName))
        ok = false;
      if (!CmpCropBottom(openXmlElement, value.CropBottom, diffs, objName))
        ok = false;
      if (!CmpGain(openXmlElement, value.Gain, diffs, objName))
        ok = false;
      if (!CmpBlackLevel(openXmlElement, value.BlackLevel, diffs, objName))
        ok = false;
      if (!CmpGamma(openXmlElement, value.Gamma, diffs, objName))
        ok = false;
      if (!CmpGrayscale(openXmlElement, value.Grayscale, diffs, objName))
        ok = false;
      if (!CmpBiLevel(openXmlElement, value.BiLevel, diffs, objName))
        ok = false;
      if (!CmpEmbossColor(openXmlElement, value.EmbossColor, diffs, objName))
        ok = false;
      if (!CmpRecolorTarget(openXmlElement, value.RecolorTarget, diffs, objName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      if (!CmpDetectMouseClick(openXmlElement, value.DetectMouseClick, diffs, objName))
        ok = false;
      if (!CmpRelId(openXmlElement, value.RelId, diffs, objName))
        ok = false;
      if (!CmpRelationshipId(openXmlElement, value.RelationshipId, diffs, objName))
        ok = false;
      if (!CmpPicture(openXmlElement, value.Picture, diffs, objName))
        ok = false;
      if (!CmpRelHref(openXmlElement, value.RelHref, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.ImageData value)
    where OpenXmlElementType: DXVml.ImageData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVml.ImageData openXmlElement, DMVml.ImageData value)
  {
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
    }
  }
