namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect.
/// </summary>
public static class EffectConverter
{
  /// <summary>
  /// Reference
  /// </summary>
  private static String? GetReference(DXDraw.Effect openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Reference);
  }
  
  private static bool CmpReference(DXDraw.Effect openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Reference, value, diffs, objName, "Reference");
  }
  
  private static void SetReference(DXDraw.Effect openXmlElement, String? value)
  {
    openXmlElement.Reference = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.Effect? CreateModelElement(DXDraw.Effect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Effect();
      value.Reference = GetReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Effect? openXmlElement, DMDraws.Effect? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpReference(openXmlElement, value.Reference, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Effect value)
    where OpenXmlElementType: DXDraw.Effect, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Effect openXmlElement, DMDraws.Effect value)
  {
    SetReference(openXmlElement, value?.Reference);
  }
}
