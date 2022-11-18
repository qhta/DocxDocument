namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBookmarkStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IContentPart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlCell))]
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
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPermEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPermStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IProofError))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IInsertedRun))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDeletedRun))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveFromRun))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveToRun))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IRunConflictInsertion))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IRunConflictDeletion))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISdtCell))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITablePropertyExceptions))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableCell))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlInsRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlDelRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveFromRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveToRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictInsertionRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictDeletionRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITableRowProperties))]
public interface ITableRow // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  public IHexBinaryValue? RsidTableRowMarkRevision { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row
  /// </summary>
  public IHexBinaryValue? RsidTableRowAddition { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Deletion
  /// </summary>
  public IHexBinaryValue? RsidTableRowDeletion { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Properties
  /// </summary>
  public IHexBinaryValue? RsidTableRowProperties { get ; set; }
  
  /// <summary>
  /// paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? ParagraphId { get ; set; }
  
  /// <summary>
  /// textId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? TextId { get ; set; }
  
  /// <summary>
  /// Table-Level Property Exceptions.
  /// </summary>
  public ITablePropertyExceptions? TablePropertyExceptions { get ; set; }
  
  /// <summary>
  /// Table Row Properties.
  /// </summary>
  public ITableRowProperties? TableRowProperties { get ; set; }
  
}
