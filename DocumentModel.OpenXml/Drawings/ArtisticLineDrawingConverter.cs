namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticLineDrawing Class.
/// </summary>
public static class ArtisticLineDrawingConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO2010Draw.ArtisticLineDrawing openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO2010Draw.ArtisticLineDrawing openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO2010Draw.ArtisticLineDrawing openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetPencilSize(DXO2010Draw.ArtisticLineDrawing openXmlElement)
  {
    return openXmlElement?.PencilSize?.Value;
  }
  
  private static bool CmpPencilSize(DXO2010Draw.ArtisticLineDrawing openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PencilSize?.Value == value) return true;
    diffs?.Add(objName, "PencilSize", openXmlElement?.PencilSize?.Value, value);
    return false;
  }
  
  private static void SetPencilSize(DXO2010Draw.ArtisticLineDrawing openXmlElement, Int32? value)
  {
    openXmlElement.PencilSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticLineDrawing? CreateModelElement(DXO2010Draw.ArtisticLineDrawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArtisticLineDrawing();
      value.Transparancy = GetTransparancy(openXmlElement);
      value.PencilSize = GetPencilSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010Draw.ArtisticLineDrawing? openXmlElement, DMDraws.ArtisticLineDrawing? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName))
        ok = false;
      if (!CmpPencilSize(openXmlElement, value.PencilSize, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArtisticLineDrawing value)
    where OpenXmlElementType: DXO2010Draw.ArtisticLineDrawing, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010Draw.ArtisticLineDrawing openXmlElement, DMDraws.ArtisticLineDrawing value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetPencilSize(openXmlElement, value?.PencilSize);
  }
}
