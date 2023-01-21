namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Ink.
/// </summary>
public static class InkConverter
{
  /// <summary>
  /// Ink Data
  /// </summary>
  private static Byte[]? GetInkData(DXVmlO.Ink openXmlElement)
  {
    if (openXmlElement.InkData?.Value != null)
      return Convert.FromBase64String(openXmlElement.InkData.Value);
    return null;
  }
  
  private static void SetInkData(DXVmlO.Ink openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.InkData = Convert.ToBase64String(value);
    else
      openXmlElement.InkData = null;
  }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  private static Boolean? GetAnnotationFlag(DXVmlO.Ink openXmlElement)
  {
    return openXmlElement?.AnnotationFlag?.Value;
  }
  
  private static void SetAnnotationFlag(DXVmlO.Ink openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnnotationFlag = value;
    else
      openXmlElement.AnnotationFlag = null;
  }
  
  public static DMVml.Ink? CreateModelElement(DXVmlO.Ink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Ink();
      value.InkData = GetInkData(openXmlElement);
      value.AnnotationFlag = GetAnnotationFlag(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Ink? value)
    where OpenXmlElementType: DXVmlO.Ink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetInkData(openXmlElement, value?.InkData);
      SetAnnotationFlag(openXmlElement, value?.AnnotationFlag);
      return openXmlElement;
    }
    return default;
  }
}
