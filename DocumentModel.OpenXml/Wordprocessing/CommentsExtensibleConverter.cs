using DocumentModel.Wordprocessing;
using CommentsExtensible = DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the CommentsExtensible Class.
/// </summary>
public static class CommentsExtensibleConverter
{
  public static Collection<CommentExtensible>? GetCommentExtensibles(CommentsExtensible? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<CommentExtensible>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible>())
      {
        var newItem = CommentExtensibleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetCommentExtensibles(CommentsExtensible? openXmlElement, Collection<CommentExtensible>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = CommentExtensibleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.ExtensionList? GetExtensionList(CommentsExtensible? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(CommentsExtensible? openXmlElement, DocumentModel.Wordprocessing.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.CommentsExtensible? CreateModelElement(CommentsExtensible? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CommentsExtensible();
      value.CommentExtensibles = GetCommentExtensibles(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CommentsExtensible? value)
    where OpenXmlElementType : CommentsExtensible, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCommentExtensibles(openXmlElement, value?.CommentExtensibles);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}