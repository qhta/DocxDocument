namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAltChunk))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBookmarkStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IContentPart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlBlock))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlInsRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlDelRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveFromRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveToRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictInsertionRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictDeletionRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBookmarkEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICommentRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICommentRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveFromRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveToRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveFromRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveToRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IParagraph))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPermEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPermStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IProofError))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IInsertedRun))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDeletedRun))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveFromRun))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveToRun))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IRunConflictInsertion))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IRunConflictDeletion))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISdtBlock))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITable))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCellProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlInsRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlDelRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveFromRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveToRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictInsertionRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictDeletionRangeStart))]
public interface ITableCell // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Cell Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableCellProperties? TableCellProperties { get ; set; }
  
}
