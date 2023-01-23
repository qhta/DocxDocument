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
    return openXmlElement.Id?.Value;
  }
  
  private static bool CmpId(DXDraw.ConnectionType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Id?.Value == value;
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
    return openXmlElement.Index?.Value;
  }
  
  private static bool CmpIndex(DXDraw.ConnectionType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Index?.Value == value;
  }
  
  private static void SetIndex(DXDraw.ConnectionType openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  public static DMDraws.ConnectionType? CreateModelElement(DXDraw.ConnectionType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ConnectionType();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ConnectionType? value)
    where OpenXmlElementType: DXDraw.ConnectionType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetIndex(openXmlElement, value?.Index);
      return openXmlElement;
    }
    return default;
  }
}
