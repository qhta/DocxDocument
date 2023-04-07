namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ConnectionType Class.
/// </summary>
public static class ConnectionTypeConverter
{
  /// <summary>
  /// Identifier
  /// </summary>
  private static UInt32? GetId(DXDraw.ConnectionType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXDraw.ConnectionType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "AnnotationId", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXDraw.ConnectionType openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Index
  /// </summary>
  private static UInt32? GetIndex(DXDraw.ConnectionType openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  private static bool CmpIndex(DXDraw.ConnectionType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Index?.Value == value) return true;
    diffs?.Add(objName, "Index", openXmlElement?.Index?.Value, value);
    return false;
  }
  
  private static void SetIndex(DXDraw.ConnectionType openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  public static DocumentModel.Drawings.ConnectionType? CreateModelElement(DXDraw.ConnectionType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectionType();
      value.Id = GetId(openXmlElement);
      value.Index = GetIndex(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ConnectionType? openXmlElement, DMDraws.ConnectionType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ConnectionType value)
    where OpenXmlElementType: DXDraw.ConnectionType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ConnectionType openXmlElement, DMDraws.ConnectionType value)
  {
    SetId(openXmlElement, value?.Id);
    SetIndex(openXmlElement, value?.Index);
  }
}
