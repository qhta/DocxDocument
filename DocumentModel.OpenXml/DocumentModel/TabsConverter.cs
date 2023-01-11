namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public static class TabsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Tab>? GetItems(DocumentFormat.OpenXml.Office2010.CustomUI.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Tab>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>())
      {
        var newItem = DocumentModel.OpenXml.TabConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office2010.CustomUI.Tabs? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Tab>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.TabConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Tabs? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Tabs();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Tabs? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.Tabs, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
