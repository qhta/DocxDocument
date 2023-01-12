namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtRunRuby Class.
/// </summary>
public static class SdtRunRubyConverter
{
  /// <summary>
  /// SdtContentRunRuby.
  /// </summary>
  public static DocumentModel.Wordprocessing.SdtContentRunRuby? GetSdtContentRunRuby(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentRunRuby>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtContentRunRubyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSdtContentRunRuby(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.SdtContentRunRuby? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentRunRuby>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SdtContentRunRubyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentRunRuby>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtProperties? GetSdtProperties(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSdtProperties(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.SdtProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SdtPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtEndCharProperties? GetSdtEndCharProperties(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtEndCharPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSdtEndCharProperties(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.SdtEndCharProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SdtEndCharPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtEndCharProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.BookmarkStart? GetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.BookmarkStart? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
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
  
  public static DocumentModel.Wordprocessing.SdtRunRuby? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtRunRuby();
      value.SdtContentRunRuby = GetSdtContentRunRuby(openXmlElement);
      value.SdtProperties = GetSdtProperties(openXmlElement);
      value.SdtEndCharProperties = GetSdtEndCharProperties(openXmlElement);
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
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtRunRuby? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtRunRuby, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSdtContentRunRuby(openXmlElement, value?.SdtContentRunRuby);
      return openXmlElement;
    }
    return default;
  }
}
