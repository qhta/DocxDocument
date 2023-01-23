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
    return openXmlElement?.Reference?.Value;
  }
  
  private static bool CmpReference(DXDraw.Effect openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Reference?.Value == value;
  }
  
  private static void SetReference(DXDraw.Effect openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Reference = new StringValue { Value = value };
    else
      openXmlElement.Reference = null;
  }
  
  public static DMDraws.Effect? CreateModelElement(DXDraw.Effect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Effect();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Effect? value)
    where OpenXmlElementType: DXDraw.Effect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetReference(openXmlElement, value?.Reference);
      return openXmlElement;
    }
    return default;
  }
}
