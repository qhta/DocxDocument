namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Paragraph Class.
/// </summary>
public static class ParagraphConverter
{
  /// <summary>
  /// Revision Identifier for Paragraph Glyph Formatting
  /// </summary>
  private static UInt32? GetRsidParagraphMarkRevision(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement.RsidParagraphMarkRevision?.Value != null)
      return UInt32.Parse(openXmlElement.RsidParagraphMarkRevision.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpRsidParagraphMarkRevision(DXW.Paragraph openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.RsidParagraphMarkRevision?.Value != null)
      return UInt32.Parse(openXmlElement.RsidParagraphMarkRevision.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetRsidParagraphMarkRevision(DXW.Paragraph openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidParagraphMarkRevision = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidParagraphMarkRevision = null;
  }
  
  /// <summary>
  /// Revision Identifier for Paragraph
  /// </summary>
  private static UInt32? GetRsidParagraphAddition(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement.RsidParagraphAddition?.Value != null)
      return UInt32.Parse(openXmlElement.RsidParagraphAddition.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpRsidParagraphAddition(DXW.Paragraph openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.RsidParagraphAddition?.Value != null)
      return UInt32.Parse(openXmlElement.RsidParagraphAddition.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetRsidParagraphAddition(DXW.Paragraph openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidParagraphAddition = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidParagraphAddition = null;
  }
  
  /// <summary>
  /// Revision Identifier for Paragraph Deletion
  /// </summary>
  private static UInt32? GetRsidParagraphDeletion(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement.RsidParagraphDeletion?.Value != null)
      return UInt32.Parse(openXmlElement.RsidParagraphDeletion.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpRsidParagraphDeletion(DXW.Paragraph openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.RsidParagraphDeletion?.Value != null)
      return UInt32.Parse(openXmlElement.RsidParagraphDeletion.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetRsidParagraphDeletion(DXW.Paragraph openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidParagraphDeletion = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidParagraphDeletion = null;
  }
  
  /// <summary>
  /// Revision Identifier for Paragraph Properties
  /// </summary>
  private static UInt32? GetRsidParagraphProperties(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement.RsidParagraphProperties?.Value != null)
      return UInt32.Parse(openXmlElement.RsidParagraphProperties.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpRsidParagraphProperties(DXW.Paragraph openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.RsidParagraphProperties?.Value != null)
      return UInt32.Parse(openXmlElement.RsidParagraphProperties.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetRsidParagraphProperties(DXW.Paragraph openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidParagraphProperties = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidParagraphProperties = null;
  }
  
  /// <summary>
  /// Default Revision Identifier for Runs
  /// </summary>
  private static UInt32? GetRsidRunAdditionDefault(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement.RsidRunAdditionDefault?.Value != null)
      return UInt32.Parse(openXmlElement.RsidRunAdditionDefault.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpRsidRunAdditionDefault(DXW.Paragraph openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.RsidRunAdditionDefault?.Value != null)
      return UInt32.Parse(openXmlElement.RsidRunAdditionDefault.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetRsidRunAdditionDefault(DXW.Paragraph openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.RsidRunAdditionDefault = ((UInt32)value).ToString("X8");
      else
        openXmlElement.RsidRunAdditionDefault = null;
  }
  
  /// <summary>
  /// paraId, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetParagraphId(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement.ParagraphId?.Value != null)
      return UInt32.Parse(openXmlElement.ParagraphId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpParagraphId(DXW.Paragraph openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.ParagraphId?.Value != null)
      return UInt32.Parse(openXmlElement.ParagraphId.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetParagraphId(DXW.Paragraph openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.ParagraphId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.ParagraphId = null;
  }
  
  /// <summary>
  /// textId, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetTextId(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement.TextId?.Value != null)
      return UInt32.Parse(openXmlElement.TextId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpTextId(DXW.Paragraph openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.TextId?.Value != null)
      return UInt32.Parse(openXmlElement.TextId.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetTextId(DXW.Paragraph openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.TextId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.TextId = null;
  }
  
  /// <summary>
  /// noSpellErr, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetNoSpellError(DXW.Paragraph openXmlElement)
  {
    return openXmlElement?.NoSpellError?.Value;
  }
  
  private static bool CmpNoSpellError(DXW.Paragraph openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoSpellError?.Value == value;
  }
  
  private static void SetNoSpellError(DXW.Paragraph openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoSpellError = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.NoSpellError = null;
  }
  
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  private static DMW.ParagraphProperties? GetParagraphProperties(DXW.Paragraph openXmlElement)
  {
    return DMXW.ParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ParagraphProperties>());
  }
  
  private static bool CmpParagraphProperties(DXW.Paragraph openXmlElement, DMW.ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraphProperties(DXW.Paragraph openXmlElement, DMW.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphPropertiesConverter.CreateOpenXmlElement<DXW.ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlRun? GetCustomXmlRun(DXW.Paragraph openXmlElement)
  {
    return DMXW.CustomXmlRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlRun>());
  }
  
  private static bool CmpCustomXmlRun(DXW.Paragraph openXmlElement, DMW.CustomXmlRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.CustomXmlRunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlRun(DXW.Paragraph openXmlElement, DMW.CustomXmlRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CustomXmlRunConverter.CreateOpenXmlElement<DXW.CustomXmlRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.SimpleField> GetSimpleFields(DXW.Paragraph openXmlElement)
  {
    var collection = new Collection<DMW.SimpleField>();
    foreach (var item in openXmlElement.Elements<DXW.SimpleField>())
    {
      var newItem = DMXW.SimpleFieldConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpSimpleFields(DXW.Paragraph openXmlElement, Collection<DMW.SimpleField>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetSimpleFields(DXW.Paragraph openXmlElement, Collection<DMW.SimpleField>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.SimpleField>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.SimpleFieldConverter.CreateOpenXmlElement<DXW.SimpleField>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMW.Hyperlink? GetHyperlink(DXW.Paragraph openXmlElement)
  {
    return DMXW.HyperlinkConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Hyperlink>());
  }
  
  private static bool CmpHyperlink(DXW.Paragraph openXmlElement, DMW.Hyperlink? value, DiffList? diffs, string? objName)
  {
    return DMXW.HyperlinkConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.Hyperlink>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlink(DXW.Paragraph openXmlElement, DMW.Hyperlink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.HyperlinkConverter.CreateOpenXmlElement<DXW.Hyperlink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtRun? GetSdtRun(DXW.Paragraph openXmlElement)
  {
    return DMXW.SdtRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtRun>());
  }
  
  private static bool CmpSdtRun(DXW.Paragraph openXmlElement, DMW.SdtRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtRunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.SdtRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSdtRun(DXW.Paragraph openXmlElement, DMW.SdtRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtRunConverter.CreateOpenXmlElement<DXW.SdtRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ProofError? GetProofError(DXW.Paragraph openXmlElement)
  {
    return DMXW.ProofErrorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ProofError>());
  }
  
  private static bool CmpProofError(DXW.Paragraph openXmlElement, DMW.ProofError? value, DiffList? diffs, string? objName)
  {
    return DMXW.ProofErrorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.ProofError>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetProofError(DXW.Paragraph openXmlElement, DMW.ProofError? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ProofError>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ProofErrorConverter.CreateOpenXmlElement<DXW.ProofError>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermStart? GetPermStart(DXW.Paragraph openXmlElement)
  {
    return DMXW.PermStartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PermStart>());
  }
  
  private static bool CmpPermStart(DXW.Paragraph openXmlElement, DMW.PermStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermStartConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.PermStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPermStart(DXW.Paragraph openXmlElement, DMW.PermStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermStartConverter.CreateOpenXmlElement<DXW.PermStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermEnd? GetPermEnd(DXW.Paragraph openXmlElement)
  {
    return DMXW.PermEndConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PermEnd>());
  }
  
  private static bool CmpPermEnd(DXW.Paragraph openXmlElement, DMW.PermEnd? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermEndConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.PermEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPermEnd(DXW.Paragraph openXmlElement, DMW.PermEnd? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermEndConverter.CreateOpenXmlElement<DXW.PermEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BookmarkStart? GetBookmarkStart(DXW.Paragraph openXmlElement)
  {
    return DMXW.BookmarkStartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkStart>());
  }
  
  private static bool CmpBookmarkStart(DXW.Paragraph openXmlElement, DMW.BookmarkStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.BookmarkStartConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkStart(DXW.Paragraph openXmlElement, DMW.BookmarkStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookmarkStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BookmarkStartConverter.CreateOpenXmlElement<DXW.BookmarkStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetBookmarkEnd(DXW.Paragraph openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkEnd>());
  }
  
  private static bool CmpBookmarkEnd(DXW.Paragraph openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkEnd(DXW.Paragraph openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookmarkEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.BookmarkEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetCommentRangeStart(DXW.Paragraph openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeStart>());
  }
  
  private static bool CmpCommentRangeStart(DXW.Paragraph openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeStart(DXW.Paragraph openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CommentRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.CommentRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetCommentRangeEnd(DXW.Paragraph openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>());
  }
  
  private static bool CmpCommentRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CommentRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.CommentRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveBookmarkType? GetMoveFromRangeStart(DXW.Paragraph openXmlElement)
  {
    return DMXW.MoveBookmarkTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>());
  }
  
  private static bool CmpMoveFromRangeStart(DXW.Paragraph openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeStart(DXW.Paragraph openXmlElement, DMW.MoveBookmarkType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement<DXW.MoveFromRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetMoveFromRangeEnd(DXW.Paragraph openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>());
  }
  
  private static bool CmpMoveFromRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.MoveFromRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveBookmarkType? GetMoveToRangeStart(DXW.Paragraph openXmlElement)
  {
    return DMXW.MoveBookmarkTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>());
  }
  
  private static bool CmpMoveToRangeStart(DXW.Paragraph openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeStart(DXW.Paragraph openXmlElement, DMW.MoveBookmarkType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement<DXW.MoveToRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupRangeType? GetMoveToRangeEnd(DXW.Paragraph openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>());
  }
  
  private static bool CmpMoveToRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupRangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.MoveToRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlInsRangeStart(DXW.Paragraph openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>());
  }
  
  private static bool CmpCustomXmlInsRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlInsRangeEnd(DXW.Paragraph openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>());
  }
  
  private static bool CmpCustomXmlInsRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlDelRangeStart(DXW.Paragraph openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>());
  }
  
  private static bool CmpCustomXmlDelRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlDelRangeEnd(DXW.Paragraph openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>());
  }
  
  private static bool CmpCustomXmlDelRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlMoveFromRangeStart(DXW.Paragraph openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>());
  }
  
  private static bool CmpCustomXmlMoveFromRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlMoveFromRangeEnd(DXW.Paragraph openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>());
  }
  
  private static bool CmpCustomXmlMoveFromRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType? GetCustomXmlMoveToRangeStart(DXW.Paragraph openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>());
  }
  
  private static bool CmpCustomXmlMoveToRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType? GetCustomXmlMoveToRangeEnd(DXW.Paragraph openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>());
  }
  
  private static bool CmpCustomXmlMoveToRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DXW.Paragraph openXmlElement)
  {
    return DMXW.TrackChangeType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>());
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DXW.Paragraph openXmlElement)
  {
    return DMXW.MarkupType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>());
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DXW.Paragraph openXmlElement)
  {
    return DMXW.TrackChangeType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>());
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeStart(DXW.Paragraph openXmlElement, DMW.TrackChangeType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DXW.Paragraph openXmlElement)
  {
    return DMXW.MarkupType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>());
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeEnd(DXW.Paragraph openXmlElement, DMW.MarkupType2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.InsertedRun? GetInsertedRun(DXW.Paragraph openXmlElement)
  {
    return DMXW.InsertedRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.InsertedRun>());
  }
  
  private static bool CmpInsertedRun(DXW.Paragraph openXmlElement, DMW.InsertedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.InsertedRunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.InsertedRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInsertedRun(DXW.Paragraph openXmlElement, DMW.InsertedRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsertedRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.InsertedRunConverter.CreateOpenXmlElement<DXW.InsertedRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DeletedRun? GetDeletedRun(DXW.Paragraph openXmlElement)
  {
    return DMXW.DeletedRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DeletedRun>());
  }
  
  private static bool CmpDeletedRun(DXW.Paragraph openXmlElement, DMW.DeletedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.DeletedRunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.DeletedRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDeletedRun(DXW.Paragraph openXmlElement, DMW.DeletedRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DeletedRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DeletedRunConverter.CreateOpenXmlElement<DXW.DeletedRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveFromRun? GetMoveFromRun(DXW.Paragraph openXmlElement)
  {
    return DMXW.MoveFromRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRun>());
  }
  
  private static bool CmpMoveFromRun(DXW.Paragraph openXmlElement, DMW.MoveFromRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveFromRunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRun(DXW.Paragraph openXmlElement, DMW.MoveFromRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveFromRunConverter.CreateOpenXmlElement<DXW.MoveFromRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveToRun? GetMoveToRun(DXW.Paragraph openXmlElement)
  {
    return DMXW.MoveToRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRun>());
  }
  
  private static bool CmpMoveToRun(DXW.Paragraph openXmlElement, DMW.MoveToRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveToRunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRun(DXW.Paragraph openXmlElement, DMW.MoveToRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveToRunConverter.CreateOpenXmlElement<DXW.MoveToRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RunConflictInsertion? GetRunConflictInsertion(DXW.Paragraph openXmlElement)
  {
    return DMXW.RunConflictInsertionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>());
  }
  
  private static bool CmpRunConflictInsertion(DXW.Paragraph openXmlElement, DMW.RunConflictInsertion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictInsertionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunConflictInsertion(DXW.Paragraph openXmlElement, DMW.RunConflictInsertion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.RunConflictInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunConflictInsertionConverter.CreateOpenXmlElement<DXO2010W.RunConflictInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RunConflictDeletion? GetRunConflictDeletion(DXW.Paragraph openXmlElement)
  {
    return DMXW.RunConflictDeletionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>());
  }
  
  private static bool CmpRunConflictDeletion(DXW.Paragraph openXmlElement, DMW.RunConflictDeletion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictDeletionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunConflictDeletion(DXW.Paragraph openXmlElement, DMW.RunConflictDeletion? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.RunConflictDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunConflictDeletionConverter.CreateOpenXmlElement<DXO2010W.RunConflictDeletion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Paragraph? GetChildParagraph(DXW.Paragraph openXmlElement)
  {
    return DMXMath.ParagraphConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Paragraph>());
  }
  
  private static bool CmpChildParagraph(DXW.Paragraph openXmlElement, DMMath.Paragraph? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ParagraphConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Paragraph>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildParagraph(DXW.Paragraph openXmlElement, DMMath.Paragraph? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Paragraph>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ParagraphConverter.CreateOpenXmlElement<DXMath.Paragraph>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.OfficeMath? GetOfficeMath(DXW.Paragraph openXmlElement)
  {
    return DMXMath.OfficeMathConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.OfficeMath>());
  }
  
  private static bool CmpOfficeMath(DXW.Paragraph openXmlElement, DMMath.OfficeMath? value, DiffList? diffs, string? objName)
  {
    return DMXMath.OfficeMathConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.OfficeMath>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeMath(DXW.Paragraph openXmlElement, DMMath.OfficeMath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.OfficeMath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.OfficeMathConverter.CreateOpenXmlElement<DXMath.OfficeMath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Accent? GetAccent(DXW.Paragraph openXmlElement)
  {
    return DMXMath.AccentConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Accent>());
  }
  
  private static bool CmpAccent(DXW.Paragraph openXmlElement, DMMath.Accent? value, DiffList? diffs, string? objName)
  {
    return DMXMath.AccentConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Accent>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAccent(DXW.Paragraph openXmlElement, DMMath.Accent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Accent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.AccentConverter.CreateOpenXmlElement<DXMath.Accent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Bar? GetBar(DXW.Paragraph openXmlElement)
  {
    return DMXMath.BarConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Bar>());
  }
  
  private static bool CmpBar(DXW.Paragraph openXmlElement, DMMath.Bar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BarConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Bar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBar(DXW.Paragraph openXmlElement, DMMath.Bar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Bar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BarConverter.CreateOpenXmlElement<DXMath.Bar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Box? GetBox(DXW.Paragraph openXmlElement)
  {
    return DMXMath.BoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Box>());
  }
  
  private static bool CmpBox(DXW.Paragraph openXmlElement, DMMath.Box? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BoxConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Box>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBox(DXW.Paragraph openXmlElement, DMMath.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BoxConverter.CreateOpenXmlElement<DXMath.Box>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.BorderBox? GetBorderBox(DXW.Paragraph openXmlElement)
  {
    return DMXMath.BorderBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.BorderBox>());
  }
  
  private static bool CmpBorderBox(DXW.Paragraph openXmlElement, DMMath.BorderBox? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BorderBoxConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.BorderBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBorderBox(DXW.Paragraph openXmlElement, DMMath.BorderBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BorderBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BorderBoxConverter.CreateOpenXmlElement<DXMath.BorderBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Delimiter? GetDelimiter(DXW.Paragraph openXmlElement)
  {
    return DMXMath.DelimiterConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Delimiter>());
  }
  
  private static bool CmpDelimiter(DXW.Paragraph openXmlElement, DMMath.Delimiter? value, DiffList? diffs, string? objName)
  {
    return DMXMath.DelimiterConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Delimiter>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDelimiter(DXW.Paragraph openXmlElement, DMMath.Delimiter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Delimiter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.DelimiterConverter.CreateOpenXmlElement<DXMath.Delimiter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.EquationArray? GetEquationArray(DXW.Paragraph openXmlElement)
  {
    return DMXMath.EquationArrayConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.EquationArray>());
  }
  
  private static bool CmpEquationArray(DXW.Paragraph openXmlElement, DMMath.EquationArray? value, DiffList? diffs, string? objName)
  {
    return DMXMath.EquationArrayConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.EquationArray>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEquationArray(DXW.Paragraph openXmlElement, DMMath.EquationArray? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.EquationArray>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.EquationArrayConverter.CreateOpenXmlElement<DXMath.EquationArray>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Fraction? GetFraction(DXW.Paragraph openXmlElement)
  {
    return DMXMath.FractionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Fraction>());
  }
  
  private static bool CmpFraction(DXW.Paragraph openXmlElement, DMMath.Fraction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FractionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Fraction>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFraction(DXW.Paragraph openXmlElement, DMMath.Fraction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Fraction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.FractionConverter.CreateOpenXmlElement<DXMath.Fraction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.MathFunction? GetMathFunction(DXW.Paragraph openXmlElement)
  {
    return DMXMath.MathFunctionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.MathFunction>());
  }
  
  private static bool CmpMathFunction(DXW.Paragraph openXmlElement, DMMath.MathFunction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MathFunctionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.MathFunction>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMathFunction(DXW.Paragraph openXmlElement, DMMath.MathFunction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MathFunction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MathFunctionConverter.CreateOpenXmlElement<DXMath.MathFunction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.GroupChar? GetGroupChar(DXW.Paragraph openXmlElement)
  {
    return DMXMath.GroupCharConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.GroupChar>());
  }
  
  private static bool CmpGroupChar(DXW.Paragraph openXmlElement, DMMath.GroupChar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.GroupCharConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.GroupChar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGroupChar(DXW.Paragraph openXmlElement, DMMath.GroupChar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.GroupChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.GroupCharConverter.CreateOpenXmlElement<DXMath.GroupChar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitLower? GetLimitLower(DXW.Paragraph openXmlElement)
  {
    return DMXMath.LimitLowerConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.LimitLower>());
  }
  
  private static bool CmpLimitLower(DXW.Paragraph openXmlElement, DMMath.LimitLower? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitLowerConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.LimitLower>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimitLower(DXW.Paragraph openXmlElement, DMMath.LimitLower? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitLower>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitLowerConverter.CreateOpenXmlElement<DXMath.LimitLower>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitUpper? GetLimitUpper(DXW.Paragraph openXmlElement)
  {
    return DMXMath.LimitUpperConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.LimitUpper>());
  }
  
  private static bool CmpLimitUpper(DXW.Paragraph openXmlElement, DMMath.LimitUpper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitUpperConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.LimitUpper>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimitUpper(DXW.Paragraph openXmlElement, DMMath.LimitUpper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitUpper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitUpperConverter.CreateOpenXmlElement<DXMath.LimitUpper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Matrix? GetMatrix(DXW.Paragraph openXmlElement)
  {
    return DMXMath.MatrixConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Matrix>());
  }
  
  private static bool CmpMatrix(DXW.Paragraph openXmlElement, DMMath.Matrix? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MatrixConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Matrix>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMatrix(DXW.Paragraph openXmlElement, DMMath.Matrix? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Matrix>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MatrixConverter.CreateOpenXmlElement<DXMath.Matrix>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Nary? GetNary(DXW.Paragraph openXmlElement)
  {
    return DMXMath.NaryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Nary>());
  }
  
  private static bool CmpNary(DXW.Paragraph openXmlElement, DMMath.Nary? value, DiffList? diffs, string? objName)
  {
    return DMXMath.NaryConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Nary>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNary(DXW.Paragraph openXmlElement, DMMath.Nary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Nary>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.NaryConverter.CreateOpenXmlElement<DXMath.Nary>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Phantom? GetPhantom(DXW.Paragraph openXmlElement)
  {
    return DMXMath.PhantomConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Phantom>());
  }
  
  private static bool CmpPhantom(DXW.Paragraph openXmlElement, DMMath.Phantom? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PhantomConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Phantom>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPhantom(DXW.Paragraph openXmlElement, DMMath.Phantom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Phantom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PhantomConverter.CreateOpenXmlElement<DXMath.Phantom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Radical? GetRadical(DXW.Paragraph openXmlElement)
  {
    return DMXMath.RadicalConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Radical>());
  }
  
  private static bool CmpRadical(DXW.Paragraph openXmlElement, DMMath.Radical? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RadicalConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Radical>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRadical(DXW.Paragraph openXmlElement, DMMath.Radical? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Radical>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RadicalConverter.CreateOpenXmlElement<DXMath.Radical>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.PreSubSuper? GetPreSubSuper(DXW.Paragraph openXmlElement)
  {
    return DMXMath.PreSubSuperConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.PreSubSuper>());
  }
  
  private static bool CmpPreSubSuper(DXW.Paragraph openXmlElement, DMMath.PreSubSuper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PreSubSuperConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.PreSubSuper>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreSubSuper(DXW.Paragraph openXmlElement, DMMath.PreSubSuper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.PreSubSuper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PreSubSuperConverter.CreateOpenXmlElement<DXMath.PreSubSuper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Subscript? GetSubscript(DXW.Paragraph openXmlElement)
  {
    return DMXMath.SubscriptConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Subscript>());
  }
  
  private static bool CmpSubscript(DXW.Paragraph openXmlElement, DMMath.Subscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubscriptConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Subscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSubscript(DXW.Paragraph openXmlElement, DMMath.Subscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Subscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubscriptConverter.CreateOpenXmlElement<DXMath.Subscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.SubSuperscript? GetSubSuperscript(DXW.Paragraph openXmlElement)
  {
    return DMXMath.SubSuperscriptConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.SubSuperscript>());
  }
  
  private static bool CmpSubSuperscript(DXW.Paragraph openXmlElement, DMMath.SubSuperscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubSuperscriptConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.SubSuperscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSubSuperscript(DXW.Paragraph openXmlElement, DMMath.SubSuperscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SubSuperscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubSuperscriptConverter.CreateOpenXmlElement<DXMath.SubSuperscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Superscript? GetSuperscript(DXW.Paragraph openXmlElement)
  {
    return DMXMath.SuperscriptConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Superscript>());
  }
  
  private static bool CmpSuperscript(DXW.Paragraph openXmlElement, DMMath.Superscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SuperscriptConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Superscript>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSuperscript(DXW.Paragraph openXmlElement, DMMath.Superscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Superscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SuperscriptConverter.CreateOpenXmlElement<DXMath.Superscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Run? GetRun(DXW.Paragraph openXmlElement)
  {
    return DMXMath.RunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Run>());
  }
  
  private static bool CmpRun(DXW.Paragraph openXmlElement, DMMath.Run? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RunConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Run>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRun(DXW.Paragraph openXmlElement, DMMath.Run? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Run>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RunConverter.CreateOpenXmlElement<DXMath.Run>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BidirectionalOverride? GetBidirectionalOverride(DXW.Paragraph openXmlElement)
  {
    return DMXW.BidirectionalOverrideConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BidirectionalOverride>());
  }
  
  private static bool CmpBidirectionalOverride(DXW.Paragraph openXmlElement, DMW.BidirectionalOverride? value, DiffList? diffs, string? objName)
  {
    return DMXW.BidirectionalOverrideConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.BidirectionalOverride>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBidirectionalOverride(DXW.Paragraph openXmlElement, DMW.BidirectionalOverride? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BidirectionalOverride>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BidirectionalOverrideConverter.CreateOpenXmlElement<DXW.BidirectionalOverride>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BidirectionalEmbedding? GetBidirectionalEmbedding(DXW.Paragraph openXmlElement)
  {
    return DMXW.BidirectionalEmbeddingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BidirectionalEmbedding>());
  }
  
  private static bool CmpBidirectionalEmbedding(DXW.Paragraph openXmlElement, DMW.BidirectionalEmbedding? value, DiffList? diffs, string? objName)
  {
    return DMXW.BidirectionalEmbeddingConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.BidirectionalEmbedding>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBidirectionalEmbedding(DXW.Paragraph openXmlElement, DMW.BidirectionalEmbedding? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BidirectionalEmbedding>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BidirectionalEmbeddingConverter.CreateOpenXmlElement<DXW.BidirectionalEmbedding>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RelationshipType? GetSubDocumentReference(DXW.Paragraph openXmlElement)
  {
    return DMXW.RelationshipTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SubDocumentReference>());
  }
  
  private static bool CmpSubDocumentReference(DXW.Paragraph openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.SubDocumentReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSubDocumentReference(DXW.Paragraph openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SubDocumentReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.SubDocumentReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Paragraph? CreateModelElement(DXW.Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Paragraph();
      value.RsidParagraphMarkRevision = GetRsidParagraphMarkRevision(openXmlElement);
      value.RsidParagraphAddition = GetRsidParagraphAddition(openXmlElement);
      value.RsidParagraphDeletion = GetRsidParagraphDeletion(openXmlElement);
      value.RsidParagraphProperties = GetRsidParagraphProperties(openXmlElement);
      value.RsidRunAdditionDefault = GetRsidRunAdditionDefault(openXmlElement);
      value.ParagraphId = GetParagraphId(openXmlElement);
      value.TextId = GetTextId(openXmlElement);
      value.NoSpellError = GetNoSpellError(openXmlElement);
      value.ParagraphProperties = GetParagraphProperties(openXmlElement);
      value.CustomXmlRun = GetCustomXmlRun(openXmlElement);
      value.SimpleFields = GetSimpleFields(openXmlElement);
      value.Hyperlink = GetHyperlink(openXmlElement);
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
      value.DeletedRun = GetDeletedRun(openXmlElement);
      value.MoveFromRun = GetMoveFromRun(openXmlElement);
      value.MoveToRun = GetMoveToRun(openXmlElement);
      value.RunConflictInsertion = GetRunConflictInsertion(openXmlElement);
      value.RunConflictDeletion = GetRunConflictDeletion(openXmlElement);
      value.ChildParagraph = GetChildParagraph(openXmlElement);
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
      value.SubDocumentReference = GetSubDocumentReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Paragraph? openXmlElement, DMW.Paragraph? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRsidParagraphMarkRevision(openXmlElement, value.RsidParagraphMarkRevision, diffs, objName))
        ok = false;
      if (!CmpRsidParagraphAddition(openXmlElement, value.RsidParagraphAddition, diffs, objName))
        ok = false;
      if (!CmpRsidParagraphDeletion(openXmlElement, value.RsidParagraphDeletion, diffs, objName))
        ok = false;
      if (!CmpRsidParagraphProperties(openXmlElement, value.RsidParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpRsidRunAdditionDefault(openXmlElement, value.RsidRunAdditionDefault, diffs, objName))
        ok = false;
      if (!CmpParagraphId(openXmlElement, value.ParagraphId, diffs, objName))
        ok = false;
      if (!CmpTextId(openXmlElement, value.TextId, diffs, objName))
        ok = false;
      if (!CmpNoSpellError(openXmlElement, value.NoSpellError, diffs, objName))
        ok = false;
      if (!CmpParagraphProperties(openXmlElement, value.ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpCustomXmlRun(openXmlElement, value.CustomXmlRun, diffs, objName))
        ok = false;
      if (!CmpSimpleFields(openXmlElement, value.SimpleFields, diffs, objName))
        ok = false;
      if (!CmpHyperlink(openXmlElement, value.Hyperlink, diffs, objName))
        ok = false;
      if (!CmpSdtRun(openXmlElement, value.SdtRun, diffs, objName))
        ok = false;
      if (!CmpProofError(openXmlElement, value.ProofError, diffs, objName))
        ok = false;
      if (!CmpPermStart(openXmlElement, value.PermStart, diffs, objName))
        ok = false;
      if (!CmpPermEnd(openXmlElement, value.PermEnd, diffs, objName))
        ok = false;
      if (!CmpBookmarkStart(openXmlElement, value.BookmarkStart, diffs, objName))
        ok = false;
      if (!CmpBookmarkEnd(openXmlElement, value.BookmarkEnd, diffs, objName))
        ok = false;
      if (!CmpCommentRangeStart(openXmlElement, value.CommentRangeStart, diffs, objName))
        ok = false;
      if (!CmpCommentRangeEnd(openXmlElement, value.CommentRangeEnd, diffs, objName))
        ok = false;
      if (!CmpMoveFromRangeStart(openXmlElement, value.MoveFromRangeStart, diffs, objName))
        ok = false;
      if (!CmpMoveFromRangeEnd(openXmlElement, value.MoveFromRangeEnd, diffs, objName))
        ok = false;
      if (!CmpMoveToRangeStart(openXmlElement, value.MoveToRangeStart, diffs, objName))
        ok = false;
      if (!CmpMoveToRangeEnd(openXmlElement, value.MoveToRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlInsRangeStart(openXmlElement, value.CustomXmlInsRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlInsRangeEnd(openXmlElement, value.CustomXmlInsRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlDelRangeStart(openXmlElement, value.CustomXmlDelRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlDelRangeEnd(openXmlElement, value.CustomXmlDelRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveFromRangeStart(openXmlElement, value.CustomXmlMoveFromRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveFromRangeEnd(openXmlElement, value.CustomXmlMoveFromRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveToRangeStart(openXmlElement, value.CustomXmlMoveToRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlMoveToRangeEnd(openXmlElement, value.CustomXmlMoveToRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictInsertionRangeStart(openXmlElement, value.CustomXmlConflictInsertionRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictInsertionRangeEnd(openXmlElement, value.CustomXmlConflictInsertionRangeEnd, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictDeletionRangeStart(openXmlElement, value.CustomXmlConflictDeletionRangeStart, diffs, objName))
        ok = false;
      if (!CmpCustomXmlConflictDeletionRangeEnd(openXmlElement, value.CustomXmlConflictDeletionRangeEnd, diffs, objName))
        ok = false;
      if (!CmpInsertedRun(openXmlElement, value.InsertedRun, diffs, objName))
        ok = false;
      if (!CmpDeletedRun(openXmlElement, value.DeletedRun, diffs, objName))
        ok = false;
      if (!CmpMoveFromRun(openXmlElement, value.MoveFromRun, diffs, objName))
        ok = false;
      if (!CmpMoveToRun(openXmlElement, value.MoveToRun, diffs, objName))
        ok = false;
      if (!CmpRunConflictInsertion(openXmlElement, value.RunConflictInsertion, diffs, objName))
        ok = false;
      if (!CmpRunConflictDeletion(openXmlElement, value.RunConflictDeletion, diffs, objName))
        ok = false;
      if (!CmpChildParagraph(openXmlElement, value.ChildParagraph, diffs, objName))
        ok = false;
      if (!CmpOfficeMath(openXmlElement, value.OfficeMath, diffs, objName))
        ok = false;
      if (!CmpAccent(openXmlElement, value.Accent, diffs, objName))
        ok = false;
      if (!CmpBar(openXmlElement, value.Bar, diffs, objName))
        ok = false;
      if (!CmpBox(openXmlElement, value.Box, diffs, objName))
        ok = false;
      if (!CmpBorderBox(openXmlElement, value.BorderBox, diffs, objName))
        ok = false;
      if (!CmpDelimiter(openXmlElement, value.Delimiter, diffs, objName))
        ok = false;
      if (!CmpEquationArray(openXmlElement, value.EquationArray, diffs, objName))
        ok = false;
      if (!CmpFraction(openXmlElement, value.Fraction, diffs, objName))
        ok = false;
      if (!CmpMathFunction(openXmlElement, value.MathFunction, diffs, objName))
        ok = false;
      if (!CmpGroupChar(openXmlElement, value.GroupChar, diffs, objName))
        ok = false;
      if (!CmpLimitLower(openXmlElement, value.LimitLower, diffs, objName))
        ok = false;
      if (!CmpLimitUpper(openXmlElement, value.LimitUpper, diffs, objName))
        ok = false;
      if (!CmpMatrix(openXmlElement, value.Matrix, diffs, objName))
        ok = false;
      if (!CmpNary(openXmlElement, value.Nary, diffs, objName))
        ok = false;
      if (!CmpPhantom(openXmlElement, value.Phantom, diffs, objName))
        ok = false;
      if (!CmpRadical(openXmlElement, value.Radical, diffs, objName))
        ok = false;
      if (!CmpPreSubSuper(openXmlElement, value.PreSubSuper, diffs, objName))
        ok = false;
      if (!CmpSubscript(openXmlElement, value.Subscript, diffs, objName))
        ok = false;
      if (!CmpSubSuperscript(openXmlElement, value.SubSuperscript, diffs, objName))
        ok = false;
      if (!CmpSuperscript(openXmlElement, value.Superscript, diffs, objName))
        ok = false;
      if (!CmpRun(openXmlElement, value.Run, diffs, objName))
        ok = false;
      if (!CmpBidirectionalOverride(openXmlElement, value.BidirectionalOverride, diffs, objName))
        ok = false;
      if (!CmpBidirectionalEmbedding(openXmlElement, value.BidirectionalEmbedding, diffs, objName))
        ok = false;
      if (!CmpSubDocumentReference(openXmlElement, value.SubDocumentReference, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Paragraph? value)
    where OpenXmlElementType: DXW.Paragraph, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRsidParagraphMarkRevision(openXmlElement, value?.RsidParagraphMarkRevision);
      SetRsidParagraphAddition(openXmlElement, value?.RsidParagraphAddition);
      SetRsidParagraphDeletion(openXmlElement, value?.RsidParagraphDeletion);
      SetRsidParagraphProperties(openXmlElement, value?.RsidParagraphProperties);
      SetRsidRunAdditionDefault(openXmlElement, value?.RsidRunAdditionDefault);
      SetParagraphId(openXmlElement, value?.ParagraphId);
      SetTextId(openXmlElement, value?.TextId);
      SetNoSpellError(openXmlElement, value?.NoSpellError);
      SetParagraphProperties(openXmlElement, value?.ParagraphProperties);
      SetCustomXmlRun(openXmlElement, value?.CustomXmlRun);
      SetSimpleFields(openXmlElement, value?.SimpleFields);
      SetHyperlink(openXmlElement, value?.Hyperlink);
      SetSdtRun(openXmlElement, value?.SdtRun);
      SetProofError(openXmlElement, value?.ProofError);
      SetPermStart(openXmlElement, value?.PermStart);
      SetPermEnd(openXmlElement, value?.PermEnd);
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
      SetInsertedRun(openXmlElement, value?.InsertedRun);
      SetDeletedRun(openXmlElement, value?.DeletedRun);
      SetMoveFromRun(openXmlElement, value?.MoveFromRun);
      SetMoveToRun(openXmlElement, value?.MoveToRun);
      SetRunConflictInsertion(openXmlElement, value?.RunConflictInsertion);
      SetRunConflictDeletion(openXmlElement, value?.RunConflictDeletion);
      SetChildParagraph(openXmlElement, value?.ChildParagraph);
      SetOfficeMath(openXmlElement, value?.OfficeMath);
      SetAccent(openXmlElement, value?.Accent);
      SetBar(openXmlElement, value?.Bar);
      SetBox(openXmlElement, value?.Box);
      SetBorderBox(openXmlElement, value?.BorderBox);
      SetDelimiter(openXmlElement, value?.Delimiter);
      SetEquationArray(openXmlElement, value?.EquationArray);
      SetFraction(openXmlElement, value?.Fraction);
      SetMathFunction(openXmlElement, value?.MathFunction);
      SetGroupChar(openXmlElement, value?.GroupChar);
      SetLimitLower(openXmlElement, value?.LimitLower);
      SetLimitUpper(openXmlElement, value?.LimitUpper);
      SetMatrix(openXmlElement, value?.Matrix);
      SetNary(openXmlElement, value?.Nary);
      SetPhantom(openXmlElement, value?.Phantom);
      SetRadical(openXmlElement, value?.Radical);
      SetPreSubSuper(openXmlElement, value?.PreSubSuper);
      SetSubscript(openXmlElement, value?.Subscript);
      SetSubSuperscript(openXmlElement, value?.SubSuperscript);
      SetSuperscript(openXmlElement, value?.Superscript);
      SetRun(openXmlElement, value?.Run);
      SetBidirectionalOverride(openXmlElement, value?.BidirectionalOverride);
      SetBidirectionalEmbedding(openXmlElement, value?.BidirectionalEmbedding);
      SetSubDocumentReference(openXmlElement, value?.SubDocumentReference);
      return openXmlElement;
    }
    return default;
  }
}
