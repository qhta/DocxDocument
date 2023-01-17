namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category List.
/// </summary>
public static class StyleDisplayCategoriesConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleDisplayCategory> GetItems(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleDisplayCategory>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Diagrams.StyleDisplayCategoryConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleDisplayCategory>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.StyleDisplayCategoryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.StyleDisplayCategories? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleDisplayCategories();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.StyleDisplayCategories? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories, new()
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
