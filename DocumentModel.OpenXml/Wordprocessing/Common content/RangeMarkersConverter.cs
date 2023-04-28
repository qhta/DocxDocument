namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines conversion methods for range markers: 
/// BookmarkStart/BookmarkEnd, CommentRangeStart/CommentRangeEnd,
/// MoveFromStart/MoveFromEnd, MoveToStart/MoveToEnd, 
/// CustomXmlInsRangeStart/CustomXmlInsRangeEnd, CustomXmlDelRangeStart/CustomXmlDelRangeEnd,
/// CustomXmMoveFromStart/CustomXmMoveFromEnd, CustomXmMoveToStart/CustomXmMoveToEnd, 
/// CustomXmConflictInsertionStart/CustomXmConflictInsertionEnd, CustomXmConflictDeletionStart/CustomXmConflictDeletionEnd. 
/// </summary>
public static class RangeMarkersConverter
{
  public static DMW.ICommonContent? CreateModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.BookmarkStart bookmarkStart)
      return DMXW.BookmarkStartConverter.CreateModelElement(bookmarkStart);
    if (openXmlElement is DXW.BookmarkEnd bookmarkEnd)
      return DMXW.BookmarkEndConverter.CreateModelElement(bookmarkEnd);
    if (openXmlElement is DXW.CommentRangeStart commentRangeStart)
      return DMXW.MarkupRangeElementConverter.CreateModelElement(commentRangeStart);
    if (openXmlElement is DXW.CommentRangeEnd commentRangeEnd)
      return DMXW.MarkupRangeElementConverter.CreateModelElement(commentRangeEnd);
    if (openXmlElement is DXW.MoveFromRangeStart moveFromRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(moveFromRangeStart);
    if (openXmlElement is DXW.MoveFromRangeEnd moveFromRangeEnd)
      return DMXW.MarkupRangeElementConverter.CreateModelElement(moveFromRangeEnd);
    if (openXmlElement is DXW.MoveToRangeStart moveToRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(moveToRangeStart);
    if (openXmlElement is DXW.MoveToRangeEnd moveToRangeEnd)
      return DMXW.MarkupRangeElementConverter.CreateModelElement(moveToRangeEnd);
    if (openXmlElement is DXW.CustomXmlInsRangeStart customXmlInsRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(customXmlInsRangeStart);
    if (openXmlElement is DXW.CustomXmlInsRangeEnd customXmlInsRangeEnd)
      return DMXW.MarkupTypeConverter.CreateModelElement(customXmlInsRangeEnd);
    if (openXmlElement is DXW.CustomXmlDelRangeStart customXmlDelRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(customXmlDelRangeStart);
    if (openXmlElement is DXW.CustomXmlDelRangeEnd customXmlDelRangeEnd)
      return DMXW.MarkupTypeConverter.CreateModelElement(customXmlDelRangeEnd);
    if (openXmlElement is DXW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(customXmlMoveFromRangeStart);
    if (openXmlElement is DXW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEnd)
      return DMXW.MarkupTypeConverter.CreateModelElement(customXmlMoveFromRangeEnd);
    if (openXmlElement is DXW.CustomXmlMoveToRangeStart customXmlMoveToRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(customXmlMoveToRangeStart);
    if (openXmlElement is DXW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEnd)
      return DMXW.MarkupTypeConverter.CreateModelElement(customXmlMoveToRangeEnd);
    if (openXmlElement is DXO10W.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateModelElement(customXmlConflictInsertionRangeStart);
    if (openXmlElement is DXO10W.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEnd)
      return DMXW.MarkupType2Converter.CreateModelElement(customXmlConflictInsertionRangeEnd);
    if (openXmlElement is DXO10W.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateModelElement(customXmlConflictDeletionRangeStart);
    if (openXmlElement is DXO10W.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEnd)
      return DMXW.MarkupType2Converter.CreateModelElement(customXmlConflictDeletionRangeEnd);
    return null;
  }

  public static bool? CompareModelElement(DX.OpenXmlElement? openXmlElement, DMW.ICommonContent? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.BookmarkStart bookmarkStart && model is DMW.BookmarkStart bookmarkStartModel)
        return DMXW.BookmarkStartConverter.CompareModelElement(bookmarkStart, bookmarkStartModel, diffs, objName);
      if (openXmlElement is DXW.BookmarkEnd bookmarkEnd && model is DMW.BookmarkEnd bookmarkEndModel)
        return DMXW.BookmarkEndConverter.CompareModelElement(bookmarkEnd, bookmarkEndModel, diffs, objName);
      if (openXmlElement is DXW.CommentRangeStart commentRangeStart && model is DMW.CommentRangeStart commentRangeStartModel)
        return DMXW.MarkupRangeElementConverter.CompareModelElement(commentRangeStart, commentRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.CommentRangeEnd commentRangeEnd && model is DMW.CommentRangeEnd commentRangeEndModel)
        return DMXW.MarkupRangeElementConverter.CompareModelElement(commentRangeEnd, commentRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.MoveFromRangeStart moveFromRangeStart && model is DMW.MoveFromRangeStart moveFromRangeStartModel)
        return DMXW.MoveBookmarkTypeConverter.CompareModelElement(moveFromRangeStart, moveFromRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.MoveFromRangeEnd moveFromRangeEnd && model is DMW.MoveFromRangeEnd moveFromRangeEndModel)
        return DMXW.MarkupRangeElementConverter.CompareModelElement(moveFromRangeEnd, moveFromRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.MoveToRangeStart moveToRangeStart && model is DMW.MoveToRangeStart moveToRangeStartModel)
        return DMXW.MoveBookmarkTypeConverter.CompareModelElement(moveToRangeStart, moveToRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.MoveToRangeEnd moveToRangeEnd && model is DMW.MoveToRangeEnd moveToRangeEndModel)
        return DMXW.MarkupRangeElementConverter.CompareModelElement(moveToRangeEnd, moveToRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlInsRangeStart customXmlInsRangeStart && model is DMW.CustomXmlInsRangeStart customXmlInsRangeStartModel)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlInsRangeStart, customXmlInsRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlInsRangeEnd customXmlInsRangeEnd && model is DMW.CustomXmlInsRangeEnd customXmlInsRangeEndModel)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlInsRangeEnd, customXmlInsRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlDelRangeStart customXmlDelRangeStart && model is DMW.CustomXmlDelRangeStart customXmlDelRangeStartModel)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlDelRangeStart, customXmlDelRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlDelRangeEnd customXmlDelRangeEnd && model is DMW.CustomXmlDelRangeEnd customXmlDelRangeEndModel)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlDelRangeEnd, customXmlDelRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStart && model is DMW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStartModel)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlMoveFromRangeStart, customXmlMoveFromRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEnd && model is DMW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEndModel)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlMoveFromRangeEnd, customXmlMoveFromRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveToRangeStart customXmlMoveToRangeStart && model is DMW.CustomXmlMoveToRangeStart customXmlMoveToRangeStartModel)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlMoveToRangeStart, customXmlMoveToRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEnd && model is DMW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEndModel)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlMoveToRangeEnd, customXmlMoveToRangeEndModel, diffs, objName);
      if (openXmlElement is DXO10W.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStart && model is DMW.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStartModel)
        return DMXW.TrackChangeType2Converter.CompareModelElement(customXmlConflictInsertionRangeStart, customXmlConflictInsertionRangeStartModel, diffs, objName);
      if (openXmlElement is DXO10W.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEnd && model is DMW.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEndModel)
        return DMXW.MarkupType2Converter.CompareModelElement(customXmlConflictInsertionRangeEnd, customXmlConflictInsertionRangeEndModel, diffs, objName);
      if (openXmlElement is DXO10W.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStart && model is DMW.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStartModel)
        return DMXW.TrackChangeType2Converter.CompareModelElement(customXmlConflictDeletionRangeStart, customXmlConflictDeletionRangeStartModel, diffs, objName);
      if (openXmlElement is DXO10W.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEnd && model is DMW.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEndModel)
        return DMXW.MarkupType2Converter.CompareModelElement(customXmlConflictDeletionRangeEnd, customXmlConflictDeletionRangeEndModel, diffs, objName);
      return null;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElement? CreateOpenXmlElement(DMW.ICommonContent? model)
  {
    if (model is DMW.BookmarkStart bookmarkStart)
      return DMXW.BookmarkStartConverter.CreateOpenXmlElement(bookmarkStart);
    if (model is DMW.BookmarkEnd bookmarkEnd)
      return DMXW.BookmarkEndConverter.CreateOpenXmlElement(bookmarkEnd);
    if (model is DMW.CommentRangeStart commentRangeStart)
      return DMXW.MarkupRangeElementConverter.CreateOpenXmlElement(commentRangeStart);
    if (model is DMW.CommentRangeEnd commentRangeEnd)
      return DMXW.MarkupRangeElementConverter.CreateOpenXmlElement(commentRangeEnd);
    if (model is DMW.MoveFromRangeStart moveFromRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement(moveFromRangeStart);
    if (model is DMW.MoveFromRangeEnd moveFromRangeEnd)
      return DMXW.MarkupRangeElementConverter.CreateOpenXmlElement(moveFromRangeEnd);
    if (model is DMW.MoveToRangeStart moveToRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement(moveToRangeStart);
    if (model is DMW.MoveToRangeEnd moveToRangeEnd)
      return DMXW.MarkupRangeElementConverter.CreateOpenXmlElement<DXW.MoveFromRangeEnd>(moveToRangeEnd);
    if (model is DMW.CustomXmlInsRangeStart customXmlInsRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeStart>(customXmlInsRangeStart);
    if (model is DMW.CustomXmlInsRangeEnd customXmlInsRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeEnd>(customXmlInsRangeEnd);
    if (model is DMW.CustomXmlDelRangeStart customXmlDelRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeStart>(customXmlDelRangeStart);
    if (model is DMW.CustomXmlDelRangeEnd customXmlDelRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeEnd>(customXmlDelRangeEnd);
    if (model is DMW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeStart>(customXmlMoveFromRangeStart);
    if (model is DMW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeEnd>(customXmlMoveFromRangeEnd);
    if (model is DMW.CustomXmlMoveToRangeStart customXmlMoveToRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeStart>(customXmlMoveToRangeStart);
    if (model is DMW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeEnd>(customXmlMoveToRangeEnd);
    if (model is DMW.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO10W.CustomXmlConflictInsertionRangeStart>(customXmlConflictInsertionRangeStart);
    if (model is DMW.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEnd)
      return DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO10W.CustomXmlConflictInsertionRangeEnd>(customXmlConflictInsertionRangeEnd);
    if (model is DMW.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO10W.CustomXmlConflictDeletionRangeStart>(customXmlConflictDeletionRangeStart);
    if (model is DMW.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEnd)
      return DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO10W.CustomXmlConflictDeletionRangeEnd>(customXmlConflictDeletionRangeEnd);
    return null;
  }

    public static bool? UpdateOpenXmlElement(DX.OpenXmlElement? openXmlElement, DMW.ICommonContent? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.BookmarkStart bookmarkStart && model is DMW.BookmarkStart bookmarkStartModel)
        return DMXW.BookmarkStartConverter.UpdateOpenXmlElement(bookmarkStart, bookmarkStartModel);
      if (openXmlElement is DXW.BookmarkEnd bookmarkEnd && model is DMW.BookmarkEnd bookmarkEndModel)
        return DMXW.BookmarkEndConverter.UpdateOpenXmlElement(bookmarkEnd, bookmarkEndModel);
      if (openXmlElement is DXW.CommentRangeStart commentRangeStart && model is DMW.CommentRangeStart commentRangeStartModel)
        return DMXW.MarkupRangeElementConverter.UpdateOpenXmlElement(commentRangeStart, commentRangeStartModel);
      if (openXmlElement is DXW.CommentRangeEnd commentRangeEnd && model is DMW.CommentRangeEnd commentRangeEndModel)
        return DMXW.MarkupRangeElementConverter.UpdateOpenXmlElement(commentRangeEnd, commentRangeEndModel);
      if (openXmlElement is DXW.MoveFromRangeStart moveFromRangeStart && model is DMW.MoveFromRangeStart moveFromRangeStartModel)
        return DMXW.MoveBookmarkTypeConverter.UpdateOpenXmlElement(moveFromRangeStart, moveFromRangeStartModel);
      if (openXmlElement is DXW.MoveFromRangeEnd moveFromRangeEnd && model is DMW.MoveFromRangeEnd moveFromRangeEndModel)
        return DMXW.MarkupRangeElementConverter.UpdateOpenXmlElement(moveFromRangeEnd, moveFromRangeEndModel);
      if (openXmlElement is DXW.MoveToRangeStart moveToRangeStart && model is DMW.MoveToRangeStart moveToRangeStartModel)
        return DMXW.MoveBookmarkTypeConverter.UpdateOpenXmlElement(moveToRangeStart, moveToRangeStartModel);
      if (openXmlElement is DXW.MoveToRangeEnd moveToRangeEnd && model is DMW.MoveToRangeEnd moveToRangeEndModel)
        return DMXW.MarkupRangeElementConverter.UpdateOpenXmlElement(moveToRangeEnd, moveToRangeEndModel);
      if (openXmlElement is DXW.CustomXmlInsRangeStart customXmlInsRangeStart && model is DMW.CustomXmlInsRangeStart customXmlInsRangeStartModel)
        return DMXW.TrackChangeTypeConverter.UpdateOpenXmlElement(customXmlInsRangeStart, customXmlInsRangeStartModel);
      if (openXmlElement is DXW.CustomXmlInsRangeEnd customXmlInsRangeEnd && model is DMW.CustomXmlInsRangeEnd customXmlInsRangeEndModel)
        return DMXW.MarkupTypeConverter.UpdateOpenXmlElement(customXmlInsRangeEnd, customXmlInsRangeEndModel);
      if (openXmlElement is DXW.CustomXmlDelRangeStart customXmlDelRangeStart && model is DMW.CustomXmlDelRangeStart customXmlDelRangeStartModel)
        return DMXW.TrackChangeTypeConverter.UpdateOpenXmlElement(customXmlDelRangeStart, customXmlDelRangeStartModel);
      if (openXmlElement is DXW.CustomXmlDelRangeEnd customXmlDelRangeEnd && model is DMW.CustomXmlDelRangeEnd customXmlDelRangeEndModel)
        return DMXW.MarkupTypeConverter.UpdateOpenXmlElement(customXmlDelRangeEnd, customXmlDelRangeEndModel);
      if (openXmlElement is DXW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStart && model is DMW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStartModel)
        return DMXW.TrackChangeTypeConverter.UpdateOpenXmlElement(customXmlMoveFromRangeStart, customXmlMoveFromRangeStartModel);
      if (openXmlElement is DXW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEnd && model is DMW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEndModel)
        return DMXW.MarkupTypeConverter.UpdateOpenXmlElement(customXmlMoveFromRangeEnd, customXmlMoveFromRangeEndModel);
      if (openXmlElement is DXW.CustomXmlMoveToRangeStart customXmlMoveToRangeStart && model is DMW.CustomXmlMoveToRangeStart customXmlMoveToRangeStartModel)
        return DMXW.TrackChangeTypeConverter.UpdateOpenXmlElement(customXmlMoveToRangeStart, customXmlMoveToRangeStartModel);
      if (openXmlElement is DXW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEnd && model is DMW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEndModel)
        return DMXW.MarkupTypeConverter.UpdateOpenXmlElement(customXmlMoveToRangeEnd, customXmlMoveToRangeEndModel);
      if (openXmlElement is DXO10W.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStart && model is DMW.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStartModel)
        return DMXW.TrackChangeType2Converter.UpdateOpenXmlElement(customXmlConflictInsertionRangeStart, customXmlConflictInsertionRangeStartModel);
      if (openXmlElement is DXO10W.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEnd && model is DMW.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEndModel)
        return DMXW.MarkupType2Converter.UpdateOpenXmlElement(customXmlConflictInsertionRangeEnd, customXmlConflictInsertionRangeEndModel);
      if (openXmlElement is DXO10W.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStart && model is DMW.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStartModel)
        return DMXW.TrackChangeType2Converter.UpdateOpenXmlElement(customXmlConflictDeletionRangeStart, customXmlConflictDeletionRangeStartModel);
      if (openXmlElement is DXO10W.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEnd && model is DMW.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEndModel)
        return DMXW.MarkupType2Converter.UpdateOpenXmlElement(customXmlConflictDeletionRangeEnd, customXmlConflictDeletionRangeEndModel);
    }
    return false;
  }

}
