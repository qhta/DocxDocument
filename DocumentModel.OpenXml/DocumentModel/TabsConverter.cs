namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the Tabs Class.
/// </summary>
public static class TabsConverter
{
  public static Collection<Tab>? GetItems(DocumentFormat.OpenXml.Office2010.CustomUI.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Tab>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>())
      {
        var newItem = TabConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(DocumentFormat.OpenXml.Office2010.CustomUI.Tabs? openXmlElement, Collection<Tab>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = TabConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Tabs? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new Tabs();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Tabs? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.Tabs, new()
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