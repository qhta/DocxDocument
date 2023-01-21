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
