namespace DocumentModel.Math;

/// <summary>
/// Numerator.
/// </summary>
public interface INumerator // : DocumentModel.Math.IOfficeMathArgumentType
{
  public IArgumentProperties? ArgumentProperties { get ; set; }
  
  public Collection<IAccent>? Accents { get ; set; }
  
  public Collection<IBar>? Bars { get ; set; }
  
  public Collection<IBox>? Boxs { get ; set; }
  
  public Collection<IBorderBox>? BorderBoxs { get ; set; }
  
  public Collection<IDelimiter>? Delimiters { get ; set; }
  
  public Collection<IEquationArray>? EquationArraies { get ; set; }
  
  public Collection<IFraction>? Fractions { get ; set; }
  
  public Collection<IMathFunction>? MathFunctions { get ; set; }
  
  public Collection<IGroupChar>? GroupChars { get ; set; }
  
  public Collection<ILimitLower>? LimitLowers { get ; set; }
  
  public Collection<ILimitUpper>? LimitUppers { get ; set; }
  
  public Collection<IMatrix>? Matrixs { get ; set; }
  
  public Collection<INary>? Naries { get ; set; }
  
  public Collection<IPhantom>? Phantoms { get ; set; }
  
  public Collection<IRadical>? Radicals { get ; set; }
  
  public Collection<IPreSubSuper>? PreSubSupers { get ; set; }
  
  public Collection<ISubscript>? Subscripts { get ; set; }
  
  public Collection<ISubSuperscript>? SubSuperscripts { get ; set; }
  
  public Collection<ISuperscript>? Superscripts { get ; set; }
  
  public Collection<IRun>? Runs { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ICustomXmlRun>? CustomXmlRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ISimpleField>? SimpleFields { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IHyperlink>? Hyperlinks { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ISdtRun>? SdtRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IProofError>? ProofErrors { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IPermStart>? PermStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IPermEnd>? PermEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IBookmarkStart>? BookmarkStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupRangeType>? BookmarkEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupRangeType>? CommentRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupRangeType>? CommentRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMoveBookmarkType>? MoveFromRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupRangeType>? MoveFromRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMoveBookmarkType>? MoveToRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupRangeType>? MoveToRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlInsRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlInsRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlDelRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlDelRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlMoveFromRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlMoveFromRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlMoveToRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlMoveToRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlConflictInsertionRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlConflictInsertionRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlConflictDeletionRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlConflictDeletionRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IInsertedRun>? InsertedRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IDeletedRun>? DeletedRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMoveFromRun>? MoveFromRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMoveToRun>? MoveToRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IRunConflictInsertion>? RunConflictInsertions { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IRunConflictDeletion>? RunConflictDeletions { get ; set; }
  
  public Collection<IParagraph>? Paragraphs { get ; set; }
  
  public Collection<IOfficeMath>? OfficeMaths { get ; set; }
  
  public IControlProperties? ControlProperties { get ; set; }
  
}
