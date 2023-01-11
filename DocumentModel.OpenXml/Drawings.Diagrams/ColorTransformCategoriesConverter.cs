namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Color Transform Category List.
/// </summary>
public static class ColorTransformCategoriesConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorTransformCategory>? GetItems(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorTransformCategory>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ColorTransformCategoryConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorTransformCategory>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ColorTransformCategoryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorTransformCategories? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorTransformCategories();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorTransformCategories? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
