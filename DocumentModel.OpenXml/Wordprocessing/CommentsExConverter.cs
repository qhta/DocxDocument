namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentsEx Class.
/// </summary>
public static class CommentsExConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CommentEx>? GetCommentExs(DocumentFormat.OpenXml.Office2013.Word.CommentsEx? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CommentEx>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Word.CommentEx>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.CommentExConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetCommentExs(DocumentFormat.OpenXml.Office2013.Word.CommentsEx? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.CommentEx>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Word.CommentEx>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.CommentExConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.CommentEx>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.CommentsEx? CreateModelElement(DocumentFormat.OpenXml.Office2013.Word.CommentsEx? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Word.CommentsEx, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
