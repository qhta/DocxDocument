using DocumentModel.UI;
using ContextualTabSets = DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets;

namespace DocumentModel.OpenXml.UI;

/// <summary>
///   Defines the ContextualTabSets Class.
/// </summary>
public static class ContextualTabSetsConverter
{
  public static Collection<ContextualTabSet>? GetItems(ContextualTabSets? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ContextualTabSet>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet>())
      {
        var newItem = ContextualTabSetConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(ContextualTabSets? openXmlElement, Collection<ContextualTabSet>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ContextualTabSetConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.UI.ContextualTabSets? CreateModelElement(ContextualTabSets? openXmlElement)
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
    where OpenXmlElementType : ContextualTabSets, new()
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