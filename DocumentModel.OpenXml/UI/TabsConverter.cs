namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public static class TabsConverter
{
  private static Collection<DMUI.Tab> GetItems(DXOCustUI.Tabs openXmlElement)
  {
    var collection = new Collection<DMUI.Tab>();
    foreach (var item in openXmlElement.Elements<DXOCustUI.Tab>())
    {
      var newItem = DMXUI.TabConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXOCustUI.Tabs openXmlElement, Collection<DMUI.Tab>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCustUI.Tab>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.TabConverter.CreateOpenXmlElement<DXOCustUI.Tab>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMUI.Tabs? CreateModelElement(DXOCustUI.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.Tabs();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.Tabs? value)
    where OpenXmlElementType: DXOCustUI.Tabs, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
