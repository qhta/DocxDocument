namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtBlock Class.
/// </summary>
public static class SdtBlockConverter
{
  /// <summary>
  /// Block-Level Structured Document Tag Content.
  /// </summary>
  private static DMW.SdtContentBlock? GetSdtContentBlock(DXW.SdtBlock openXmlElement)
  {
    return DMXW.SdtContentBlockConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtContentBlock>());
  }
  
  private static bool CmpSdtContentBlock(DXW.SdtBlock openXmlElement, DMW.SdtContentBlock? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtContentBlockConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.SdtContentBlock>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSdtContentBlock(DXW.SdtBlock openXmlElement, DMW.SdtContentBlock? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentBlock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtContentBlockConverter.CreateOpenXmlElement<DXW.SdtContentBlock>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtProperties? GetSdtProperties(DXW.SdtBlock openXmlElement)
  {
    return DMXW.SdtPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtProperties>());
  }
  
  private static bool CmpSdtProperties(DXW.SdtBlock openXmlElement, DMW.SdtProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.SdtProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSdtProperties(DXW.SdtBlock openXmlElement, DMW.SdtProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtPropertiesConverter.CreateOpenXmlElement<DXW.SdtProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtEndCharProperties? GetSdtEndCharProperties(DXW.SdtBlock openXmlElement)
  {
    return DMXW.SdtEndCharPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtEndCharProperties>());
  }
  
  private static bool CmpSdtEndCharProperties(DXW.SdtBlock openXmlElement, DMW.SdtEndCharProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtEndCharPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.SdtEndCharProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSdtEndCharProperties(DXW.SdtBlock openXmlElement, DMW.SdtEndCharProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtEndCharProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtEndCharPropertiesConverter.CreateOpenXmlElement<DXW.SdtEndCharProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BookmarkStart? GetBookmarkStart(DXW.SdtBlock openXmlElement)
  {
    return DMXW.BookmarkStartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkStart>());
  }
  
  private static bool CmpBookmarkStart(DXW.SdtBlock openXmlElement, DMW.BookmarkStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.BookmarkStartConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkStart(DXW.SdtBlock openXmlElement, DMW.BookmarkStart? value)
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
  
  private static DMW.MarkupRangeType? GetBookmarkEnd(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkEnd>());
  }
  
  private static bool CmpBookmarkEnd(DXW.SdtBlock openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkEnd(DXW.SdtBlock openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MarkupRangeType? GetCommentRangeStart(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeStart>());
  }
  
  private static bool CmpCommentRangeStart(DXW.SdtBlock openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeStart(DXW.SdtBlock openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MarkupRangeType? GetCommentRangeEnd(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>());
  }
  
  private static bool CmpCommentRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MoveBookmarkType? GetMoveFromRangeStart(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MoveBookmarkTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>());
  }
  
  private static bool CmpMoveFromRangeStart(DXW.SdtBlock openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeStart(DXW.SdtBlock openXmlElement, DMW.MoveBookmarkType? value)
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
  
  private static DMW.MarkupRangeType? GetMoveFromRangeEnd(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>());
  }
  
  private static bool CmpMoveFromRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MoveBookmarkType? GetMoveToRangeStart(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MoveBookmarkTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>());
  }
  
  private static bool CmpMoveToRangeStart(DXW.SdtBlock openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeStart(DXW.SdtBlock openXmlElement, DMW.MoveBookmarkType? value)
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
  
  private static DMW.MarkupRangeType? GetMoveToRangeEnd(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>());
  }
  
  private static bool CmpMoveToRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlInsRangeStart(DXW.SdtBlock openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>());
  }
  
  private static bool CmpCustomXmlInsRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlInsRangeEnd(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>());
  }
  
  private static bool CmpCustomXmlInsRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlDelRangeStart(DXW.SdtBlock openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>());
  }
  
  private static bool CmpCustomXmlDelRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlDelRangeEnd(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>());
  }
  
  private static bool CmpCustomXmlDelRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlMoveFromRangeStart(DXW.SdtBlock openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>());
  }
  
  private static bool CmpCustomXmlMoveFromRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlMoveFromRangeEnd(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>());
  }
  
  private static bool CmpCustomXmlMoveFromRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlMoveToRangeStart(DXW.SdtBlock openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>());
  }
  
  private static bool CmpCustomXmlMoveToRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlMoveToRangeEnd(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>());
  }
  
  private static bool CmpCustomXmlMoveToRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DXW.SdtBlock openXmlElement)
  {
    return DMXW.TrackChangeType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>());
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType2? value)
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
  
  private static DMW.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MarkupType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>());
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType2? value)
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
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DXW.SdtBlock openXmlElement)
  {
    return DMXW.TrackChangeType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>());
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeStart(DXW.SdtBlock openXmlElement, DMW.TrackChangeType2? value)
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
  
  private static DMW.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DXW.SdtBlock openXmlElement)
  {
    return DMXW.MarkupType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>());
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeEnd(DXW.SdtBlock openXmlElement, DMW.MarkupType2? value)
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
  
  public static DMW.SdtBlock? CreateModelElement(DXW.SdtBlock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtBlock();
      value.SdtContentBlock = GetSdtContentBlock(openXmlElement);
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
  
  public static bool CompareModelElement(DXW.SdtBlock? openXmlElement, DMW.SdtBlock? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSdtContentBlock(openXmlElement, value.SdtContentBlock, diffs, objName))
        ok = false;
      if (!CmpSdtProperties(openXmlElement, value.SdtProperties, diffs, objName))
        ok = false;
      if (!CmpSdtEndCharProperties(openXmlElement, value.SdtEndCharProperties, diffs, objName))
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
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtBlock? value)
    where OpenXmlElementType: DXW.SdtBlock, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSdtContentBlock(openXmlElement, value?.SdtContentBlock);
      SetSdtProperties(openXmlElement, value?.SdtProperties);
      SetSdtEndCharProperties(openXmlElement, value?.SdtEndCharProperties);
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
      return openXmlElement;
    }
    return default;
  }
}
