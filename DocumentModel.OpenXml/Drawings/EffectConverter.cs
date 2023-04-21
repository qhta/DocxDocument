namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect.
/// </summary>
public static class EffectConverter
{
  /// <summary>
  /// Reference
  /// </summary>
  private static String? GetReference(DXD.Effect openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Reference);
  }
  
  private static bool CmpReference(DXD.Effect openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Reference, value, diffs, objName, "Reference");
  }
  
  private static void SetReference(DXD.Effect openXmlElement, String? value)
  {
    openXmlElement.Reference = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.Effect? CreateModelElement(DXD.Effect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Effect();
      value.Reference = GetReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Effect? openXmlElement, DMD.Effect? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Effect value)
    where OpenXmlElementType: DXD.Effect, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Effect openXmlElement, DMD.Effect value)
  {
    SetReference(openXmlElement, value?.Reference);
  }
}
