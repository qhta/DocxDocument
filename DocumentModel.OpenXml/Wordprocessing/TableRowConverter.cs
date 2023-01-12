namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Row.
/// </summary>
public static class TableRowConverter
{
  /// <summary>
  /// Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  public static Byte[]? GetRsidTableRowMarkRevision(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    if (openXmlElement?.RsidTableRowMarkRevision?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidTableRowMarkRevision.Value);
    return null;
  }
  
  public static void SetRsidTableRowMarkRevision(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidTableRowMarkRevision = Convert.ToHexString(value);
      else
        openXmlElement.RsidTableRowMarkRevision = null;
    }
  }
  
  /// <summary>
  /// Revision Identifier for Table Row
  /// </summary>
  public static Byte[]? GetRsidTableRowAddition(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    if (openXmlElement?.RsidTableRowAddition?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidTableRowAddition.Value);
    return null;
  }
  
  public static void SetRsidTableRowAddition(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidTableRowAddition = Convert.ToHexString(value);
      else
        openXmlElement.RsidTableRowAddition = null;
    }
  }
  
  /// <summary>
  /// Revision Identifier for Table Row Deletion
  /// </summary>
  public static Byte[]? GetRsidTableRowDeletion(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    if (openXmlElement?.RsidTableRowDeletion?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidTableRowDeletion.Value);
    return null;
  }
  
  public static void SetRsidTableRowDeletion(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidTableRowDeletion = Convert.ToHexString(value);
      else
        openXmlElement.RsidTableRowDeletion = null;
    }
  }
  
  /// <summary>
  /// Revision Identifier for Table Row Properties
  /// </summary>
  public static Byte[]? GetRsidTableRowProperties(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    if (openXmlElement?.RsidTableRowProperties?.Value != null)
      return Convert.FromHexString(openXmlElement.RsidTableRowProperties.Value);
    return null;
  }
  
  public static void SetRsidTableRowProperties(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.RsidTableRowProperties = Convert.ToHexString(value);
      else
        openXmlElement.RsidTableRowProperties = null;
    }
  }
  
  /// <summary>
  /// paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetParagraphId(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    if (openXmlElement?.ParagraphId?.Value != null)
      return Convert.FromHexString(openXmlElement.ParagraphId.Value);
    return null;
  }
  
  public static void SetParagraphId(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.ParagraphId = Convert.ToHexString(value);
      else
        openXmlElement.ParagraphId = null;
    }
  }
  
  /// <summary>
  /// textId, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetTextId(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    if (openXmlElement?.TextId?.Value != null)
      return Convert.FromHexString(openXmlElement.TextId.Value);
    return null;
  }
  
  public static void SetTextId(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.TextId = Convert.ToHexString(value);
      else
        openXmlElement.TextId = null;
    }
  }
  
  /// <summary>
  /// Table-Level Property Exceptions.
  /// </summary>
  public static DocumentModel.Wordprocessing.TablePropertyExceptions? GetTablePropertyExceptions(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TablePropertyExceptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTablePropertyExceptions(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.TablePropertyExceptions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TablePropertyExceptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TablePropertyExceptions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Table Row Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableRowProperties? GetTableRowProperties(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableRowPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTableRowProperties(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.TableRowProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.TableRowPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableRowProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.TableCell>? GetTableCells(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.TableCell>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.TableCell>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.TableCellConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetTableCells(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.TableCell>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.TableCell>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.TableCellConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCell>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.CustomXmlCell? GetCustomXmlCell(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlCell>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CustomXmlCellConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlCell(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.CustomXmlCell? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlCell>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.CustomXmlCellConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlCell>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtCell? GetSdtCell(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtCell>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtCellConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSdtCell(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.SdtCell? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtCell>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SdtCellConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtCell>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.ProofError? GetProofError(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetProofError(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.ProofError? value)
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
  
  public static DocumentModel.Wordprocessing.PermStart? GetPermStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPermStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.PermStart? value)
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
  
  public static DocumentModel.Wordprocessing.PermEnd? GetPermEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermEndConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPermEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.PermEnd? value)
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
  
  public static DocumentModel.Wordprocessing.BookmarkStart? GetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.BookmarkStart? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MoveBookmarkType? GetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveBookmarkTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MoveBookmarkType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlInsRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlInsRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlDelRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlDelRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveFromRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveFromRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveToRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType? GetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlMoveToRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MarkupType? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictInsertionRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictInsertionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TrackChangeType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictDeletionRangeStart(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupType2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlConflictDeletionRangeEnd(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MarkupType2? value)
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
  
  public static DocumentModel.Wordprocessing.InsertedRun? GetInsertedRun(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.InsertedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetInsertedRun(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.InsertedRun? value)
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
  
  public static DocumentModel.Wordprocessing.DeletedRun? GetDeletedRun(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DeletedRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDeletedRun(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.DeletedRun? value)
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
  
  public static DocumentModel.Wordprocessing.MoveFromRun? GetMoveFromRun(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveFromRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromRun(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MoveFromRun? value)
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
  
  public static DocumentModel.Wordprocessing.MoveToRun? GetMoveToRun(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveToRunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToRun(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.MoveToRun? value)
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
  
  public static DocumentModel.Wordprocessing.RunConflictInsertion? GetRunConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunConflictInsertionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.RunConflictInsertion? value)
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
  
  public static DocumentModel.Wordprocessing.RunConflictDeletion? GetRunConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunConflictDeletionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement, DocumentModel.Wordprocessing.RunConflictDeletion? value)
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
  
  public static DocumentModel.Wordprocessing.TableRow? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableRow();
      value.RsidTableRowMarkRevision = GetRsidTableRowMarkRevision(openXmlElement);
      value.RsidTableRowAddition = GetRsidTableRowAddition(openXmlElement);
      value.RsidTableRowDeletion = GetRsidTableRowDeletion(openXmlElement);
      value.RsidTableRowProperties = GetRsidTableRowProperties(openXmlElement);
      value.ParagraphId = GetParagraphId(openXmlElement);
      value.TextId = GetTextId(openXmlElement);
      value.TablePropertyExceptions = GetTablePropertyExceptions(openXmlElement);
      value.TableRowProperties = GetTableRowProperties(openXmlElement);
      value.TableCells = GetTableCells(openXmlElement);
      value.CustomXmlCell = GetCustomXmlCell(openXmlElement);
      value.SdtCell = GetSdtCell(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableRow? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableRow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRsidTableRowMarkRevision(openXmlElement, value?.RsidTableRowMarkRevision);
      SetRsidTableRowAddition(openXmlElement, value?.RsidTableRowAddition);
      SetRsidTableRowDeletion(openXmlElement, value?.RsidTableRowDeletion);
      SetRsidTableRowProperties(openXmlElement, value?.RsidTableRowProperties);
      SetParagraphId(openXmlElement, value?.ParagraphId);
      SetTextId(openXmlElement, value?.TextId);
      SetTablePropertyExceptions(openXmlElement, value?.TablePropertyExceptions);
      SetTableRowProperties(openXmlElement, value?.TableRowProperties);
      return openXmlElement;
    }
    return default;
  }
}
