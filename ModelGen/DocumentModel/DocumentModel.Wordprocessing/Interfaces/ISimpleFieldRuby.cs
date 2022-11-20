namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SimpleFieldRuby Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IAccent))]
[ChildElementInfo(typeof(DocumentModel.Math.IBar))]
[ChildElementInfo(typeof(DocumentModel.Math.IBorderBox))]
[ChildElementInfo(typeof(DocumentModel.Math.IBox))]
[ChildElementInfo(typeof(DocumentModel.Math.IDelimiter))]
[ChildElementInfo(typeof(DocumentModel.Math.IEquationArray))]
[ChildElementInfo(typeof(DocumentModel.Math.IFraction))]
[ChildElementInfo(typeof(DocumentModel.Math.IMathFunction))]
[ChildElementInfo(typeof(DocumentModel.Math.IGroupChar))]
[ChildElementInfo(typeof(DocumentModel.Math.ILimitLower))]
[ChildElementInfo(typeof(DocumentModel.Math.ILimitUpper))]
[ChildElementInfo(typeof(DocumentModel.Math.IMatrix))]
[ChildElementInfo(typeof(DocumentModel.Math.INary))]
[ChildElementInfo(typeof(DocumentModel.Math.IOfficeMath))]
[ChildElementInfo(typeof(DocumentModel.Math.IParagraph))]
[ChildElementInfo(typeof(DocumentModel.Math.IPhantom))]
[ChildElementInfo(typeof(DocumentModel.Math.IRun))]
[ChildElementInfo(typeof(DocumentModel.Math.IRadical))]
[ChildElementInfo(typeof(DocumentModel.Math.IPreSubSuper))]
[ChildElementInfo(typeof(DocumentModel.Math.ISubscript))]
[ChildElementInfo(typeof(DocumentModel.Math.ISubSuperscript))]
[ChildElementInfo(typeof(DocumentModel.Math.ISuperscript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFieldData))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBookmarkStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IContentPart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlRuby))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IHyperlinkRuby))]
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
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRun))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IInsertedRun))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDeletedRun))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveFromRun))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveToRun))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IRunConflictInsertion))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IRunConflictDeletion))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISdtRunRuby))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISimpleFieldRuby))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlInsRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlDelRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveFromRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveToRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictInsertionRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictDeletionRangeStart))]
public interface ISimpleFieldRuby // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// instr
  /// </summary>
  public string? Instruction { get ; set; }
  
  /// <summary>
  /// fldLock
  /// </summary>
  public bool? FieldLock { get ; set; }
  
  /// <summary>
  /// dirty
  /// </summary>
  public bool? Dirty { get ; set; }
  
  /// <summary>
  /// FieldData.
  /// </summary>
  public IFieldData? FieldData { get ; set; }
  
}
