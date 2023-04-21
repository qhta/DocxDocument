namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Ink.
/// </summary>
public static class InkConverter
{
  /// <summary>
  /// Ink Data
  /// </summary>
  private static DM.Base64Binary? GetInkData(DXVO.Ink openXmlElement)
  {
    if (openXmlElement?.InkData?.Value != null)
      return Convert.FromBase64String(openXmlElement.InkData.Value);
    return null;
  }
  
  private static bool CmpInkData(DXVO.Ink openXmlElement, DM.Base64Binary? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InkData?.Value != null && value != null)
      if (Convert.FromBase64String(openXmlElement.InkData.Value).SequenceEqual((byte[])value))
        return true;
    if (openXmlElement?.InkData?.Value == null && value == null) return true;
    diffs?.Add(objName, "InkData", openXmlElement?.InkData?.Value, value);
    return false;
  }
  
  private static void SetInkData(DXVO.Ink openXmlElement, DM.Base64Binary? value)
  {
    if (value != null)
      openXmlElement.InkData = Convert.ToBase64String(value);
    else
      openXmlElement.InkData = null;
  }
  
  /// <summary>
  /// Annotation Flag
  /// </summary>
  private static Boolean? GetAnnotationFlag(DXVO.Ink openXmlElement)
  {
    return openXmlElement?.AnnotationFlag?.Value;
  }
  
  private static bool CmpAnnotationFlag(DXVO.Ink openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AnnotationFlag?.Value == value) return true;
    diffs?.Add(objName, "AnnotationFlag", openXmlElement?.AnnotationFlag?.Value, value);
    return false;
  }
  
  private static void SetAnnotationFlag(DXVO.Ink openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnnotationFlag = value;
    else
      openXmlElement.AnnotationFlag = null;
  }
  
  public static DocumentModel.Vml.Ink? CreateModelElement(DXVO.Ink? openXmlElement)
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
  
  public static bool CompareModelElement(DXVO.Ink? openXmlElement, DMV.Ink? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Ink value)
    where OpenXmlElementType: DXVO.Ink, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.Ink openXmlElement, DMV.Ink value)
  {
    SetInkData(openXmlElement, value?.InkData);
    SetAnnotationFlag(openXmlElement, value?.AnnotationFlag);
  }
}
