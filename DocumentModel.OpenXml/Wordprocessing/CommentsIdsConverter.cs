namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentsIds Class.
/// </summary>
public static class CommentsIdsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CommentId>? GetCommentIds(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CommentId>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.CommentIdConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetCommentIds(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CommentId>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.CommentIdConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.CommentsIds? CreateModelElement(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
