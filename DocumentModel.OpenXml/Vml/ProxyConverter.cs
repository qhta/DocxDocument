namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Reference.
/// </summary>
public static class ProxyConverter
{
  /// <summary>
  /// Start Point Connection Flag
  /// </summary>
  private static Boolean? GetStart(DXVO.Proxy openXmlElement)
  {
    return openXmlElement?.Start?.Value;
  }
  
  private static bool CmpStart(DXVO.Proxy openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Start?.Value == value) return true;
    diffs?.Add(objName, "Start", openXmlElement?.Start?.Value, value);
    return false;
  }
  
  private static void SetStart(DXVO.Proxy openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Start = value;
    else
      openXmlElement.Start = null;
  }
  
  /// <summary>
  /// End Point Connection Flag
  /// </summary>
  private static Boolean? GetEnd(DXVO.Proxy openXmlElement)
  {
    return openXmlElement?.End?.Value;
  }
  
  private static bool CmpEnd(DXVO.Proxy openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.End?.Value == value) return true;
    diffs?.Add(objName, "End", openXmlElement?.End?.Value, value);
    return false;
  }
  
  private static void SetEnd(DXVO.Proxy openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.End = value;
    else
      openXmlElement.End = null;
  }
  
  /// <summary>
  /// Proxy Shape Reference
  /// </summary>
  private static String? GetShapeReference(DXVO.Proxy openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShapeReference);
  }
  
  private static bool CmpShapeReference(DXVO.Proxy openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShapeReference, value, diffs, objName, "ShapeReference");
  }
  
  private static void SetShapeReference(DXVO.Proxy openXmlElement, String? value)
  {
    openXmlElement.ShapeReference = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Connection Location
  /// </summary>
  private static Int32? GetConnectionLocation(DXVO.Proxy openXmlElement)
  {
    return openXmlElement?.ConnectionLocation?.Value;
  }
  
  private static bool CmpConnectionLocation(DXVO.Proxy openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ConnectionLocation?.Value == value) return true;
    diffs?.Add(objName, "ConnectionLocation", openXmlElement?.ConnectionLocation?.Value, value);
    return false;
  }
  
  private static void SetConnectionLocation(DXVO.Proxy openXmlElement, Int32? value)
  {
    openXmlElement.ConnectionLocation = value;
  }
  
  public static DocumentModel.Vml.Proxy? CreateModelElement(DXVO.Proxy? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Proxy();
      value.Start = GetStart(openXmlElement);
      value.End = GetEnd(openXmlElement);
      value.ShapeReference = GetShapeReference(openXmlElement);
      value.ConnectionLocation = GetConnectionLocation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVO.Proxy? openXmlElement, DMV.Proxy? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStart(openXmlElement, value.Start, diffs, objName))
        ok = false;
      if (!CmpEnd(openXmlElement, value.End, diffs, objName))
        ok = false;
      if (!CmpShapeReference(openXmlElement, value.ShapeReference, diffs, objName))
        ok = false;
      if (!CmpConnectionLocation(openXmlElement, value.ConnectionLocation, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Proxy value)
    where OpenXmlElementType: DXVO.Proxy, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.Proxy openXmlElement, DMV.Proxy value)
  {
    SetStart(openXmlElement, value?.Start);
    SetEnd(openXmlElement, value?.End);
    SetShapeReference(openXmlElement, value?.ShapeReference);
    SetConnectionLocation(openXmlElement, value?.ConnectionLocation);
  }
}
