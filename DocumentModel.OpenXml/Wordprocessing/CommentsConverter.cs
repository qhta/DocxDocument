namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public static class CommentsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Comment>? GetItems(DocumentFormat.OpenXml.Wordprocessing.Comments? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Comment>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Comment>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.CommentConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Wordprocessing.Comments? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Comment>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Comment>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.CommentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Comment>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Comments? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Comments? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Comments();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Comments? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Comments, new()
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
