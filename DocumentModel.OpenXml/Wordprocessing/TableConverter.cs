namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Table Class.
/// </summary>
public static class TableConverter
{
  private static DocumentModel.Wordprocessing.BookmarkStart? GetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.BookmarkStart? value)
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
  
  private static DocumentModel.Wordprocessing.MarkupRangeType? GetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  private static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  private static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  private static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
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
  
  private static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  private static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
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
  
  private static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  private static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  private static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  private static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  private static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  private static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  private static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  private static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  private static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  private static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
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
  
  private static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
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
  
  private static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
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
  
  private static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
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
  
  private static DocumentModel.Wordprocessing.TableProperties? GetTableProperties(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TablePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableProperties(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.TableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TablePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TableGrid? GetTableGrid(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableGrid>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableGridConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableGrid(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.TableGrid? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableGrid>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableGridConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableGrid>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.TableRow> GetTableRows(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.TableRow>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.TableRow>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.TableRowConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetTableRows(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.TableRow>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.TableRow>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.TableRowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableRow>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Wordprocessing.CustomXmlRow? GetCustomXmlRow(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CustomXmlRowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomXmlRow(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.CustomXmlRow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.CustomXmlRowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtRow? GetSdtRow(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtRowConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtRow(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.SdtRow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SdtRowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtRow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.ProofError? GetProofError(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetProofError(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.ProofError? value)
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
  
  private static DocumentModel.Wordprocessing.PermStart? GetPermStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPermStart(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.PermStart? value)
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
  
  private static DocumentModel.Wordprocessing.PermEnd? GetPermEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermEndConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPermEnd(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.PermEnd? value)
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
  
  private static DocumentModel.Wordprocessing.InsertedRun? GetInsertedRun(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.InsertedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInsertedRun(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.InsertedRun? value)
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
  
  private static DocumentModel.Wordprocessing.DeletedRun? GetDeletedRun(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DeletedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDeletedRun(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.DeletedRun? value)
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
  
  private static DocumentModel.Wordprocessing.MoveFromRun? GetMoveFromRun(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveFromRun(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MoveFromRun? value)
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
  
  private static DocumentModel.Wordprocessing.MoveToRun? GetMoveToRun(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveToRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveToRun(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.MoveToRun? value)
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
  
  private static DocumentModel.Wordprocessing.RunConflictInsertion? GetRunConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.RunConflictInsertion? value)
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
  
  private static DocumentModel.Wordprocessing.RunConflictDeletion? GetRunConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.Table openXmlElement, DocumentModel.Wordprocessing.RunConflictDeletion? value)
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
  
  public static DocumentModel.Wordprocessing.Table? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Table? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Table();
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
      value.TableProperties = GetTableProperties(openXmlElement);
      value.TableGrid = GetTableGrid(openXmlElement);
      value.TableRows = GetTableRows(openXmlElement);
      value.CustomXmlRow = GetCustomXmlRow(openXmlElement);
      value.SdtRow = GetSdtRow(openXmlElement);
      value.ProofError = GetProofError(openXmlElement);
      value.PermStart = GetPermStart(openXmlElement);
      value.PermEnd = GetPermEnd(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Table? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Table, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBookmarkStart(openXmlElement, value?.BookmarkStart);
      SetBookmarkEnd(openXmlElement, value?.BookmarkEnd);
      SetCommentRangeStart(openXmlElement, value?.CommentRangeStart);
      SetCommentRangeEnd(openXmlElement, value?.CommentRangeEnd);
      SetMoveFromRangeStart(openXmlElement, value?.MoveFromRangeStart);
      SetMoveFromRangeEnd(openXmlElement, value?.MoveFromRangeEnd);
      SetMoveToRangeStart(openXmlElement, value?.MoveToRangeStart);
      SetMoveToRangeEnd(openXmlElement, value?.MoveToRangeEnd);
      SetCustomXmlInsRangeStart(openXmlElement, value?.CustomXmlInsRangeStart);
      SetCustomXmlInsRangeEnd(openXmlElement, value?.CustomXmlInsRangeEnd);
      SetCustomXmlDelRangeStart(openXmlElement, value?.CustomXmlDelRangeStart);
      SetCustomXmlDelRangeEnd(openXmlElement, value?.CustomXmlDelRangeEnd);
      SetCustomXmlMoveFromRangeStart(openXmlElement, value?.CustomXmlMoveFromRangeStart);
      SetCustomXmlMoveFromRangeEnd(openXmlElement, value?.CustomXmlMoveFromRangeEnd);
      SetCustomXmlMoveToRangeStart(openXmlElement, value?.CustomXmlMoveToRangeStart);
      SetCustomXmlMoveToRangeEnd(openXmlElement, value?.CustomXmlMoveToRangeEnd);
      SetCustomXmlConflictInsertionRangeStart(openXmlElement, value?.CustomXmlConflictInsertionRangeStart);
      SetCustomXmlConflictInsertionRangeEnd(openXmlElement, value?.CustomXmlConflictInsertionRangeEnd);
      SetCustomXmlConflictDeletionRangeStart(openXmlElement, value?.CustomXmlConflictDeletionRangeStart);
      SetCustomXmlConflictDeletionRangeEnd(openXmlElement, value?.CustomXmlConflictDeletionRangeEnd);
      SetTableProperties(openXmlElement, value?.TableProperties);
      SetTableGrid(openXmlElement, value?.TableGrid);
      SetTableRows(openXmlElement, value?.TableRows);
      SetCustomXmlRow(openXmlElement, value?.CustomXmlRow);
      SetSdtRow(openXmlElement, value?.SdtRow);
      SetProofError(openXmlElement, value?.ProofError);
      SetPermStart(openXmlElement, value?.PermStart);
      SetPermEnd(openXmlElement, value?.PermEnd);
      SetInsertedRun(openXmlElement, value?.InsertedRun);
      SetDeletedRun(openXmlElement, value?.DeletedRun);
      SetMoveFromRun(openXmlElement, value?.MoveFromRun);
      SetMoveToRun(openXmlElement, value?.MoveToRun);
      SetRunConflictInsertion(openXmlElement, value?.RunConflictInsertion);
      SetRunConflictDeletion(openXmlElement, value?.RunConflictDeletion);
      return openXmlElement;
    }
    return default;
  }
}
