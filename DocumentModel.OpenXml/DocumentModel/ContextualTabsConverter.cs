namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ContextualTabs Class.
/// </summary>
public static class ContextualTabsConverter
{
  private static Collection<DM.TabSet> GetTabSets(DXO2010CustUI.ContextualTabs openXmlElement)
  {
    var collection = new Collection<DM.TabSet>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.TabSet>())
    {
      var newItem = DMX.TabSetConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetTabSets(DXO2010CustUI.ContextualTabs openXmlElement, Collection<DM.TabSet>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010CustUI.TabSet>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.TabSetConverter.CreateOpenXmlElement<DXO2010CustUI.TabSet>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DM.ContextualTabs? CreateModelElement(DXO2010CustUI.ContextualTabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.ContextualTabs();
      value.TabSets = GetTabSets(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.ContextualTabs? value)
    where OpenXmlElementType: DXO2010CustUI.ContextualTabs, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTabSets(openXmlElement, value?.TabSets);
      return openXmlElement;
    }
    return default;
  }
}
