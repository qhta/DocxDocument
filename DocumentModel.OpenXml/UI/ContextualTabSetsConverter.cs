namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the ContextualTabSets Class.
/// </summary>
public static class ContextualTabSetsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.UI.ContextualTabSet>? GetItems(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.UI.ContextualTabSet>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet>())
      {
        var newItem = DocumentModel.OpenXml.UI.ContextualTabSetConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.UI.ContextualTabSet>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.UI.ContextualTabSetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.UI.ContextualTabSets? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.ContextualTabSets();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.ContextualTabSets? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
