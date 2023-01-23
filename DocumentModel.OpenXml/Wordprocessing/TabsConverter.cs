namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public static class TabsConverter
{
  private static DMW.TabStop? GetTabStop(DXW.Tabs openXmlElement)
  {
    return DMXW.TabStopConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TabStop>());
  }
  
  private static bool CmpTabStop(DXW.Tabs openXmlElement, DMW.TabStop? value, DiffList? diffs, string? objName)
  {
    return DMXW.TabStopConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.TabStop>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXW.Tabs? openXmlElement, DMW.Tabs? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTabStop(openXmlElement, value.TabStop, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
