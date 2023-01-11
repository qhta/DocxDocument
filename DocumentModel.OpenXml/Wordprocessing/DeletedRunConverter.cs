namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Deleted Run Content.
/// </summary>
public static class DeletedRunConverter
{
  public static DocumentModel.Wordprocessing.SdtRun? GetSdtRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSdtRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.SdtRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SdtRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.ProofError? GetProofError(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetProofError(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.ProofError? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ProofErrorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ProofError>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.PermStart? GetPermStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPermStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.PermStart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.PermStartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PermStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.PermEnd? GetPermEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermEndConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPermEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.PermEnd? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.PermEndConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PermEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.BookmarkStart? GetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.BookmarkStart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.BookmarkStartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.InsertedRun? GetInsertedRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.InsertedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetInsertedRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.InsertedRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.InsertedRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DeletedRun? GetChildDeletedRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DeletedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChildDeletedRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.DeletedRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.DeletedRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MoveFromRun? GetMoveFromRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MoveFromRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MoveFromRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MoveToRun? GetMoveToRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveToRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.MoveToRun? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MoveToRunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.RunConflictInsertion? GetRunConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.RunConflictInsertion? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RunConflictInsertionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.RunConflictDeletion? GetRunConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.RunConflictDeletion? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RunConflictDeletionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Paragraph? GetParagraph(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Paragraph>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraph(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Paragraph? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Paragraph>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.ParagraphConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Paragraph>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.OfficeMath? GetOfficeMath(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.OfficeMath>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.OfficeMathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeMath(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.OfficeMath? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.OfficeMath>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.OfficeMathConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.OfficeMath>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Accent? GetAccent(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Accent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.AccentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAccent(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Accent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Accent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.AccentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Accent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Bar? GetBar(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Bar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBar(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Bar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Bar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.BarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Bar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Box? GetBox(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Box>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBox(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Box? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Box>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.BoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Box>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.BorderBox? GetBorderBox(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BorderBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBorderBox(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.BorderBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.BorderBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BorderBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Delimiter? GetDelimiter(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Delimiter>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.DelimiterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDelimiter(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Delimiter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Delimiter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.DelimiterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Delimiter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.EquationArray? GetEquationArray(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArray>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.EquationArrayConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEquationArray(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.EquationArray? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArray>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.EquationArrayConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.EquationArray>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Fraction? GetFraction(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Fraction>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.FractionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFraction(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Fraction? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Fraction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.FractionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Fraction>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.MathFunction? GetMathFunction(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.MathFunction>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.MathFunctionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMathFunction(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.MathFunction? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MathFunction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.MathFunctionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.MathFunction>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.GroupChar? GetGroupChar(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.GroupChar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.GroupCharConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGroupChar(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.GroupChar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.GroupChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.GroupCharConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.GroupChar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.LimitLower? GetLimitLower(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLower>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.LimitLowerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLimitLower(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.LimitLower? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLower>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.LimitLowerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLower>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.LimitUpper? GetLimitUpper(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpper>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.LimitUpperConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLimitUpper(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.LimitUpper? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpper>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.LimitUpperConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitUpper>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Matrix? GetMatrix(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Matrix>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.MatrixConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMatrix(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Matrix? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Matrix>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.MatrixConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Matrix>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Nary? GetNary(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Nary>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.NaryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNary(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Nary? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Nary>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.NaryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Nary>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Phantom? GetPhantom(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Phantom>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.PhantomConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPhantom(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Phantom? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Phantom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.PhantomConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Phantom>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Radical? GetRadical(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Radical>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.RadicalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRadical(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Radical? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Radical>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.RadicalConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Radical>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.PreSubSuper? GetPreSubSuper(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.PreSubSuperConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPreSubSuper(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.PreSubSuper? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.PreSubSuperConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.PreSubSuper>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Subscript? GetSubscript(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Subscript>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SubscriptConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSubscript(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Subscript? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Subscript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.SubscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Subscript>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.SubSuperscript? GetSubSuperscript(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SubSuperscriptConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSubSuperscript(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.SubSuperscript? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.SubSuperscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SubSuperscript>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Superscript? GetSuperscript(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Superscript>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.SuperscriptConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSuperscript(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Superscript? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Superscript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.SuperscriptConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Superscript>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.Run? GetRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Run>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.RunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRun(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Math.Run? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Run>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.RunConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Run>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.BidirectionalOverride? GetBidirectionalOverride(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BidirectionalOverrideConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBidirectionalOverride(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.BidirectionalOverride? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.BidirectionalOverrideConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.BidirectionalEmbedding? GetBidirectionalEmbedding(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BidirectionalEmbeddingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBidirectionalEmbedding(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement, DocumentModel.Wordprocessing.BidirectionalEmbedding? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.BidirectionalEmbeddingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DeletedRun? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DeletedRun? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DeletedRun();
      value.SdtRun = GetSdtRun(openXmlElement);
      value.ProofError = GetProofError(openXmlElement);
      value.PermStart = GetPermStart(openXmlElement);
      value.PermEnd = GetPermEnd(openXmlElement);
      value.BookmarkStart = GetBookmarkStart(openXmlElement);
      value.BookmarkEnd = GetBookmarkEnd(openXmlElement);
      value.CommentRangeStart = GetCommentRangeStart(openXmlElement);
      value.CommentRangeEnd = GetCommentRangeEnd(openXmlElement);
      value.MoveFromRangeStart = GetMoveFromRangeStart(openXmlElement);
      value.MoveFromRangeEnd = GetMoveFromRangeEnd(openXmlElement);
      value.MoveToRangeStart = GetMoveToRangeStart(openXmlElement);
      value.MoveToRangeEnd = GetMoveToRangeEnd(openXmlElement);
      value.CustomXmlInsRangeStart = GetCustomXmlInsRangeStart(openXmlElement);
      value.CustomXmlInsRangeEnd = GetCustomXmlInsRangeEnd(openXmlElement);
      value.CustomXmlDelRangeStart = GetCustomXmlDelRangeStart(openXmlElement);
      value.CustomXmlDelRangeEnd = GetCustomXmlDelRangeEnd(openXmlElement);
      value.CustomXmlMoveFromRangeStart = GetCustomXmlMoveFromRangeStart(openXmlElement);
      value.CustomXmlMoveFromRangeEnd = GetCustomXmlMoveFromRangeEnd(openXmlElement);
      value.CustomXmlMoveToRangeStart = GetCustomXmlMoveToRangeStart(openXmlElement);
      value.CustomXmlMoveToRangeEnd = GetCustomXmlMoveToRangeEnd(openXmlElement);
      value.CustomXmlConflictInsertionRangeStart = GetCustomXmlConflictInsertionRangeStart(openXmlElement);
      value.CustomXmlConflictInsertionRangeEnd = GetCustomXmlConflictInsertionRangeEnd(openXmlElement);
      value.CustomXmlConflictDeletionRangeStart = GetCustomXmlConflictDeletionRangeStart(openXmlElement);
      value.CustomXmlConflictDeletionRangeEnd = GetCustomXmlConflictDeletionRangeEnd(openXmlElement);
      value.InsertedRun = GetInsertedRun(openXmlElement);
      value.ChildDeletedRun = GetChildDeletedRun(openXmlElement);
      value.MoveFromRun = GetMoveFromRun(openXmlElement);
      value.MoveToRun = GetMoveToRun(openXmlElement);
      value.RunConflictInsertion = GetRunConflictInsertion(openXmlElement);
      value.RunConflictDeletion = GetRunConflictDeletion(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      value.OfficeMath = GetOfficeMath(openXmlElement);
      value.Accent = GetAccent(openXmlElement);
      value.Bar = GetBar(openXmlElement);
      value.Box = GetBox(openXmlElement);
      value.BorderBox = GetBorderBox(openXmlElement);
      value.Delimiter = GetDelimiter(openXmlElement);
      value.EquationArray = GetEquationArray(openXmlElement);
      value.Fraction = GetFraction(openXmlElement);
      value.MathFunction = GetMathFunction(openXmlElement);
      value.GroupChar = GetGroupChar(openXmlElement);
      value.LimitLower = GetLimitLower(openXmlElement);
      value.LimitUpper = GetLimitUpper(openXmlElement);
      value.Matrix = GetMatrix(openXmlElement);
      value.Nary = GetNary(openXmlElement);
      value.Phantom = GetPhantom(openXmlElement);
      value.Radical = GetRadical(openXmlElement);
      value.PreSubSuper = GetPreSubSuper(openXmlElement);
      value.Subscript = GetSubscript(openXmlElement);
      value.SubSuperscript = GetSubSuperscript(openXmlElement);
      value.Superscript = GetSuperscript(openXmlElement);
      value.Run = GetRun(openXmlElement);
      value.BidirectionalOverride = GetBidirectionalOverride(openXmlElement);
      value.BidirectionalEmbedding = GetBidirectionalEmbedding(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DeletedRun? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DeletedRun, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
