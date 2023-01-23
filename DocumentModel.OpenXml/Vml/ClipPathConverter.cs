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
    return openXmlElement?.Value?.Value;
  }
  
  private static bool CmpValue(DXVmlO.ClipPath openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Value?.Value == value;
  }
  
  private static void SetValue(DXVmlO.ClipPath openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Value = new StringValue { Value = value };
    else
      openXmlElement.Value = null;
  }
  
  public static DMVml.ClipPath? CreateModelElement(DXVmlO.ClipPath? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.ClipPath();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.ClipPath? value)
    where OpenXmlElementType: DXVmlO.ClipPath, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetValue(openXmlElement, value?.Value);
      return openXmlElement;
    }
    return default;
  }
}
