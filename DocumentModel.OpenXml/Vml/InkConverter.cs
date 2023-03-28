namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Ink converter from/to OpenXml.
///</summary>
public static class InkConverter
{
  /// <summary>
  /// Ink Data
  /// </summary>
  private static DM.Base64Binary? GetInkData(DXVmlO.Ink openXmlElement)
  {
    if (openXmlElement?.InkData?.Value != null)
      return Convert.FromBase64String(openXmlElement.InkData.Value);
    return null;
  }
  
  private static bool CmpInkData(DXVmlO.Ink openXmlElement, DM.Base64Binary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InkData?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.InkData.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.InkData?.Value == null && value == null) return true;
    diffs?.Add(objName, "InkData", openXmlElement?.InkData?.Value, value);
    return false;
  }
  
  private static void SetInkData(DXVmlO.Ink openXmlElement, DM.Base64Binary? value)
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
  
  private static bool CmpAnnotationFlag(DXVmlO.Ink openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AnnotationFlag?.Value == value) return true;
    diffs?.Add(objName, "AnnotationFlag", openXmlElement?.AnnotationFlag?.Value, value);
    return false;
  }
  
  private static void SetAnnotationFlag(DXVmlO.Ink openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnnotationFlag = value;
    else
      openXmlElement.AnnotationFlag = null;
  }
  
  public static DocumentModel.Vml.Ink? CreateModelElement(DXVmlO.Ink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Ink();
      value.InkData = GetInkData(openXmlElement);
      value.AnnotationFlag = GetAnnotationFlag(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVmlO.Ink? openXmlElement, DMVml.Ink? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpInkData(openXmlElement, value.InkData, diffs, objName))
        ok = false;
      if (!CmpAnnotationFlag(openXmlElement, value.AnnotationFlag, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Ink value)
    where OpenXmlElementType: DXVmlO.Ink, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.Ink openXmlElement, DMVml.Ink value)
  {
    SetInkData(openXmlElement, value?.InkData);
    SetAnnotationFlag(openXmlElement, value?.AnnotationFlag);
  }
}
