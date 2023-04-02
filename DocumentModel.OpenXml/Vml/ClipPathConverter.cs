namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Clipping Path.
/// </summary>
public static class ClipPathConverter
{
  /// <summary>
  /// Path Definition
  /// </summary>
  private static String? GetValue(DXVmlO.ClipPath openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Value);
  }
  
  private static bool CmpValue(DXVmlO.ClipPath openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Value, value, diffs, objName, "Type");
  }
  
  private static void SetValue(DXVmlO.ClipPath openXmlElement, String? value)
  {
    openXmlElement.Value = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.ClipPath? CreateModelElement(DXVmlO.ClipPath? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ClipPath();
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.ClipPath? openXmlElement, DMVml.ClipPath? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpValue(openXmlElement, value.Value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.ClipPath value)
    where OpenXmlElementType: DXVmlO.ClipPath, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.ClipPath openXmlElement, DMVml.ClipPath value)
  {
    SetValue(openXmlElement, value?.Value);
  }
}
