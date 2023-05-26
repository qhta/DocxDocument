namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ArtisticLineDrawing Class.
/// </summary>
public static class ArtisticLineDrawingConverter
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetTransparancy(DXO10D.ArtisticLineDrawing openXmlElement)
  {
    return openXmlElement?.Transparancy?.Value;
  }
  
  private static bool CmpTransparancy(DXO10D.ArtisticLineDrawing openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Transparancy?.Value == value) return true;
    diffs?.Add(objName, "Transparancy", openXmlElement?.Transparancy?.Value, value);
    return false;
  }
  
  private static void SetTransparancy(DXO10D.ArtisticLineDrawing openXmlElement, Int32? value)
  {
    openXmlElement.Transparancy = value;
  }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetPencilSize(DXO10D.ArtisticLineDrawing openXmlElement)
  {
    return openXmlElement?.PencilSize?.Value;
  }
  
  private static bool CmpPencilSize(DXO10D.ArtisticLineDrawing openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.PencilSize?.Value == value) return true;
    diffs?.Add(objName, "PencilSize", openXmlElement?.PencilSize?.Value, value);
    return false;
  }
  
  private static void SetPencilSize(DXO10D.ArtisticLineDrawing openXmlElement, Int32? value)
  {
    openXmlElement.PencilSize = value;
  }
  
  public static DocumentModel.Drawings.ArtisticLineDrawing? CreateModelElement(DXO10D.ArtisticLineDrawing? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10D.ArtisticLineDrawing? openXmlElement, DMD.ArtisticLineDrawing? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTransparancy(openXmlElement, value.Transparancy, diffs, objName, propName))
        ok = false;
      if (!CmpPencilSize(openXmlElement, value.PencilSize, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ArtisticLineDrawing value)
    where OpenXmlElementType: DXO10D.ArtisticLineDrawing, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ArtisticLineDrawing openXmlElement, DMD.ArtisticLineDrawing value)
  {
    SetTransparancy(openXmlElement, value?.Transparancy);
    SetPencilSize(openXmlElement, value?.PencilSize);
  }
}
