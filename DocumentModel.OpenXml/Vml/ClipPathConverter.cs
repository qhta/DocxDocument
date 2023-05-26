namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Clipping Path.
/// </summary>
public static class ClipPathConverter
{
  /// <summary>
  /// Path Definition
  /// </summary>
  private static String? GetValue(DXVO.ClipPath openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Value);
  }
  
  private static bool CmpValue(DXVO.ClipPath openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Value, value, diffs, objName, "Type");
  }
  
  private static void SetValue(DXVO.ClipPath openXmlElement, String? value)
  {
    openXmlElement.Value = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.ClipPath? CreateModelElement(DXVO.ClipPath? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ClipPath();
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVO.ClipPath? openXmlElement, DMV.ClipPath? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpValue(openXmlElement, value.Value, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.ClipPath value)
    where OpenXmlElementType: DXVO.ClipPath, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.ClipPath openXmlElement, DMV.ClipPath value)
  {
    SetValue(openXmlElement, value?.Value);
  }
}
