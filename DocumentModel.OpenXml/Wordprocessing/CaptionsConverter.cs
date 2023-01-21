namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Caption Settings.
/// </summary>
public static class CaptionsConverter
{
  private static DMW.Caption? GetCaption(DXW.Captions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Caption>();
    if (itemElement != null)
      return DMXW.CaptionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCaption(DXW.Captions openXmlElement, DMW.Caption? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Caption>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CaptionConverter.CreateOpenXmlElement<DXW.Caption>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.AutoCaptions? GetAutoCaptions(DXW.Captions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.AutoCaptions>();
    if (itemElement != null)
      return DMXW.AutoCaptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAutoCaptions(DXW.Captions openXmlElement, DMW.AutoCaptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AutoCaptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.AutoCaptionsConverter.CreateOpenXmlElement<DXW.AutoCaptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Captions? CreateModelElement(DXW.Captions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Captions();
      value.Caption = GetCaption(openXmlElement);
      value.AutoCaptions = GetAutoCaptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Captions? value)
    where OpenXmlElementType: DXW.Captions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCaption(openXmlElement, value?.Caption);
      SetAutoCaptions(openXmlElement, value?.AutoCaptions);
      return openXmlElement;
    }
    return default;
  }
}
