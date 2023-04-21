namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Inset/Outset Effect.
/// </summary>
public static class AlphaOutsetConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  private static Int64? GetRadius(DXD.AlphaOutset openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }
  
  private static bool CmpRadius(DXD.AlphaOutset openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Radius?.Value == value) return true;
    diffs?.Add(objName, "Radius", openXmlElement?.Radius?.Value, value);
    return false;
  }
  
  private static void SetRadius(DXD.AlphaOutset openXmlElement, Int64? value)
  {
    openXmlElement.Radius = value;
  }
  
  public static DocumentModel.Drawings.AlphaOutset? CreateModelElement(DXD.AlphaOutset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaOutset();
      value.Radius = GetRadius(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.AlphaOutset? openXmlElement, DMD.AlphaOutset? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadius(openXmlElement, value.Radius, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AlphaOutset value)
    where OpenXmlElementType: DXD.AlphaOutset, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AlphaOutset openXmlElement, DMD.AlphaOutset value)
  {
    SetRadius(openXmlElement, value?.Radius);
  }
}
