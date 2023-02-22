namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticPencilGrayscale Class.
/// </summary>
public static class ArtisticPencilGrayscaleConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticPencilGrayscale openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticPencilGrayscale openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticPencilGrayscale openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetBrushSize(DXO2010Draw.ArtisticPencilGrayscale openXmlElement)
  {
    return openXmlElement?.BrushSize?.Value;
  }
  
  private static bool CmpBrushSize(DXO2010Draw.ArtisticPencilGrayscale openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BrushSize?.Value == value) return true;
    diffs?.Add(objName, "BrushSize", openXmlElement?.BrushSize?.Value, value);
    return false;
  }
  
  private static void SetBrushSize(DXO2010Draw.ArtisticPencilGrayscale openXmlElement, Int32? value)
  {
    openXmlElement.BrushSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticPencilGrayscale? CreateModelElement(DXO2010Draw.ArtisticPencilGrayscale? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticPencilGrayscale();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.BrushSize = GetBrushSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticPencilGrayscale? openXmlElement, DMDraws.ArtisticPencilGrayscale? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpBrushSize(openXmlElement, value.BrushSize, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticPencilGrayscale value)
    where OpenXmlElementType: DXO2010Draw.ArtisticPencilGrayscale, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ArtisticPencilGrayscale openXmlElement, DMDraws.ArtisticPencilGrayscale value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetBrushSize(openXmlElement, value?.BrushSize);
    }
  }
