namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the ContextualTabs Class.
/// </summary>
public static class ContextualTabsConverter
{
  public static Collection<TabSet>? GetTabSets(DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<TabSet>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.TabSet>())
      {
        var newItem = TabSetConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetTabSets(DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs? openXmlElement, Collection<TabSet>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.TabSet>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = TabSetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.TabSet>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static ContextualTabs? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new ContextualTabs();
      value.TabSets = GetTabSets(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(ContextualTabs? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs, new()
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