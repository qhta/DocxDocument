using DocumentModel.Wordprocessing;
using Comments = DocumentFormat.OpenXml.Wordprocessing.Comments;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Comments Collection.
/// </summary>
public static class CommentsConverter
{
  public static Collection<Comment>? GetItems(Comments? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Comment>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Comment>())
      {
        var newItem = CommentConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(Comments? openXmlElement, Collection<Comment>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Comment>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CommentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Comment>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Comments? CreateModelElement(Comments? openXmlElement)
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
    where OpenXmlElementType : Comments, new()
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