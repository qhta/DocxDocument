using DocumentModel.Wordprocessing;
using CommentsIds = DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the CommentsIds Class.
/// </summary>
public static class CommentsIdsConverter
{
  public static Collection<CommentId>? GetCommentIds(CommentsIds? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<CommentId>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId>())
      {
        var newItem = CommentIdConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetCommentIds(CommentsIds? openXmlElement, Collection<CommentId>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CommentIdConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.CommentsIds? CreateModelElement(CommentsIds? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CommentsIds();
      value.CommentIds = GetCommentIds(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CommentsIds? value)
    where OpenXmlElementType : CommentsIds, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCommentIds(openXmlElement, value?.CommentIds);
      return openXmlElement;
    }
    return default;
  }
}