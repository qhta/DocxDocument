namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Audio from File.
/// </summary>
public static class AudioFromFileConverter
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  private static String? GetLink(DXDraw.AudioFromFile openXmlElement)
  {
    return openXmlElement?.Link?.Value;
  }
  
  private static void SetLink(DXDraw.AudioFromFile openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Link = new StringValue { Value = value };
    else
      openXmlElement.Link = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.AudioFromFile openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.AudioFromFile openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.AudioFromFile? CreateModelElement(DXDraw.AudioFromFile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AudioFromFile();
      value.Link = GetLink(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AudioFromFile? value)
    where OpenXmlElementType: DXDraw.AudioFromFile, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLink(openXmlElement, value?.Link);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
