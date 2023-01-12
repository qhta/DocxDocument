namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Category List.
/// </summary>
public static class CategoryListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Category>? GetCategories(DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Category>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Category>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.CategoryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetCategories(DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Category>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Category>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.CategoryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Category>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.CategoryList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.CategoryList();
      value.Categories = GetCategories(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.CategoryList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
