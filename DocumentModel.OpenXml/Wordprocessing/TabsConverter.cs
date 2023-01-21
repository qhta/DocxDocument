namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public static class TabsConverter
{
  private static DMW.TabStop? GetTabStop(DXW.Tabs openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TabStop>();
    if (itemElement != null)
      return DMXW.TabStopConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTabStop(DXW.Tabs openXmlElement, DMW.TabStop? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TabStop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TabStopConverter.CreateOpenXmlElement<DXW.TabStop>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Tabs? CreateModelElement(DXW.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Tabs();
      value.TabStop = GetTabStop(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Tabs? value)
    where OpenXmlElementType: DXW.Tabs, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTabStop(openXmlElement, value?.TabStop);
      return openXmlElement;
    }
    return default;
  }
}
