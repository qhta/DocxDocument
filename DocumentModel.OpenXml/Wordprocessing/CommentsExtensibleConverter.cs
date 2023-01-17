namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentsExtensible Class.
/// </summary>
public static class CommentsExtensibleConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CommentExtensible> GetCommentExtensibles(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CommentExtensible>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.CommentExtensibleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetCommentExtensibles(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CommentExtensible>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.CommentExtensibleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Wordprocessing.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible openXmlElement, DocumentModel.Wordprocessing.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.CommentsExtensible? CreateModelElement(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible, new()
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
