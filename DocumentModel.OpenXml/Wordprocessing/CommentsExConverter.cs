using DocumentModel.Wordprocessing;
using CommentsEx = DocumentFormat.OpenXml.Office2013.Word.CommentsEx;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the CommentsEx Class.
/// </summary>
public static class CommentsExConverter
{
  public static Collection<CommentEx>? GetCommentExs(CommentsEx? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<CommentEx>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Word.CommentEx>())
      {
        var newItem = CommentExConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetCommentExs(CommentsEx? openXmlElement, Collection<CommentEx>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Word.CommentEx>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CommentExConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.CommentEx>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.CommentsEx? CreateModelElement(CommentsEx? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CommentsEx();
      value.CommentExs = GetCommentExs(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CommentsEx? value)
    where OpenXmlElementType : CommentsEx, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCommentExs(openXmlElement, value?.CommentExs);
      return openXmlElement;
    }
    return default;
  }
}