namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Relative Offset Effect converter from/to OpenXml.
///</summary>
public static class RelativeOffsetConverter
{
  /// <summary>
  /// Offset X
  /// </summary>
  private static Int32? GetOffsetX(DXDraw.RelativeOffset openXmlElement)
  {
    return openXmlElement?.OffsetX?.Value;
  }
  
  private static bool CmpOffsetX(DXDraw.RelativeOffset openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OffsetX?.Value == value) return true;
    diffs?.Add(objName, "OffsetX", openXmlElement?.OffsetX?.Value, value);
    return false;
  }
  
  private static void SetOffsetX(DXDraw.RelativeOffset openXmlElement, Int32? value)
  {
    openXmlElement.OffsetX = value;
  }
  
  /// <summary>
  /// Offset Y
  /// </summary>
  private static Int32? GetOffsetY(DXDraw.RelativeOffset openXmlElement)
  {
    return openXmlElement?.OffsetY?.Value;
  }
  
  private static bool CmpOffsetY(DXDraw.RelativeOffset openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.OffsetY?.Value == value) return true;
    diffs?.Add(objName, "OffsetY", openXmlElement?.OffsetY?.Value, value);
    return false;
  }
  
  private static void SetOffsetY(DXDraw.RelativeOffset openXmlElement, Int32? value)
  {
    openXmlElement.OffsetY = value;
  }
  
  public static DocumentModel.Drawings.RelativeOffset? CreateModelElement(DXDraw.RelativeOffset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.RelativeOffset();
      value.OffsetX = GetOffsetX(openXmlElement);
      value.OffsetY = GetOffsetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.RelativeOffset? openXmlElement, DMDraws.RelativeOffset? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOffsetX(openXmlElement, value.OffsetX, diffs, objName))
        ok = false;
      if (!CmpOffsetY(openXmlElement, value.OffsetY, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.RelativeOffset value)
    where OpenXmlElementType: DXDraw.RelativeOffset, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.RelativeOffset openXmlElement, DMDraws.RelativeOffset value)
  {
    SetOffsetX(openXmlElement, value?.OffsetX);
    SetOffsetY(openXmlElement, value?.OffsetY);
  }
}
