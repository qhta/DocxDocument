namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Table Class.
/// </summary>
public static class TableConverter
{
  private static DMW.BookmarkStart? GetBookmarkStart(DXW.Table openXmlElement)
  {
    return DMXW.BookmarkStartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkStart>());
  }
  
  private static bool CmpBookmarkStart(DXW.Table openXmlElement, DMW.BookmarkStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.BookmarkStartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BookmarkStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkStart(DXW.Table openXmlElement, DMW.BookmarkStart? value)
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
  
  private static DMW.MarkupRangeType? GetBookmarkEnd(DXW.Table openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.BookmarkEnd>());
  }
  
  private static bool CmpBookmarkEnd(DXW.Table openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BookmarkEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBookmarkEnd(DXW.Table openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MarkupRangeType? GetCommentRangeStart(DXW.Table openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeStart>());
  }
  
  private static bool CmpCommentRangeStart(DXW.Table openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeStart(DXW.Table openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MarkupRangeType? GetCommentRangeEnd(DXW.Table openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>());
  }
  
  private static bool CmpCommentRangeEnd(DXW.Table openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentRangeEnd(DXW.Table openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MoveBookmarkType? GetMoveFromRangeStart(DXW.Table openXmlElement)
  {
    return DMXW.MoveBookmarkTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>());
  }
  
  private static bool CmpMoveFromRangeStart(DXW.Table openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeStart(DXW.Table openXmlElement, DMW.MoveBookmarkType? value)
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
  
  private static DMW.MarkupRangeType? GetMoveFromRangeEnd(DXW.Table openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>());
  }
  
  private static bool CmpMoveFromRangeEnd(DXW.Table openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRangeEnd(DXW.Table openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.MoveBookmarkType? GetMoveToRangeStart(DXW.Table openXmlElement)
  {
    return DMXW.MoveBookmarkTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>());
  }
  
  private static bool CmpMoveToRangeStart(DXW.Table openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeStart(DXW.Table openXmlElement, DMW.MoveBookmarkType? value)
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
  
  private static DMW.MarkupRangeType? GetMoveToRangeEnd(DXW.Table openXmlElement)
  {
    return DMXW.MarkupRangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>());
  }
  
  private static bool CmpMoveToRangeEnd(DXW.Table openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRangeEnd(DXW.Table openXmlElement, DMW.MarkupRangeType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlInsRangeStart(DXW.Table openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>());
  }
  
  private static bool CmpCustomXmlInsRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlInsRangeEnd(DXW.Table openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>());
  }
  
  private static bool CmpCustomXmlInsRangeEnd(DXW.Table openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlInsRangeEnd(DXW.Table openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlDelRangeStart(DXW.Table openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>());
  }
  
  private static bool CmpCustomXmlDelRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlDelRangeEnd(DXW.Table openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>());
  }
  
  private static bool CmpCustomXmlDelRangeEnd(DXW.Table openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlDelRangeEnd(DXW.Table openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlMoveFromRangeStart(DXW.Table openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>());
  }
  
  private static bool CmpCustomXmlMoveFromRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlMoveFromRangeEnd(DXW.Table openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>());
  }
  
  private static bool CmpCustomXmlMoveFromRangeEnd(DXW.Table openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveFromRangeEnd(DXW.Table openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType? GetCustomXmlMoveToRangeStart(DXW.Table openXmlElement)
  {
    return DMXW.TrackChangeTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>());
  }
  
  private static bool CmpCustomXmlMoveToRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.MarkupType? GetCustomXmlMoveToRangeEnd(DXW.Table openXmlElement)
  {
    return DMXW.MarkupTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>());
  }
  
  private static bool CmpCustomXmlMoveToRangeEnd(DXW.Table openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlMoveToRangeEnd(DXW.Table openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictInsertionRangeStart(DXW.Table openXmlElement)
  {
    return DMXW.TrackChangeType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>());
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType2? value)
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
  
  private static DMW.MarkupType2? GetCustomXmlConflictInsertionRangeEnd(DXW.Table openXmlElement)
  {
    return DMXW.MarkupType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>());
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeEnd(DXW.Table openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictInsertionRangeEnd(DXW.Table openXmlElement, DMW.MarkupType2? value)
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
  
  private static DMW.TrackChangeType2? GetCustomXmlConflictDeletionRangeStart(DXW.Table openXmlElement)
  {
    return DMXW.TrackChangeType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>());
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeStart(DXW.Table openXmlElement, DMW.TrackChangeType2? value)
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
  
  private static DMW.MarkupType2? GetCustomXmlConflictDeletionRangeEnd(DXW.Table openXmlElement)
  {
    return DMXW.MarkupType2Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>());
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeEnd(DXW.Table openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlConflictDeletionRangeEnd(DXW.Table openXmlElement, DMW.MarkupType2? value)
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
  
  private static DMW.TableProperties? GetTableProperties(DXW.Table openXmlElement)
  {
    return DMXW.TablePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableProperties>());
  }
  
  private static bool CmpTableProperties(DXW.Table openXmlElement, DMW.TableProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TablePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableProperties(DXW.Table openXmlElement, DMW.TableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TablePropertiesConverter.CreateOpenXmlElement<DXW.TableProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TableGrid? GetTableGrid(DXW.Table openXmlElement)
  {
    return DMXW.TableGridConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.TableGrid>());
  }
  
  private static bool CmpTableGrid(DXW.Table openXmlElement, DMW.TableGrid? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableGridConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableGrid>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTableGrid(DXW.Table openXmlElement, DMW.TableGrid? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableGrid>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableGridConverter.CreateOpenXmlElement<DXW.TableGrid>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.TableRow> GetTableRows(DXW.Table openXmlElement)
  {
    var collection = new Collection<DMW.TableRow>();
    foreach (var item in openXmlElement.Elements<DXW.TableRow>())
    {
      var newItem = DMXW.TableRowConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpTableRows(DXW.Table openXmlElement, Collection<DMW.TableRow>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXW.TableRow>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.TableRowConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTableRows(DXW.Table openXmlElement, Collection<DMW.TableRow>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.TableRow>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.TableRowConverter.CreateOpenXmlElement<DXW.TableRow>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMW.CustomXmlRow? GetCustomXmlRow(DXW.Table openXmlElement)
  {
    return DMXW.CustomXmlRowConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.CustomXmlRow>());
  }
  
  private static bool CmpCustomXmlRow(DXW.Table openXmlElement, DMW.CustomXmlRow? value, DiffList? diffs, string? objName)
  {
    return DMXW.CustomXmlRowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlRow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomXmlRow(DXW.Table openXmlElement, DMW.CustomXmlRow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CustomXmlRowConverter.CreateOpenXmlElement<DXW.CustomXmlRow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtRow? GetSdtRow(DXW.Table openXmlElement)
  {
    return DMXW.SdtRowConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtRow>());
  }
  
  private static bool CmpSdtRow(DXW.Table openXmlElement, DMW.SdtRow? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtRowConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtRow>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSdtRow(DXW.Table openXmlElement, DMW.SdtRow? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtRowConverter.CreateOpenXmlElement<DXW.SdtRow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ProofError? GetProofError(DXW.Table openXmlElement)
  {
    return DMXW.ProofErrorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ProofError>());
  }
  
  private static bool CmpProofError(DXW.Table openXmlElement, DMW.ProofError? value, DiffList? diffs, string? objName)
  {
    return DMXW.ProofErrorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ProofError>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetProofError(DXW.Table openXmlElement, DMW.ProofError? value)
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
  
  private static DMW.PermStart? GetPermStart(DXW.Table openXmlElement)
  {
    return DMXW.PermStartConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PermStart>());
  }
  
  private static bool CmpPermStart(DXW.Table openXmlElement, DMW.PermStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermStartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PermStart>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPermStart(DXW.Table openXmlElement, DMW.PermStart? value)
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
  
  private static DMW.PermEnd? GetPermEnd(DXW.Table openXmlElement)
  {
    return DMXW.PermEndConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PermEnd>());
  }
  
  private static bool CmpPermEnd(DXW.Table openXmlElement, DMW.PermEnd? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermEndConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PermEnd>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPermEnd(DXW.Table openXmlElement, DMW.PermEnd? value)
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
  
  private static DMW.InsertedRun? GetInsertedRun(DXW.Table openXmlElement)
  {
    return DMXW.InsertedRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.InsertedRun>());
  }
  
  private static bool CmpInsertedRun(DXW.Table openXmlElement, DMW.InsertedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.InsertedRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsertedRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInsertedRun(DXW.Table openXmlElement, DMW.InsertedRun? value)
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
  
  private static DMW.DeletedRun? GetDeletedRun(DXW.Table openXmlElement)
  {
    return DMXW.DeletedRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DeletedRun>());
  }
  
  private static bool CmpDeletedRun(DXW.Table openXmlElement, DMW.DeletedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.DeletedRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDeletedRun(DXW.Table openXmlElement, DMW.DeletedRun? value)
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
  
  private static DMW.MoveFromRun? GetMoveFromRun(DXW.Table openXmlElement)
  {
    return DMXW.MoveFromRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveFromRun>());
  }
  
  private static bool CmpMoveFromRun(DXW.Table openXmlElement, DMW.MoveFromRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveFromRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveFromRun(DXW.Table openXmlElement, DMW.MoveFromRun? value)
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
  
  private static DMW.MoveToRun? GetMoveToRun(DXW.Table openXmlElement)
  {
    return DMXW.MoveToRunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.MoveToRun>());
  }
  
  private static bool CmpMoveToRun(DXW.Table openXmlElement, DMW.MoveToRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveToRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRun>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveToRun(DXW.Table openXmlElement, DMW.MoveToRun? value)
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
  
  private static DMW.RunConflictInsertion? GetRunConflictInsertion(DXW.Table openXmlElement)
  {
    return DMXW.RunConflictInsertionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>());
  }
  
  private static bool CmpRunConflictInsertion(DXW.Table openXmlElement, DMW.RunConflictInsertion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictInsertionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RunConflictInsertion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunConflictInsertion(DXW.Table openXmlElement, DMW.RunConflictInsertion? value)
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
  
  private static DMW.RunConflictDeletion? GetRunConflictDeletion(DXW.Table openXmlElement)
  {
    return DMXW.RunConflictDeletionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>());
  }
  
  private static bool CmpRunConflictDeletion(DXW.Table openXmlElement, DMW.RunConflictDeletion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictDeletionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RunConflictDeletion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunConflictDeletion(DXW.Table openXmlElement, DMW.RunConflictDeletion? value)
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
  
  public static DMW.Table? CreateModelElement(DXW.Table? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Table();
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
  
  public static bool CompareModelElement(DXW.Table? openXmlElement, DMW.Table? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
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
      if (!CmpTableProperties(openXmlElement, value.TableProperties, diffs, objName))
        ok = false;
      if (!CmpTableGrid(openXmlElement, value.TableGrid, diffs, objName))
        ok = false;
      if (!CmpTableRows(openXmlElement, value.TableRows, diffs, objName))
        ok = false;
      if (!CmpCustomXmlRow(openXmlElement, value.CustomXmlRow, diffs, objName))
        ok = false;
      if (!CmpSdtRow(openXmlElement, value.SdtRow, diffs, objName))
        ok = false;
      if (!CmpProofError(openXmlElement, value.ProofError, diffs, objName))
        ok = false;
      if (!CmpPermStart(openXmlElement, value.PermStart, diffs, objName))
        ok = false;
      if (!CmpPermEnd(openXmlElement, value.PermEnd, diffs, objName))
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
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Table? value)
    where OpenXmlElementType: DXW.Table, new()
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
