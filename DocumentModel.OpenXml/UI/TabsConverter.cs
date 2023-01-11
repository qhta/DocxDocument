namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public static class TabsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.UI.Tab>? GetItems(DocumentFormat.OpenXml.Office.CustomUI.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.UI.Tab>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.Tab>())
      {
        var newItem = DocumentModel.OpenXml.UI.TabConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office.CustomUI.Tabs? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.UI.Tab>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.Tab>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.UI.TabConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Tab>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.UI.Tabs? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.Tabs();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.Tabs? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.Tabs, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
