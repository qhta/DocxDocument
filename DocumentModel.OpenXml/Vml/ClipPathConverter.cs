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
