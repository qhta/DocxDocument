using System.Xml.Linq;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines conversion method for common markers: 
/// ProofError, PermStart/PermEnd, BookmarkStart/BookmarkEnd, CommentRangeStart/CommentRangeEnd,
/// MoveFromStart/MoveFromEnd, MoveToStart/MoveToEnd, 
/// CustomXmlInsRangeStart/CustomXmlInsRangeEnd, CustomXmlDelRangeStart/CustomXmlDelRangeEnd,
/// CustomXmMoveFromStart/CustomXmMoveFromEnd, CustomXmMoveToStart/CustomXmMoveToEnd, 
/// CustomXmConflictInsertionStart/CustomXmConflictInsertionEnd, CustomXmConflictDeletionStart/CustomXmConflictDeletionEnd, 
/// InsertedRun, DeletedRun, MoveFromRun, MoveToRun, RunConflictInsertion, RunConflictDeletion.
/// </summary>
public static class CommonMarkersConverter
{
  public static DMW.ICommonElement? CreateModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.ProofError proofError)
      return DMXW.ProofErrorConverter.CreateModelElement(proofError);
    if (openXmlElement is DXW.PermStart permStart)
      return DMXW.PermStartConverter.CreateModelElement(permStart);
    if (openXmlElement is DXW.PermEnd permEnd)
      return DMXW.PermEndConverter.CreateModelElement(permEnd);
    if (openXmlElement is DXW.BookmarkStart bookmarkStart)
      return DMXW.BookmarkStartConverter.CreateModelElement(bookmarkStart);
    if (openXmlElement is DXW.BookmarkEnd bookmarkEnd)
      return DMXW.BookmarkEndConverter.CreateModelElement(bookmarkEnd);
    if (openXmlElement is DXW.CommentRangeStart commentRangeStart)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(commentRangeStart);
    if (openXmlElement is DXW.CommentRangeEnd commentRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(commentRangeEnd);
    if (openXmlElement is DXW.MoveFromRangeStart moveFromRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(moveFromRangeStart);
    if (openXmlElement is DXW.MoveFromRangeEnd moveFromRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(moveFromRangeEnd);
    if (openXmlElement is DXW.MoveToRangeStart moveToRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(moveToRangeStart);
    if (openXmlElement is DXW.MoveToRangeEnd moveToRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(moveToRangeEnd);
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
    if (openXmlElement is DXO2010W.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateModelElement(customXmlConflictInsertionRangeStart);
    if (openXmlElement is DXO2010W.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEnd)
      return DMXW.MarkupType2Converter.CreateModelElement(customXmlConflictInsertionRangeEnd);
    if (openXmlElement is DXO2010W.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateModelElement(customXmlConflictDeletionRangeStart);
    if (openXmlElement is DXO2010W.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEnd)
      return DMXW.MarkupType2Converter.CreateModelElement(customXmlConflictDeletionRangeEnd);
    if (openXmlElement is DXW.InsertedRun insertedRun)
      return DMXW.InsertedRunConverter.CreateModelElement(insertedRun);
    if (openXmlElement is DXW.DeletedRun deletedRun)
      return DMXW.DeletedRunConverter.CreateModelElement(deletedRun);
    if (openXmlElement is DXW.MoveFromRun moveFromRun)
      return DMXW.MoveFromRunConverter.CreateModelElement(moveFromRun);
    if (openXmlElement is DXW.MoveToRun moveToRun)
      return DMXW.MoveToRunConverter.CreateModelElement(moveToRun);
    if (openXmlElement is DXO2010W.RunConflictInsertion runConflictInsertion)
      return DMXW.RunConflictInsertionConverter.CreateModelElement(runConflictInsertion);
    if (openXmlElement is DXO2010W.RunConflictDeletion runConflictDeletion)
      return DMXW.RunConflictDeletionConverter.CreateModelElement(runConflictDeletion);
    return null;
  }

  public static bool CompareModelElement(DX.OpenXmlElement? openXmlElement, DMW.ICommonElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (openXmlElement is DXW.ProofError proofError)
        return DMXW.ProofErrorConverter.CompareModelElement(proofError, value as DMW.ProofError, diffs, objName);
      if (openXmlElement is DXW.PermStart permStart)
        return DMXW.PermStartConverter.CompareModelElement(permStart, value as DMW.PermStart, diffs, objName);
      if (openXmlElement is DXW.PermEnd permEnd)
        return DMXW.PermEndConverter.CompareModelElement(permEnd, value as DMW.PermEnd, diffs, objName);
      if (openXmlElement is DXW.BookmarkStart bookmarkStart)
        return DMXW.BookmarkStartConverter.CompareModelElement(bookmarkStart, value as DMW.BookmarkStart, diffs, objName);
      if (openXmlElement is DXW.BookmarkEnd bookmarkEnd)
        return DMXW.BookmarkEndConverter.CompareModelElement(bookmarkEnd, value as DMW.BookmarkEnd, diffs, objName);
      if (openXmlElement is DXW.CommentRangeStart commentRangeStart)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(commentRangeStart, value as DMW.MarkupRangeType, diffs, objName);
      if (openXmlElement is DXW.CommentRangeEnd commentRangeEnd)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(commentRangeEnd, value as DMW.MarkupRangeType, diffs, objName);
      if (openXmlElement is DXW.MoveFromRangeStart moveFromRangeStart)
        return DMXW.MoveBookmarkTypeConverter.CompareModelElement(moveFromRangeStart, value as DMW.MoveBookmarkType, diffs, objName);
      if (openXmlElement is DXW.MoveFromRangeEnd moveFromRangeEnd)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(moveFromRangeEnd, value as DMW.MarkupRangeType, diffs, objName);
      if (openXmlElement is DXW.MoveToRangeStart moveToRangeStart)
        return DMXW.MoveBookmarkTypeConverter.CompareModelElement(moveToRangeStart, value as DMW.MoveBookmarkType, diffs, objName);
      if (openXmlElement is DXW.MoveToRangeEnd moveToRangeEnd)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(moveToRangeEnd, value as DMW.MarkupRangeType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlInsRangeStart customXmlInsRangeStart)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlInsRangeStart, value as DMW.TrackChangeType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlInsRangeEnd customXmlInsRangeEnd)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlInsRangeEnd, value as DMW.MarkupType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlDelRangeStart customXmlDelRangeStart)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlDelRangeStart, value as DMW.TrackChangeType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlDelRangeEnd customXmlDelRangeEnd)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlDelRangeEnd, value as DMW.MarkupType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStart)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlMoveFromRangeStart, value as DMW.TrackChangeType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEnd)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlMoveFromRangeEnd, value as DMW.MarkupType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveToRangeStart customXmlMoveToRangeStart)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlMoveToRangeStart, value as DMW.TrackChangeType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEnd)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlMoveToRangeEnd, value as DMW.MarkupType, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStart)
        return DMXW.TrackChangeType2Converter.CompareModelElement(customXmlConflictInsertionRangeStart, value as DMW.TrackChangeType2, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEnd)
        return DMXW.MarkupType2Converter.CompareModelElement(customXmlConflictInsertionRangeEnd, value as DMW.MarkupType2, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStart)
        return DMXW.TrackChangeType2Converter.CompareModelElement(customXmlConflictDeletionRangeStart, value as DMW.TrackChangeType2, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEnd)
        return DMXW.MarkupType2Converter.CompareModelElement(customXmlConflictDeletionRangeEnd, value as DMW.MarkupType2, diffs, objName);
      if (openXmlElement is DXW.InsertedRun insertedRun)
        return DMXW.InsertedRunConverter.CompareModelElement(insertedRun, value as DMW.InsertedRun, diffs, objName);
      if (openXmlElement is DXW.DeletedRun deletedRun)
        return DMXW.DeletedRunConverter.CompareModelElement(deletedRun, value as DMW.DeletedRun, diffs, objName);
      if (openXmlElement is DXW.MoveFromRun moveFromRun)
        return DMXW.MoveFromRunConverter.CompareModelElement(moveFromRun, value as DMW.MoveFromRun, diffs, objName);
      if (openXmlElement is DXW.MoveToRun moveToRun)
        return DMXW.MoveToRunConverter.CompareModelElement(moveToRun, value as DMW.MoveToRun, diffs, objName);
      if (openXmlElement is DXO2010W.RunConflictInsertion runConflictInsertion)
        return DMXW.RunConflictInsertionConverter.CompareModelElement(runConflictInsertion, value as DMW.RunConflictInsertion, diffs, objName);
      if (openXmlElement is DXO2010W.RunConflictDeletion runConflictDeletion)
        return DMXW.RunConflictDeletionConverter.CompareModelElement(runConflictDeletion, value as DMW.RunConflictDeletion, diffs, objName);
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement? CreateOpenXmlElement(DMW.ICommonElement? value)
  {
    if (value is DMW.ProofError proofError)
      return DMXW.ProofErrorConverter.CreateOpenXmlElement(proofError);
    if (value is DMW.PermStart permStart)
      return DMXW.PermStartConverter.CreateOpenXmlElement(permStart);
    if (value is DMW.PermEnd permEnd)
      return DMXW.PermEndConverter.CreateOpenXmlElement(permEnd);
    if (value is DMW.BookmarkStart bookmarkStart)
      return DMXW.BookmarkStartConverter.CreateOpenXmlElement(bookmarkStart);
    if (value is DMW.BookmarkEnd bookmarkEnd)
      return DMXW.BookmarkEndConverter.CreateOpenXmlElement(bookmarkEnd);
    if (value is DMW.CommentRangeStart commentRangeStart)
      return DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement(commentRangeStart);
    if (value is DMW.CommentRangeEnd commentRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement(commentRangeEnd);
    if (value is DMW.MoveFromRangeStart moveFromRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement(moveFromRangeStart);
    if (value is DMW.MoveFromRangeEnd moveFromRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement(moveFromRangeEnd);
    if (value is DMW.MoveToRangeStart moveToRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement(moveToRangeStart);
    if (value is DMW.MoveToRangeEnd moveToRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.MoveFromRangeEnd>(moveToRangeEnd);
    if (value is DMW.CustomXmlInsRangeStart customXmlInsRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeStart>(customXmlInsRangeStart);
    if (value is DMW.CustomXmlInsRangeEnd customXmlInsRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeEnd>(customXmlInsRangeEnd);
    if (value is DMW.CustomXmlDelRangeStart customXmlDelRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeStart>(customXmlDelRangeStart);
    if (value is DMW.CustomXmlDelRangeEnd customXmlDelRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeEnd>(customXmlDelRangeEnd);
    if (value is DMW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeStart>(customXmlMoveFromRangeStart);
    if (value is DMW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeEnd>(customXmlMoveFromRangeEnd);
    if (value is DMW.CustomXmlMoveToRangeStart customXmlMoveToRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeStart>(customXmlMoveToRangeStart);
    if (value is DMW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeEnd>(customXmlMoveToRangeEnd);
    if (value is DMW.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeStart>(customXmlConflictInsertionRangeStart);
    if (value is DMW.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEnd)
      return DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeEnd>(customXmlConflictInsertionRangeEnd);
    if (value is DMW.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeStart>(customXmlConflictDeletionRangeStart);
    if (value is DMW.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEnd)
      return DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeEnd>(customXmlConflictDeletionRangeEnd);
    if (value is DMW.InsertedRun insertedRun)
      return DMXW.InsertedRunConverter.CreateOpenXmlElement<DXW.InsertedRun>(insertedRun);
    if (value is DMW.DeletedRun deletedRun)
      return DMXW.DeletedRunConverter.CreateOpenXmlElement<DXW.DeletedRun>(deletedRun);
    if (value is DMW.MoveFromRun moveFromRun)
      return DMXW.MoveFromRunConverter.CreateOpenXmlElement<DXW.MoveFromRun>(moveFromRun);
    if (value is DMW.MoveToRun moveToRun)
      return DMXW.MoveToRunConverter.CreateOpenXmlElement<DXW.MoveToRun>(moveToRun);
    if (value is DMW.RunConflictInsertion runConflictInsertion)
      return DMXW.RunConflictInsertionConverter.CreateOpenXmlElement<DXO2010W.RunConflictInsertion>(runConflictInsertion);
    if (value is DMW.RunConflictDeletion runConflictDeletion)
      return DMXW.RunConflictDeletionConverter.CreateOpenXmlElement<DXO2010W.RunConflictDeletion>(runConflictDeletion);
    return null;
  }

}
