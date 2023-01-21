namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Automatic Captioning Settings.
/// </summary>
public static class AutoCaptionsConverter
{
  private static DMW.AutoCaption? GetAutoCaption(DXW.AutoCaptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.AutoCaption>();
    if (itemElement != null)
      return DMXW.AutoCaptionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAutoCaption(DXW.AutoCaptions openXmlElement, DMW.AutoCaption? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AutoCaption>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.AutoCaptionConverter.CreateOpenXmlElement<DXW.AutoCaption>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.AutoCaptions? CreateModelElement(DXW.AutoCaptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AutoCaptions();
      value.AutoCaption = GetAutoCaption(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.AutoCaptions? value)
    where OpenXmlElementType: DXW.AutoCaptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAutoCaption(openXmlElement, value?.AutoCaption);
      return openXmlElement;
    }
    return default;
  }
}
