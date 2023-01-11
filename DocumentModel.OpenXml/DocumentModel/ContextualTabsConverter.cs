namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ContextualTabs Class.
/// </summary>
public static class ContextualTabsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.TabSet>? GetTabSets(DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.TabSet>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.TabSet>())
      {
        var newItem = DocumentModel.OpenXml.TabSetConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetTabSets(DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.TabSet>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.TabSet>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.TabSetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.TabSet>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.ContextualTabs? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ContextualTabs();
      value.TabSets = GetTabSets(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.ContextualTabs? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
