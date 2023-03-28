namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines conversion method for common run elements: 
/// ProofError, PermStart/PermEnd, BookmarkStart/BookmarkEnd, CommentRangeStart/CommentRangeEnd,
/// MoveFromStart/MoveFromEnd, MoveToStart/MoveToEnd, 
/// CustomXmlInsRangeStart/CustomXmlInsRangeEnd, CustomXmlDelRangeStart/CustomXmlDelRangeEnd,
/// CustomXmMoveFromStart/CustomXmMoveFromEnd, CustomXmMoveToStart/CustomXmMoveToEnd, 
/// CustomXmConflictInsertionStart/CustomXmConflictInsertionEnd, CustomXmConflictDeletionStart/CustomXmConflictDeletionEnd, 
/// InsertedRun, DeletedRun, MoveFromRun, MoveToRun, RunConflictInsertion, RunConflictDeletion converter from/to OpenXml.
///</summary>
public static class CommonRunConverter
{
  public static DMW.ICommonRunElement? CreateModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.Run run)
      return DMXW.RunConverter.CreateModelElement(run);
    if (openXmlElement is DXW.Hyperlink hyperlink)
      return DMXW.HyperlinkConverter.CreateModelElement(hyperlink);
    if (openXmlElement is DXW.CustomXmlRun customXmlRun)
      return DMXW.CustomXmlRunConverter.CreateModelElement(customXmlRun);
    if (openXmlElement is DXW.SimpleField simpleField)
      return DMXW.SimpleFieldConverter.CreateModelElement(simpleField);
    if (openXmlElement is DXW.SdtRun sdtRun)
      return DMXW.SdtRunConverter.CreateModelElement(sdtRun);
    if (openXmlElement is DXW.BidirectionalOverride bidirectionalOverride)
      return DMXW.BidirectionalOverrideConverter.CreateModelElement(bidirectionalOverride);
    if (openXmlElement is DXW.BidirectionalEmbedding bidirectionalEmbedding)
      return DMXW.BidirectionalEmbeddingConverter.CreateModelElement(bidirectionalEmbedding);
    if (openXmlElement is DXW.SubDocumentReference subDocumentReference)
      return DMXW.RelationshipTypeConverter.CreateModelElement(subDocumentReference);
    return null;
  }

  public static bool? CompareModelElement(DX.OpenXmlElement? openXmlElement, DMW.ICommonRunElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.Run run && value is DMW.Run runModel)
        return DMXW.RunConverter.CompareModelElement(run, runModel, diffs, objName);
      if (openXmlElement is DXW.Hyperlink hyperlink && value is DMW.Hyperlink hyperlinkModel)
        return DMXW.HyperlinkConverter.CompareModelElement(hyperlink, hyperlinkModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlRun customXmlRun && value is DMW.CustomXmlRun customXmlRunModel)
        return DMXW.CustomXmlRunConverter.CompareModelElement(customXmlRun, customXmlRunModel, diffs, objName);
      if (openXmlElement is DXW.SimpleField simpleField && value is DMW.SimpleField simpleFieldModel)
        return DMXW.SimpleFieldConverter.CompareModelElement(simpleField, simpleFieldModel, diffs, objName);
      if (openXmlElement is DXW.SdtRun sdtRun && value is DMW.SdtRun sdtRunModel)
        return DMXW.SdtRunConverter.CompareModelElement(sdtRun, sdtRunModel, diffs, objName);
      if (openXmlElement is DXW.BidirectionalOverride bidirectionalOverride && value is DMW.BidirectionalOverride bidirectionalOverrideModel)
        return DMXW.BidirectionalOverrideConverter.CompareModelElement(bidirectionalOverride, bidirectionalOverrideModel, diffs, objName);
      if (openXmlElement is DXW.BidirectionalEmbedding bidirectionalEmbedding && value is DMW.BidirectionalEmbedding bidirectionalEmbeddingModel)
        return DMXW.BidirectionalEmbeddingConverter.CompareModelElement(bidirectionalEmbedding, bidirectionalEmbeddingModel, diffs, objName);
      if (openXmlElement is DXW.SubDocumentReference subDocumentReference && value is DMW.SubDocumentReference subDocumentReferenceModel)
        return DMXW.RelationshipTypeConverter.CompareModelElement(subDocumentReference, subDocumentReferenceModel, diffs, objName);
      return null;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement? CreateOpenXmlElement(DMW.ICommonRunElement? value)
  {
    if (value is DMW.Run run)
      return DMXW.RunConverter.CreateOpenXmlElement(run);
    if (value is DMW.Hyperlink hyperlink)
      return DMXW.HyperlinkConverter.CreateOpenXmlElement(hyperlink);
    if (value is DMW.CustomXmlRun customXmlRun)
      return DMXW.CustomXmlRunConverter.CreateOpenXmlElement(customXmlRun);
    if (value is DMW.SimpleField simpleField)
      return DMXW.SimpleFieldConverter.CreateOpenXmlElement(simpleField);
    if (value is DMW.SdtRun sdtRun)
      return DMXW.SdtRunConverter.CreateOpenXmlElement(sdtRun);
    if (value is DMW.BidirectionalOverride bidirectionalOverride)
      return DMXW.BidirectionalOverrideConverter.CreateOpenXmlElement(bidirectionalOverride);
    if (value is DMW.BidirectionalEmbedding bidirectionalEmbedding)
      return DMXW.BidirectionalEmbeddingConverter.CreateOpenXmlElement(bidirectionalEmbedding);
    if (value is DMW.SubDocumentReference subDocumentReference)
      return DMXW.RelationshipTypeConverter.CreateOpenXmlElement(subDocumentReference);
    return null;
  }

}
