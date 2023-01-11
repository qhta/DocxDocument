namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Comment Content.
/// </summary>
public static class CommentConverter
{
  /// <summary>
  /// initials
  /// </summary>
  public static String? GetInitials(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    return openXmlElement?.Initials?.Value;
  }
  
  public static void SetInitials(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Initials = new StringValue { Value = value };
      else
        openXmlElement.Initials = null;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  public static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Author = new StringValue { Value = value };
      else
        openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  public static void SetDate(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AltChunk>? GetAltChunks(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AltChunk>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.AltChunk>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.AltChunkConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetAltChunks(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AltChunk>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.AltChunk>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.AltChunkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.AltChunk>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.CustomXmlBlock? GetCustomXmlBlock(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlBlock>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CustomXmlBlockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomXmlBlock(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, DocumentModel.Wordprocessing.CustomXmlBlock? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlBlock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.CustomXmlBlockConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CustomXmlBlock>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtBlock? GetSdtBlock(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtBlock>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtBlockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSdtBlock(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, DocumentModel.Wordprocessing.SdtBlock? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtBlock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.SdtBlockConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtBlock>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Paragraph>? GetParagraphs(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Paragraph>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Paragraph>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.ParagraphConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetParagraphs(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Paragraph>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Paragraph>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.ParagraphConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Table>? GetTables(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Table>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Table>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.TableConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetTables(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.Table>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Table>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.TableConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Table>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.ProofError? GetProofError(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ProofErrorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetProofError(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, DocumentModel.Wordprocessing.ProofError? value)
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
  
  public static DocumentModel.Wordprocessing.PermStart? GetPermStart(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPermStart(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, DocumentModel.Wordprocessing.PermStart? value)
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
  
  public static DocumentModel.Wordprocessing.PermEnd? GetPermEnd(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PermEndConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPermEnd(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, DocumentModel.Wordprocessing.PermEnd? value)
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
  
  public static DocumentModel.Wordprocessing.BookmarkStart? GetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BookmarkStartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBookmarkStart(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, DocumentModel.Wordprocessing.BookmarkStart? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBookmarkEnd(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentRangeStart(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? GetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MarkupRangeTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentRangeEnd(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement, DocumentModel.Wordprocessing.MarkupRangeType? value)
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
  
  public static DocumentModel.Wordprocessing.Comment? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Comment? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Comment();
      value.Initials = GetInitials(openXmlElement);
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.AltChunks = GetAltChunks(openXmlElement);
      value.CustomXmlBlock = GetCustomXmlBlock(openXmlElement);
      value.SdtBlock = GetSdtBlock(openXmlElement);
      value.Paragraphs = GetParagraphs(openXmlElement);
      value.Tables = GetTables(openXmlElement);
      value.ProofError = GetProofError(openXmlElement);
      value.PermStart = GetPermStart(openXmlElement);
      value.PermEnd = GetPermEnd(openXmlElement);
      value.BookmarkStart = GetBookmarkStart(openXmlElement);
      value.BookmarkEnd = GetBookmarkEnd(openXmlElement);
      value.CommentRangeStart = GetCommentRangeStart(openXmlElement);
      value.CommentRangeEnd = GetCommentRangeEnd(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Comment? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Comment, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
