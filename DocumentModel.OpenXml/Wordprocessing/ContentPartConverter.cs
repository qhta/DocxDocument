namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public static class ContentPartConverter
{
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXW.ContentPart openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.ContentPart openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.ContentPart? CreateModelElement(DXW.ContentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ContentPart();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ContentPart? value)
    where OpenXmlElementType: DXW.ContentPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
