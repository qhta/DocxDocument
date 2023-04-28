namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines conversion methods for common markers: 
/// ProofError, PermStart/PermEnd, 
/// InsertedRun, DeletedRun, MoveFromRun, MoveToRun, RunConflictInsertion, RunConflictDeletion,
/// BookmarkStart/BookmarkEnd, CommentRangeStart/CommentRangeEnd,
/// MoveFromStart/MoveFromEnd, MoveToStart/MoveToEnd, 
/// CustomXmlInsRangeStart/CustomXmlInsRangeEnd, CustomXmlDelRangeStart/CustomXmlDelRangeEnd,
/// CustomXmMoveFromStart/CustomXmMoveFromEnd, CustomXmMoveToStart/CustomXmMoveToEnd, 
/// CustomXmConflictInsertionStart/CustomXmConflictInsertionEnd, CustomXmConflictDeletionStart/CustomXmConflictDeletionEnd. 
/// </summary>
public static class CommonMarkersConverter
{
  public static DMW.ICommonContent? CreateModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.ProofError proofError)
      return DMXW.ProofErrorConverter.CreateModelElement(proofError);
    if (openXmlElement is DXW.PermStart permStart)
      return DMXW.PermStartConverter.CreateModelElement(permStart);
    if (openXmlElement is DXW.PermEnd permEnd)
      return DMXW.PermEndConverter.CreateModelElement(permEnd);
    if (openXmlElement is DXW.InsertedRun insertedRun)
      return DMXW.InsertedRunConverter.CreateModelElement(insertedRun);
    if (openXmlElement is DXW.DeletedRun deletedRun)
      return DMXW.DeletedRunConverter.CreateModelElement(deletedRun);
    if (openXmlElement is DXW.MoveFromRun moveFromRun)
      return DMXW.MoveFromRunConverter.CreateModelElement(moveFromRun);
    if (openXmlElement is DXW.MoveToRun moveToRun)
      return DMXW.MoveToRunConverter.CreateModelElement(moveToRun);
    if (openXmlElement is DXO10W.RunConflictInsertion runConflictInsertion)
      return DMXW.RunConflictInsertionConverter.CreateModelElement(runConflictInsertion);
    if (openXmlElement is DXO10W.RunConflictDeletion runConflictDeletion)
      return DMXW.RunConflictDeletionConverter.CreateModelElement(runConflictDeletion);
    return RangeMarkersConverter.CreateModelElement(openXmlElement);
  }

  public static bool? CompareModelElement(DX.OpenXmlElement? openXmlElement, DMW.ICommonContent? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.ProofError proofError && model is DMW.ProofError proofErrorModel)
        return DMXW.ProofErrorConverter.CompareModelElement(proofError, proofErrorModel, diffs, objName);
      if (openXmlElement is DXW.PermStart permStart && model is DMW.PermStart permStartModel)
        return DMXW.PermStartConverter.CompareModelElement(permStart, permStartModel, diffs, objName);
      if (openXmlElement is DXW.PermEnd permEnd && model is DMW.PermEnd permEndModel)
        return DMXW.PermEndConverter.CompareModelElement(permEnd, permEndModel, diffs, objName);
      if (openXmlElement is DXW.InsertedRun insertedRun && model is DMW.InsertedRun insertedRunModel)
        return DMXW.InsertedRunConverter.CompareModelElement(insertedRun, insertedRunModel, diffs, objName);
      if (openXmlElement is DXW.DeletedRun deletedRun && model is DMW.DeletedRun deletedRunModel)
        return DMXW.DeletedRunConverter.CompareModelElement(deletedRun, deletedRunModel, diffs, objName);
      if (openXmlElement is DXW.MoveFromRun moveFromRun && model is DMW.MoveFromRun moveFromRunModel)
        return DMXW.MoveFromRunConverter.CompareModelElement(moveFromRun, moveFromRunModel, diffs, objName);
      if (openXmlElement is DXW.MoveToRun moveToRun && model is DMW.MoveToRun moveToRunModel)
        return DMXW.MoveToRunConverter.CompareModelElement(moveToRun, moveToRunModel, diffs, objName);
      if (openXmlElement is DXO10W.RunConflictInsertion runConflictInsertion && model is DMW.RunConflictInsertion runConflictInsertionModel)
        return DMXW.RunConflictInsertionConverter.CompareModelElement(runConflictInsertion, model as DMW.RunConflictInsertion, diffs, objName);
      if (openXmlElement is DXO10W.RunConflictDeletion runConflictDeletion && model is DMW.RunConflictDeletion runConflictDeletionModel)
        return DMXW.RunConflictDeletionConverter.CompareModelElement(runConflictDeletion, model as DMW.RunConflictDeletion, diffs, objName);
      return RangeMarkersConverter.CompareModelElement(openXmlElement, model, diffs, objName);
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElement? CreateOpenXmlElement(DMW.ICommonContent? model)
  {
    if (model is DMW.ProofError proofError)
      return DMXW.ProofErrorConverter.CreateOpenXmlElement(proofError);
    if (model is DMW.PermStart permStart)
      return DMXW.PermStartConverter.CreateOpenXmlElement(permStart);
    if (model is DMW.PermEnd permEnd)
      return DMXW.PermEndConverter.CreateOpenXmlElement(permEnd);
    if (model is DMW.InsertedRun insertedRun)
      return DMXW.InsertedRunConverter.CreateOpenXmlElement<DXW.InsertedRun>(insertedRun);
    if (model is DMW.DeletedRun deletedRun)
      return DMXW.DeletedRunConverter.CreateOpenXmlElement<DXW.DeletedRun>(deletedRun);
    if (model is DMW.MoveFromRun moveFromRun)
      return DMXW.MoveFromRunConverter.CreateOpenXmlElement<DXW.MoveFromRun>(moveFromRun);
    if (model is DMW.MoveToRun moveToRun)
      return DMXW.MoveToRunConverter.CreateOpenXmlElement<DXW.MoveToRun>(moveToRun);
    if (model is DMW.RunConflictInsertion runConflictInsertion)
      return DMXW.RunConflictInsertionConverter.CreateOpenXmlElement<DXO10W.RunConflictInsertion>(runConflictInsertion);
    if (model is DMW.RunConflictDeletion runConflictDeletion)
      return DMXW.RunConflictDeletionConverter.CreateOpenXmlElement<DXO10W.RunConflictDeletion>(runConflictDeletion);
    return RangeMarkersConverter.CreateOpenXmlElement(model);
  }

    public static bool? UpdateOpenXmlElement(DX.OpenXmlElement? openXmlElement, DMW.ICommonContent? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.ProofError proofError && model is DMW.ProofError proofErrorModel)
        return DMXW.ProofErrorConverter.UpdateOpenXmlElement(proofError, proofErrorModel);
      if (openXmlElement is DXW.PermStart permStart && model is DMW.PermStart permStartModel)
        return DMXW.PermStartConverter.UpdateOpenXmlElement(permStart, permStartModel);
      if (openXmlElement is DXW.PermEnd permEnd && model is DMW.PermEnd permEndModel)
        return DMXW.PermEndConverter.UpdateOpenXmlElement(permEnd, permEndModel);
      if (openXmlElement is DXW.InsertedRun insertedRun && model is DMW.InsertedRun insertedRunModel)
        return DMXW.InsertedRunConverter.UpdateOpenXmlElement(insertedRun, insertedRunModel);
      if (openXmlElement is DXW.DeletedRun deletedRun && model is DMW.DeletedRun deletedRunModel)
        return DMXW.DeletedRunConverter.UpdateOpenXmlElement(deletedRun, deletedRunModel);
      if (openXmlElement is DXW.MoveFromRun moveFromRun && model is DMW.MoveFromRun moveFromRunModel)
        return DMXW.MoveFromRunConverter.UpdateOpenXmlElement(moveFromRun, moveFromRunModel);
      if (openXmlElement is DXW.MoveToRun moveToRun && model is DMW.MoveToRun moveToRunModel)
        return DMXW.MoveToRunConverter.UpdateOpenXmlElement(moveToRun, moveToRunModel);
      if (openXmlElement is DXO10W.RunConflictInsertion runConflictInsertion && model is DMW.RunConflictInsertion runConflictInsertionModel)
        return DMXW.RunConflictInsertionConverter.UpdateOpenXmlElement(runConflictInsertion, runConflictInsertionModel);
      if (openXmlElement is DXO10W.RunConflictDeletion runConflictDeletion && model is DMW.RunConflictDeletion runConflictDeletionModel)
        return DMXW.RunConflictDeletionConverter.UpdateOpenXmlElement(runConflictDeletion, runConflictDeletionModel);
      return RangeMarkersConverter.UpdateOpenXmlElement(openXmlElement, model);
    }
    return false;
  }

}
