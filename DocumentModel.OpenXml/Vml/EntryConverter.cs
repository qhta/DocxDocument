namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Regroup Entry.
/// </summary>
public static class EntryConverter
{
  /// <summary>
  /// New Group ID
  /// </summary>
  private static Int32? GetNew(DXVmlO.Entry openXmlElement)
  {
    return openXmlElement.New?.Value;
  }
  
  private static void SetNew(DXVmlO.Entry openXmlElement, Int32? value)
  {
    openXmlElement.New = value;
  }
  
  /// <summary>
  /// Old Group ID
  /// </summary>
  private static Int32? GetOld(DXVmlO.Entry openXmlElement)
  {
    return openXmlElement.Old?.Value;
  }
  
  private static void SetOld(DXVmlO.Entry openXmlElement, Int32? value)
  {
    openXmlElement.Old = value;
  }
  
  public static DMVml.Entry? CreateModelElement(DXVmlO.Entry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Entry();
      value.New = GetNew(openXmlElement);
      value.Old = GetOld(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Entry? value)
    where OpenXmlElementType: DXVmlO.Entry, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNew(openXmlElement, value?.New);
      SetOld(openXmlElement, value?.Old);
      return openXmlElement;
    }
    return default;
  }
}
