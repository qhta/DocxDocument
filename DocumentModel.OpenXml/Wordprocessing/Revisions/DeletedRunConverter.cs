namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Deleted Run Content.
/// </summary>
public static class DeletedRunConverter
{
  private static DMW.SdtRun? GetSdtRun(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtRun>();
    if (element != null)
      return DMXW.SdtRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtRun(DXW.DeletedRun openXmlElement, DMW.SdtRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtRun>(), value, diffs, objName);
  }
  
  private static void SetSdtRun(DXW.DeletedRun openXmlElement, DMW.SdtRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtRunConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.ProofError? GetProofError(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ProofError>();
    if (element != null)
      return DMXW.ProofErrorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpProofError(DXW.DeletedRun openXmlElement, DMW.ProofError? value, DiffList? diffs, string? objName)
  {
    return DMXW.ProofErrorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ProofError>(), value, diffs, objName);
  }
  
  private static void SetProofError(DXW.DeletedRun openXmlElement, DMW.ProofError? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ProofError>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ProofErrorConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermStart? GetPermStart(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PermStart>();
    if (element != null)
      return DMXW.PermStartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPermStart(DXW.DeletedRun openXmlElement, DMW.PermStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermStartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PermStart>(), value, diffs, objName);
  }
  
  private static void SetPermStart(DXW.DeletedRun openXmlElement, DMW.PermStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermStartConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.PermEnd? GetPermEnd(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PermEnd>();
    if (element != null)
      return DMXW.PermEndConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPermEnd(DXW.DeletedRun openXmlElement, DMW.PermEnd? value, DiffList? diffs, string? objName)
  {
    return DMXW.PermEndConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PermEnd>(), value, diffs, objName);
  }
  
  private static void SetPermEnd(DXW.DeletedRun openXmlElement, DMW.PermEnd? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PermEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PermEndConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BookmarkStart? GetBookmarkStart(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BookmarkStart>();
    if (element != null)
      return DMXW.BookmarkStartConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBookmarkStart(DXW.DeletedRun openXmlElement, DMW.BookmarkStart? value, DiffList? diffs, string? objName)
  {
    return DMXW.BookmarkStartConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BookmarkStart>(), value, diffs, objName);
  }
  
  private static void SetBookmarkStart(DXW.DeletedRun openXmlElement, DMW.BookmarkStart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookmarkStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BookmarkStartConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BookmarkEnd? GetBookmarkEnd(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BookmarkEnd>();
    if (element != null)
      return DMXW.MarkupRangeElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBookmarkEnd(DXW.DeletedRun openXmlElement, DMW.MarkupRangeElement? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BookmarkEnd>(), value, diffs, objName);
  }
  
  private static void SetBookmarkEnd(DXW.DeletedRun openXmlElement, DMW.MarkupRangeElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BookmarkEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeElementConverter.CreateOpenXmlElement<DXW.BookmarkEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CommentRangeStart? GetCommentRangeStart(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CommentRangeStart>();
    if (element != null)
      return DMXW.MarkupRangeElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCommentRangeStart(DXW.DeletedRun openXmlElement, DMW.MarkupRangeElement? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCommentRangeStart(DXW.DeletedRun openXmlElement, DMW.MarkupRangeElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CommentRangeStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeElementConverter.CreateOpenXmlElement<DXW.CommentRangeStart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CommentRangeEnd? GetCommentRangeEnd(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CommentRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCommentRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupRangeElement? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CommentRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCommentRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupRangeElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CommentRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeElementConverter.CreateOpenXmlElement<DXW.CommentRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveFromRangeStart? GetMoveFromRangeStart(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRangeStart>();
    if (element != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRangeStart(DXW.DeletedRun openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRangeStart>(), value, diffs, objName);
  }
  
  private static void SetMoveFromRangeStart(DXW.DeletedRun openXmlElement, DMW.MoveBookmarkType? value)
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
  
  private static DMW.MoveFromRangeEnd? GetMoveFromRangeEnd(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupRangeElement? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetMoveFromRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupRangeElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeElementConverter.CreateOpenXmlElement<DXW.MoveFromRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveToRangeStart? GetMoveToRangeStart(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRangeStart>();
    if (element != null)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRangeStart(DXW.DeletedRun openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveBookmarkTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRangeStart>(), value, diffs, objName);
  }
  
  private static void SetMoveToRangeStart(DXW.DeletedRun openXmlElement, DMW.MoveBookmarkType? value)
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
  
  private static DMW.MoveToRangeEnd? GetMoveToRangeEnd(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRangeEnd>();
    if (element != null)
      return DMXW.MarkupRangeElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupRangeElement? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupRangeElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetMoveToRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupRangeElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToRangeEnd>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MarkupRangeElementConverter.CreateOpenXmlElement<DXW.MoveToRangeEnd>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.CustomXmlInsRangeStart? GetCustomXmlInsRangeStart(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlInsRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlInsRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.CustomXmlInsRangeEnd? GetCustomXmlInsRangeEnd(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlInsRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlInsRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlInsRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlInsRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.CustomXmlDelRangeStart? GetCustomXmlDelRangeStart(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlDelRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlDelRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.CustomXmlDelRangeEnd? GetCustomXmlDelRangeEnd(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlDelRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlDelRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlDelRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlDelRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.CustomXmlMoveFromRangeStart? GetCustomXmlMoveFromRangeStart(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveFromRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlMoveFromRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.CustomXmlMoveFromRangeEnd? GetCustomXmlMoveFromRangeEnd(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveFromRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveFromRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlMoveFromRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.CustomXmlMoveToRangeStart? GetCustomXmlMoveToRangeStart(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeStart>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveToRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlMoveToRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType? value)
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
  
  private static DMW.CustomXmlMoveToRangeEnd? GetCustomXmlMoveToRangeEnd(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>();
    if (element != null)
      return DMXW.MarkupTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlMoveToRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlMoveToRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlMoveToRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType? value)
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
  
  private static DMW.CustomXmlConflictInsertionRangeStart? GetCustomXmlConflictInsertionRangeStart(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlConflictInsertionRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType2? value)
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
  
  private static DMW.CustomXmlConflictInsertionRangeEnd? GetCustomXmlConflictInsertionRangeEnd(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>();
    if (element != null)
      return DMXW.MarkupType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictInsertionRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictInsertionRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlConflictInsertionRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType2? value)
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
  
  private static DMW.CustomXmlConflictDeletionRangeStart? GetCustomXmlConflictDeletionRangeStart(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>();
    if (element != null)
      return DMXW.TrackChangeType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeStart>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlConflictDeletionRangeStart(DXW.DeletedRun openXmlElement, DMW.TrackChangeType2? value)
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
  
  private static DMW.CustomXmlConflictDeletionRangeEnd? GetCustomXmlConflictDeletionRangeEnd(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>();
    if (element != null)
      return DMXW.MarkupType2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlConflictDeletionRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    return DMXW.MarkupType2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CustomXmlConflictDeletionRangeEnd>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlConflictDeletionRangeEnd(DXW.DeletedRun openXmlElement, DMW.MarkupType2? value)
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
  
  private static DMW.InsertedRun? GetInsertedRun(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.InsertedRun>();
    if (element != null)
      return DMXW.InsertedRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInsertedRun(DXW.DeletedRun openXmlElement, DMW.InsertedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.InsertedRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.InsertedRun>(), value, diffs, objName);
  }
  
  private static void SetInsertedRun(DXW.DeletedRun openXmlElement, DMW.InsertedRun? value)
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
  
  private static DMW.DeletedRun? GetChildDeletedRun(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DeletedRun>();
    if (element != null)
      return DMXW.DeletedRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildDeletedRun(DXW.DeletedRun openXmlElement, DMW.DeletedRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.DeletedRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedRun>(), value, diffs, objName);
  }
  
  private static void SetChildDeletedRun(DXW.DeletedRun openXmlElement, DMW.DeletedRun? value)
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
  
  private static DMW.MoveFromRun? GetMoveFromRun(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveFromRun>();
    if (element != null)
      return DMXW.MoveFromRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveFromRun(DXW.DeletedRun openXmlElement, DMW.MoveFromRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveFromRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveFromRun>(), value, diffs, objName);
  }
  
  private static void SetMoveFromRun(DXW.DeletedRun openXmlElement, DMW.MoveFromRun? value)
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
  
  private static DMW.MoveToRun? GetMoveToRun(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.MoveToRun>();
    if (element != null)
      return DMXW.MoveToRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveToRun(DXW.DeletedRun openXmlElement, DMW.MoveToRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.MoveToRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.MoveToRun>(), value, diffs, objName);
  }
  
  private static void SetMoveToRun(DXW.DeletedRun openXmlElement, DMW.MoveToRun? value)
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
  
  private static DMW.RunConflictInsertion? GetRunConflictInsertion(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.RunConflictInsertion>();
    if (element != null)
      return DMXW.RunConflictInsertionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunConflictInsertion(DXW.DeletedRun openXmlElement, DMW.RunConflictInsertion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictInsertionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RunConflictInsertion>(), value, diffs, objName);
  }
  
  private static void SetRunConflictInsertion(DXW.DeletedRun openXmlElement, DMW.RunConflictInsertion? value)
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
  
  private static DMW.RunConflictDeletion? GetRunConflictDeletion(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.RunConflictDeletion>();
    if (element != null)
      return DMXW.RunConflictDeletionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunConflictDeletion(DXW.DeletedRun openXmlElement, DMW.RunConflictDeletion? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunConflictDeletionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.RunConflictDeletion>(), value, diffs, objName);
  }
  
  private static void SetRunConflictDeletion(DXW.DeletedRun openXmlElement, DMW.RunConflictDeletion? value)
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
  
  private static DMM.Paragraph? GetParagraph(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Paragraph>();
    if (element != null)
      return DMXM.ParagraphConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraph(DXW.DeletedRun openXmlElement, DMM.Paragraph? value, DiffList? diffs, string? objName)
  {
    return DMXM.ParagraphConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Paragraph>(), value, diffs, objName);
  }
  
  private static void SetParagraph(DXW.DeletedRun openXmlElement, DMM.Paragraph? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Paragraph>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ParagraphConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.OfficeMath? GetOfficeMath(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.OfficeMath>();
    if (element != null)
      return DMXM.OfficeMathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeMath(DXW.DeletedRun openXmlElement, DMM.OfficeMath? value, DiffList? diffs, string? objName)
  {
    return DMXM.OfficeMathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.OfficeMath>(), value, diffs, objName);
  }
  
  private static void SetOfficeMath(DXW.DeletedRun openXmlElement, DMM.OfficeMath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.OfficeMath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.OfficeMathConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Accent? GetAccent(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Accent>();
    if (element != null)
      return DMXM.AccentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAccent(DXW.DeletedRun openXmlElement, DMM.Accent? value, DiffList? diffs, string? objName)
  {
    return DMXM.AccentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Accent>(), value, diffs, objName);
  }
  
  private static void SetAccent(DXW.DeletedRun openXmlElement, DMM.Accent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Accent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.AccentConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Bar? GetBar(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Bar>();
    if (element != null)
      return DMXM.BarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBar(DXW.DeletedRun openXmlElement, DMM.Bar? value, DiffList? diffs, string? objName)
  {
    return DMXM.BarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Bar>(), value, diffs, objName);
  }
  
  private static void SetBar(DXW.DeletedRun openXmlElement, DMM.Bar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Bar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.BarConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Box? GetBox(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Box>();
    if (element != null)
      return DMXM.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBox(DXW.DeletedRun openXmlElement, DMM.Box? value, DiffList? diffs, string? objName)
  {
    return DMXM.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Box>(), value, diffs, objName);
  }
  
  private static void SetBox(DXW.DeletedRun openXmlElement, DMM.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.BoxConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.BorderBox? GetBorderBox(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.BorderBox>();
    if (element != null)
      return DMXM.BorderBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBorderBox(DXW.DeletedRun openXmlElement, DMM.BorderBox? value, DiffList? diffs, string? objName)
  {
    return DMXM.BorderBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.BorderBox>(), value, diffs, objName);
  }
  
  private static void SetBorderBox(DXW.DeletedRun openXmlElement, DMM.BorderBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.BorderBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.BorderBoxConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Delimiter? GetDelimiter(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Delimiter>();
    if (element != null)
      return DMXM.DelimiterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDelimiter(DXW.DeletedRun openXmlElement, DMM.Delimiter? value, DiffList? diffs, string? objName)
  {
    return DMXM.DelimiterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Delimiter>(), value, diffs, objName);
  }
  
  private static void SetDelimiter(DXW.DeletedRun openXmlElement, DMM.Delimiter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Delimiter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.DelimiterConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.EquationArray? GetEquationArray(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.EquationArray>();
    if (element != null)
      return DMXM.EquationArrayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEquationArray(DXW.DeletedRun openXmlElement, DMM.EquationArray? value, DiffList? diffs, string? objName)
  {
    return DMXM.EquationArrayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.EquationArray>(), value, diffs, objName);
  }
  
  private static void SetEquationArray(DXW.DeletedRun openXmlElement, DMM.EquationArray? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.EquationArray>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.EquationArrayConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Fraction? GetFraction(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Fraction>();
    if (element != null)
      return DMXM.FractionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFraction(DXW.DeletedRun openXmlElement, DMM.Fraction? value, DiffList? diffs, string? objName)
  {
    return DMXM.FractionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Fraction>(), value, diffs, objName);
  }
  
  private static void SetFraction(DXW.DeletedRun openXmlElement, DMM.Fraction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Fraction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.FractionConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Function? GetMathFunction(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.MathFunction>();
    if (element != null)
      return DMXM.MathFunctionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMathFunction(DXW.DeletedRun openXmlElement, DMM.Function? value, DiffList? diffs, string? objName)
  {
    return DMXM.MathFunctionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.MathFunction>(), value, diffs, objName);
  }
  
  private static void SetMathFunction(DXW.DeletedRun openXmlElement, DMM.Function? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.MathFunction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.MathFunctionConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.GroupChar? GetGroupChar(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.GroupChar>();
    if (element != null)
      return DMXM.GroupCharConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupChar(DXW.DeletedRun openXmlElement, DMM.GroupChar? value, DiffList? diffs, string? objName)
  {
    return DMXM.GroupCharConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.GroupChar>(), value, diffs, objName);
  }
  
  private static void SetGroupChar(DXW.DeletedRun openXmlElement, DMM.GroupChar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.GroupChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.GroupCharConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.LimitLower? GetLimitLower(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.LimitLower>();
    if (element != null)
      return DMXM.LimitLowerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitLower(DXW.DeletedRun openXmlElement, DMM.LimitLower? value, DiffList? diffs, string? objName)
  {
    return DMXM.LimitLowerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.LimitLower>(), value, diffs, objName);
  }
  
  private static void SetLimitLower(DXW.DeletedRun openXmlElement, DMM.LimitLower? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.LimitLower>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.LimitLowerConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.LimitUpper? GetLimitUpper(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.LimitUpper>();
    if (element != null)
      return DMXM.LimitUpperConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitUpper(DXW.DeletedRun openXmlElement, DMM.LimitUpper? value, DiffList? diffs, string? objName)
  {
    return DMXM.LimitUpperConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.LimitUpper>(), value, diffs, objName);
  }
  
  private static void SetLimitUpper(DXW.DeletedRun openXmlElement, DMM.LimitUpper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.LimitUpper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.LimitUpperConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Matrix? GetMatrix(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Matrix>();
    if (element != null)
      return DMXM.MatrixConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMatrix(DXW.DeletedRun openXmlElement, DMM.Matrix? value, DiffList? diffs, string? objName)
  {
    return DMXM.MatrixConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Matrix>(), value, diffs, objName);
  }
  
  private static void SetMatrix(DXW.DeletedRun openXmlElement, DMM.Matrix? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Matrix>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.MatrixConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Nary? GetNary(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Nary>();
    if (element != null)
      return DMXM.NaryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNary(DXW.DeletedRun openXmlElement, DMM.Nary? value, DiffList? diffs, string? objName)
  {
    return DMXM.NaryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Nary>(), value, diffs, objName);
  }
  
  private static void SetNary(DXW.DeletedRun openXmlElement, DMM.Nary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Nary>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.NaryConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Phantom? GetPhantom(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Phantom>();
    if (element != null)
      return DMXM.PhantomConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPhantom(DXW.DeletedRun openXmlElement, DMM.Phantom? value, DiffList? diffs, string? objName)
  {
    return DMXM.PhantomConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Phantom>(), value, diffs, objName);
  }
  
  private static void SetPhantom(DXW.DeletedRun openXmlElement, DMM.Phantom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Phantom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.PhantomConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Radical? GetRadical(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Radical>();
    if (element != null)
      return DMXM.RadicalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadical(DXW.DeletedRun openXmlElement, DMM.Radical? value, DiffList? diffs, string? objName)
  {
    return DMXM.RadicalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Radical>(), value, diffs, objName);
  }
  
  private static void SetRadical(DXW.DeletedRun openXmlElement, DMM.Radical? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Radical>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.RadicalConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.PreSubSuper? GetPreSubSuper(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.PreSubSuper>();
    if (element != null)
      return DMXM.PreSubSuperConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreSubSuper(DXW.DeletedRun openXmlElement, DMM.PreSubSuper? value, DiffList? diffs, string? objName)
  {
    return DMXM.PreSubSuperConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.PreSubSuper>(), value, diffs, objName);
  }
  
  private static void SetPreSubSuper(DXW.DeletedRun openXmlElement, DMM.PreSubSuper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.PreSubSuper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.PreSubSuperConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Subscript? GetSubscript(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Subscript>();
    if (element != null)
      return DMXM.SubscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubscript(DXW.DeletedRun openXmlElement, DMM.Subscript? value, DiffList? diffs, string? objName)
  {
    return DMXM.SubscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Subscript>(), value, diffs, objName);
  }
  
  private static void SetSubscript(DXW.DeletedRun openXmlElement, DMM.Subscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Subscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.SubscriptConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.SubSuperscript? GetSubSuperscript(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SubSuperscript>();
    if (element != null)
      return DMXM.SubSuperscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubSuperscript(DXW.DeletedRun openXmlElement, DMM.SubSuperscript? value, DiffList? diffs, string? objName)
  {
    return DMXM.SubSuperscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SubSuperscript>(), value, diffs, objName);
  }
  
  private static void SetSubSuperscript(DXW.DeletedRun openXmlElement, DMM.SubSuperscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.SubSuperscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.SubSuperscriptConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Superscript? GetSuperscript(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Superscript>();
    if (element != null)
      return DMXM.SuperscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperscript(DXW.DeletedRun openXmlElement, DMM.Superscript? value, DiffList? diffs, string? objName)
  {
    return DMXM.SuperscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Superscript>(), value, diffs, objName);
  }
  
  private static void SetSuperscript(DXW.DeletedRun openXmlElement, DMM.Superscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Superscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.SuperscriptConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMM.Run? GetRun(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Run>();
    if (element != null)
      return DMXM.RunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRun(DXW.DeletedRun openXmlElement, DMM.Run? value, DiffList? diffs, string? objName)
  {
    return DMXM.RunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Run>(), value, diffs, objName);
  }
  
  private static void SetRun(DXW.DeletedRun openXmlElement, DMM.Run? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Run>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.RunConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BidirectionalOverride? GetBidirectionalOverride(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BidirectionalOverride>();
    if (element != null)
      return DMXW.BidirectionalOverrideConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBidirectionalOverride(DXW.DeletedRun openXmlElement, DMW.BidirectionalOverride? value, DiffList? diffs, string? objName)
  {
    return DMXW.BidirectionalOverrideConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BidirectionalOverride>(), value, diffs, objName);
  }
  
  private static void SetBidirectionalOverride(DXW.DeletedRun openXmlElement, DMW.BidirectionalOverride? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BidirectionalOverride>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BidirectionalOverrideConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BidirectionalEmbedding? GetBidirectionalEmbedding(DXW.DeletedRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BidirectionalEmbedding>();
    if (element != null)
      return DMXW.BidirectionalEmbeddingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBidirectionalEmbedding(DXW.DeletedRun openXmlElement, DMW.BidirectionalEmbedding? value, DiffList? diffs, string? objName)
  {
    return DMXW.BidirectionalEmbeddingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BidirectionalEmbedding>(), value, diffs, objName);
  }
  
  private static void SetBidirectionalEmbedding(DXW.DeletedRun openXmlElement, DMW.BidirectionalEmbedding? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BidirectionalEmbedding>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BidirectionalEmbeddingConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.DeletedRun? CreateModelElement(DXW.DeletedRun? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DeletedRun();
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
  
  public static bool CompareModelElement(DXW.DeletedRun? openXmlElement, DMW.DeletedRun? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
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
      if (!CmpChildDeletedRun(openXmlElement, value.ChildDeletedRun, diffs, objName))
        ok = false;
      if (!CmpMoveFromRun(openXmlElement, value.MoveFromRun, diffs, objName))
        ok = false;
      if (!CmpMoveToRun(openXmlElement, value.MoveToRun, diffs, objName))
        ok = false;
      if (!CmpRunConflictInsertion(openXmlElement, value.RunConflictInsertion, diffs, objName))
        ok = false;
      if (!CmpRunConflictDeletion(openXmlElement, value.RunConflictDeletion, diffs, objName))
        ok = false;
      if (!CmpParagraph(openXmlElement, value.Paragraph, diffs, objName))
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
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DeletedRun value)
    where OpenXmlElementType: DXW.DeletedRun, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.DeletedRun openXmlElement, DMW.DeletedRun value)
  {
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
    SetChildDeletedRun(openXmlElement, value?.ChildDeletedRun);
    SetMoveFromRun(openXmlElement, value?.MoveFromRun);
    SetMoveToRun(openXmlElement, value?.MoveToRun);
    SetRunConflictInsertion(openXmlElement, value?.RunConflictInsertion);
    SetRunConflictDeletion(openXmlElement, value?.RunConflictDeletion);
    SetParagraph(openXmlElement, value?.Paragraph);
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
    return true;
  }
}
