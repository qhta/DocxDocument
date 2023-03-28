namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Reference converter from/to OpenXml.
///</summary>
public static class ProxyConverter
{
  /// <summary>
  /// Start Point Connection Flag
  /// </summary>
  private static Boolean? GetStart(DXVmlO.Proxy openXmlElement)
  {
    return openXmlElement?.Start?.Value;
  }
  
  private static bool CmpStart(DXVmlO.Proxy openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Start?.Value == value) return true;
    diffs?.Add(objName, "Start", openXmlElement?.Start?.Value, value);
    return false;
  }
  
  private static void SetStart(DXVmlO.Proxy openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Start = value;
    else
      openXmlElement.Start = null;
  }
  
  /// <summary>
  /// End Point Connection Flag
  /// </summary>
  private static Boolean? GetEnd(DXVmlO.Proxy openXmlElement)
  {
    return openXmlElement?.End?.Value;
  }
  
  private static bool CmpEnd(DXVmlO.Proxy openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.End?.Value == value) return true;
    diffs?.Add(objName, "End", openXmlElement?.End?.Value, value);
    return false;
  }
  
  private static void SetEnd(DXVmlO.Proxy openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.End = value;
    else
      openXmlElement.End = null;
  }
  
  /// <summary>
  /// Proxy Shape Reference
  /// </summary>
  private static String? GetShapeReference(DXVmlO.Proxy openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShapeReference);
  }
  
  private static bool CmpShapeReference(DXVmlO.Proxy openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShapeReference, value, diffs, objName, "ShapeReference");
  }
  
  private static void SetShapeReference(DXVmlO.Proxy openXmlElement, String? value)
  {
    openXmlElement.ShapeReference = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Connection Location
  /// </summary>
  private static Int32? GetConnectionLocation(DXVmlO.Proxy openXmlElement)
  {
    return openXmlElement?.ConnectionLocation?.Value;
  }
  
  private static bool CmpConnectionLocation(DXVmlO.Proxy openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ConnectionLocation?.Value == value) return true;
    diffs?.Add(objName, "ConnectionLocation", openXmlElement?.ConnectionLocation?.Value, value);
    return false;
  }
  
  private static void SetConnectionLocation(DXVmlO.Proxy openXmlElement, Int32? value)
  {
    openXmlElement.ConnectionLocation = value;
  }
  
  public static DocumentModel.Vml.Proxy? CreateModelElement(DXVmlO.Proxy? openXmlElement)
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
  
  public static bool CompareModelElement(DXVmlO.Proxy? openXmlElement, DMVml.Proxy? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Proxy value)
    where OpenXmlElementType: DXVmlO.Proxy, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.Proxy openXmlElement, DMVml.Proxy value)
  {
    SetStart(openXmlElement, value?.Start);
    SetEnd(openXmlElement, value?.End);
    SetShapeReference(openXmlElement, value?.ShapeReference);
    SetConnectionLocation(openXmlElement, value?.ConnectionLocation);
  }
}
