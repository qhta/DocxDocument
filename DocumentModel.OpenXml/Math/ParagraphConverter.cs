namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Defines the Paragraph Class.
/// </summary>
public static class ParagraphConverter
{
  /// <summary>
  /// Office Math Paragraph Properties.
  /// </summary>
  public static DocumentModel.Math.ParagraphProperties? GetParagraphProperties(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraphProperties(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Math.ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.OfficeMath? GetOfficeMath(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.OfficeMath>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.OfficeMathConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeMath(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Math.OfficeMath? value)
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
  
  public static DocumentModel.Math.Run? GetRun(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Run>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.RunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRun(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Math.Run? value)
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
  
  public static DocumentModel.Wordprocessing.ProofError? GetProofError(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetProofError(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.ProofError? value)
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
  
  public static DocumentModel.Wordprocessing.PermStart? GetPermStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPermStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.PermStart? value)
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
  
  public static DocumentModel.Wordprocessing.PermEnd? GetPermEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermEndConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPermEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.PermEnd? value)
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
  
  public static DocumentModel.Wordprocessing.BookmarkStart? GetBookmarkStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBookmarkStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.BookmarkStart? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetBookmarkEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBookmarkEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveFromRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveFromRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveToRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveToRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
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
  
  public static DocumentModel.Wordprocessing.InsertedRun? GetInsertedRun(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.InsertedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetInsertedRun(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.InsertedRun? value)
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
  
  public static DocumentModel.Wordprocessing.DeletedRun? GetDeletedRun(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DeletedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDeletedRun(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.DeletedRun? value)
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
  
  public static DocumentModel.Wordprocessing.MoveFromRun? GetMoveFromRun(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromRun(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MoveFromRun? value)
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
  
  public static DocumentModel.Wordprocessing.MoveToRun? GetMoveToRun(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveToRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToRun(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.MoveToRun? value)
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
  
  public static DocumentModel.Wordprocessing.RunConflictInsertion? GetRunConflictInsertion(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunConflictInsertion(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.RunConflictInsertion? value)
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
  
  public static DocumentModel.Wordprocessing.RunConflictDeletion? GetRunConflictDeletion(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunConflictDeletion(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement, DocumentModel.Wordprocessing.RunConflictDeletion? value)
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
  
  public static DocumentModel.Math.Paragraph? CreateModelElement(DocumentFormat.OpenXml.Math.Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Paragraph();
      value.ParagraphProperties = GetParagraphProperties(openXmlElement);
      value.OfficeMath = GetOfficeMath(openXmlElement);
      value.Run = GetRun(openXmlElement);
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
      value.DeletedRun = GetDeletedRun(openXmlElement);
      value.MoveFromRun = GetMoveFromRun(openXmlElement);
      value.MoveToRun = GetMoveToRun(openXmlElement);
      value.RunConflictInsertion = GetRunConflictInsertion(openXmlElement);
      value.RunConflictDeletion = GetRunConflictDeletion(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Paragraph? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Paragraph, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParagraphProperties(openXmlElement, value?.ParagraphProperties);
      return openXmlElement;
    }
    return default;
  }
}
