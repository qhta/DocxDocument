namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines conversion method for content block content.
/// </summary>
public static class ContentBlockContentConverter
{
  public static DM.IModelElement? CreateModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateModelElement(paragraph);
    if (openXmlElement is DXW.Table table)
      return DMXW.TableConverter.CreateModelElement(table);
    if (openXmlElement is DXW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateModelElement(customXmlBlock);
    if (openXmlElement is DXW.SdtBlock sdtBlock)
      return DMXW.SdtBlockConverter.CreateModelElement(sdtBlock);

    return null;
  }

  public static bool? CompareModelElement(DX.OpenXmlElement? openXmlElement, DMW.ICommonContent? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.ProofError proofError && value is DMW.ProofError proofErrorModel)
        return DMXW.ProofErrorConverter.CompareModelElement(proofError, proofErrorModel, diffs, objName);
      if (openXmlElement is DXW.PermStart permStart && value is DMW.PermStart permStartModel)
        return DMXW.PermStartConverter.CompareModelElement(permStart, permStartModel, diffs, objName);
      if (openXmlElement is DXW.PermEnd permEnd && value is DMW.PermEnd permEndModel)
        return DMXW.PermEndConverter.CompareModelElement(permEnd, permEndModel, diffs, objName);
      if (openXmlElement is DXW.BookmarkStart bookmarkStart && value is DMW.BookmarkStart bookmarkStartModel)
        return DMXW.BookmarkStartConverter.CompareModelElement(bookmarkStart, bookmarkStartModel, diffs, objName);
      if (openXmlElement is DXW.BookmarkEnd bookmarkEnd && value is DMW.BookmarkEnd bookmarkEndModel)
        return DMXW.BookmarkEndConverter.CompareModelElement(bookmarkEnd, bookmarkEndModel, diffs, objName);
      if (openXmlElement is DXW.CommentRangeStart commentRangeStart && value is DMW.CommentRangeStart commentRangeStartModel)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(commentRangeStart, commentRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.CommentRangeEnd commentRangeEnd && value is DMW.CommentRangeEnd commentRangeEndModel)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(commentRangeEnd, commentRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.MoveFromRangeStart moveFromRangeStart && value is DMW.MoveFromRangeStart moveFromRangeStartModel)
        return DMXW.MoveBookmarkTypeConverter.CompareModelElement(moveFromRangeStart, moveFromRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.MoveFromRangeEnd moveFromRangeEnd && value is DMW.MoveFromRangeEnd moveFromRangeEndModel)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(moveFromRangeEnd, moveFromRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.MoveToRangeStart moveToRangeStart && value is DMW.MoveToRangeStart moveToRangeStartModel)
        return DMXW.MoveBookmarkTypeConverter.CompareModelElement(moveToRangeStart, moveToRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.MoveToRangeEnd moveToRangeEnd && value is DMW.MoveToRangeEnd moveToRangeEndModel)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(moveToRangeEnd, moveToRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlInsRangeStart customXmlInsRangeStart && value is DMW.CustomXmlInsRangeStart customXmlInsRangeStartModel)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlInsRangeStart, customXmlInsRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlInsRangeEnd customXmlInsRangeEnd && value is DMW.CustomXmlInsRangeEnd customXmlInsRangeEndModel)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlInsRangeEnd, customXmlInsRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlDelRangeStart customXmlDelRangeStart && value is DMW.CustomXmlDelRangeStart customXmlDelRangeStartModel)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlDelRangeStart, customXmlDelRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlDelRangeEnd customXmlDelRangeEnd && value is DMW.CustomXmlDelRangeEnd customXmlDelRangeEndModel)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlDelRangeEnd, customXmlDelRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStart && value is DMW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStartModel)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlMoveFromRangeStart, customXmlMoveFromRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEnd && value is DMW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEndModel)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlMoveFromRangeEnd, customXmlMoveFromRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveToRangeStart customXmlMoveToRangeStart && value is DMW.CustomXmlMoveToRangeStart customXmlMoveToRangeStartModel)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlMoveToRangeStart, customXmlMoveToRangeStartModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEnd && value is DMW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEndModel)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlMoveToRangeEnd, customXmlMoveToRangeEndModel, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStart && value is DMW.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStartModel)
        return DMXW.TrackChangeType2Converter.CompareModelElement(customXmlConflictInsertionRangeStart, customXmlConflictInsertionRangeStartModel, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEnd && value is DMW.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEndModel)
        return DMXW.MarkupType2Converter.CompareModelElement(customXmlConflictInsertionRangeEnd, customXmlConflictInsertionRangeEndModel, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStart && value is DMW.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStartModel)
        return DMXW.TrackChangeType2Converter.CompareModelElement(customXmlConflictDeletionRangeStart, customXmlConflictDeletionRangeStartModel, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEnd && value is DMW.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEndModel)
        return DMXW.MarkupType2Converter.CompareModelElement(customXmlConflictDeletionRangeEnd, customXmlConflictDeletionRangeEndModel, diffs, objName);
      if (openXmlElement is DXW.InsertedRun insertedRun && value is DMW.InsertedRun insertedRunModel)
        return DMXW.InsertedRunConverter.CompareModelElement(insertedRun, insertedRunModel, diffs, objName);
      if (openXmlElement is DXW.DeletedRun deletedRun && value is DMW.DeletedRun deletedRunModel)
        return DMXW.DeletedRunConverter.CompareModelElement(deletedRun, deletedRunModel, diffs, objName);
      if (openXmlElement is DXW.MoveFromRun moveFromRun && value is DMW.MoveFromRun moveFromRunModel)
        return DMXW.MoveFromRunConverter.CompareModelElement(moveFromRun, moveFromRunModel, diffs, objName);
      if (openXmlElement is DXW.MoveToRun moveToRun && value is DMW.MoveToRun moveToRunModel)
        return DMXW.MoveToRunConverter.CompareModelElement(moveToRun, moveToRunModel, diffs, objName);
      if (openXmlElement is DXO2010W.RunConflictInsertion runConflictInsertion && value is DMW.RunConflictInsertion runConflictInsertionModel)
        return DMXW.RunConflictInsertionConverter.CompareModelElement(runConflictInsertion, value as DMW.RunConflictInsertion, diffs, objName);
      if (openXmlElement is DXO2010W.RunConflictDeletion runConflictDeletion && value is DMW.RunConflictDeletion runConflictDeletionModel)
        return DMXW.RunConflictDeletionConverter.CompareModelElement(runConflictDeletion, value as DMW.RunConflictDeletion, diffs, objName);
      return null;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement? CreateOpenXmlElement(DMW.ICommonContent? value)
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
