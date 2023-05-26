namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticWatercolorSponge Class.
/// </summary>
public static class ArtisticWatercolorSpongeConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO10D.ArtisticWatercolorSponge openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO10D.ArtisticWatercolorSponge openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO10D.ArtisticWatercolorSponge openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetBrushSize(DXO10D.ArtisticWatercolorSponge openXmlElement)
  {
    return openXmlElement?.BrushSize?.Value;
  }
  
  private static bool CmpBrushSize(DXO10D.ArtisticWatercolorSponge openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.BrushSize?.Value == value) return true;
    diffs?.Add(objName, "BrushSize", openXmlElement?.BrushSize?.Value, value);
    return false;
  }
  
  private static void SetBrushSize(DXO10D.ArtisticWatercolorSponge openXmlElement, Int32? value)
  {
    openXmlElement.BrushSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticWatercolorSponge? CreateModelElement(DXO10D.ArtisticWatercolorSponge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticWatercolorSponge();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.BrushSize = GetBrushSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.ArtisticWatercolorSponge? openXmlElement, DMD.ArtisticWatercolorSponge? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName, propName))
        ok = false;
      if (!CmpBrushSize(openXmlElement, value.BrushSize, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ArtisticWatercolorSponge value)
    where OpenXmlElementType: DXO10D.ArtisticWatercolorSponge, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ArtisticWatercolorSponge openXmlElement, DMD.ArtisticWatercolorSponge value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetBrushSize(openXmlElement, value?.BrushSize);
  }
}
