namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Reference.
/// </summary>
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
    return openXmlElement?.Start?.Value == value;
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
    return openXmlElement?.End?.Value == value;
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
    return openXmlElement?.ShapeReference?.Value;
  }
  
  private static bool CmpShapeReference(DXVmlO.Proxy openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ShapeReference?.Value == value;
  }
  
  private static void SetShapeReference(DXVmlO.Proxy openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ShapeReference = new StringValue { Value = value };
    else
      openXmlElement.ShapeReference = null;
  }
  
  /// <summary>
  /// Connection Location
  /// </summary>
  private static Int32? GetConnectionLocation(DXVmlO.Proxy openXmlElement)
  {
    return openXmlElement.ConnectionLocation?.Value;
  }
  
  private static bool CmpConnectionLocation(DXVmlO.Proxy openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.ConnectionLocation?.Value == value;
  }
  
  private static void SetConnectionLocation(DXVmlO.Proxy openXmlElement, Int32? value)
  {
    openXmlElement.ConnectionLocation = value;
  }
  
  public static DMVml.Proxy? CreateModelElement(DXVmlO.Proxy? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Proxy();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Proxy? value)
    where OpenXmlElementType: DXVmlO.Proxy, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStart(openXmlElement, value?.Start);
      SetEnd(openXmlElement, value?.End);
      SetShapeReference(openXmlElement, value?.ShapeReference);
      SetConnectionLocation(openXmlElement, value?.ConnectionLocation);
      return openXmlElement;
    }
    return default;
  }
}
