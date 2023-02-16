namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Inset/Outset Effect.
/// </summary>
public static class AlphaOutsetConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  private static Int64? GetRadius(DXDraw.AlphaOutset openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }
  
  private static bool CmpRadius(DXDraw.AlphaOutset openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Radius?.Value == value) return true;
    diffs?.Add(objName, "Radius", openXmlElement?.Radius?.Value, value);
    return false;
  }
  
  private static void SetRadius(DXDraw.AlphaOutset openXmlElement, Int64? value)
  {
    openXmlElement.Radius = value;
  }
  
  public static DocumentModel.Drawings.AlphaOutset? CreateModelElement(DXDraw.AlphaOutset? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaOutset();
      value.Radius = GetRadius(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AlphaOutset? openXmlElement, DMDraws.AlphaOutset? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AlphaOutset? value)
    where OpenXmlElementType: DXDraw.AlphaOutset, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadius(openXmlElement, value?.Radius);
      return openXmlElement;
    }
    return default;
  }
}
