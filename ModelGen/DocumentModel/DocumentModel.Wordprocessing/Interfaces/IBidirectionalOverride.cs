namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BidirectionalOverride Class.
/// </summary>
public interface IBidirectionalOverride // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// val
  /// </summary>
  public DirectionKind? Val { get ; set; }
  
  public Collection<ICustomXmlRun>? CustomXmlRuns { get ; set; }
  
  public Collection<ISimpleField>? SimpleFields { get ; set; }
  
  public Collection<IHyperlink>? Hyperlinks { get ; set; }
  
  public Collection<ISdtRun>? SdtRuns { get ; set; }
  
  public Collection<IProofError>? ProofErrors { get ; set; }
  
  public Collection<IPermStart>? PermStarts { get ; set; }
  
  public Collection<IPermEnd>? PermEnds { get ; set; }
  
  public Collection<IBookmarkStart>? BookmarkStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? BookmarkEnds { get ; set; }
  
  public Collection<IMarkupRangeType>? CommentRangeStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? CommentRangeEnds { get ; set; }
  
  public Collection<IMoveBookmarkType>? MoveFromRangeStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? MoveFromRangeEnds { get ; set; }
  
  public Collection<IMoveBookmarkType>? MoveToRangeStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? MoveToRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlInsRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlInsRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlDelRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlDelRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlMoveFromRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlMoveFromRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlMoveToRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlMoveToRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlConflictInsertionRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlConflictInsertionRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlConflictDeletionRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlConflictDeletionRangeEnds { get ; set; }
  
  public Collection<IInsertedRun>? InsertedRuns { get ; set; }
  
  public Collection<IDeletedRun>? DeletedRuns { get ; set; }
  
  public Collection<IMoveFromRun>? MoveFromRuns { get ; set; }
  
  public Collection<IMoveToRun>? MoveToRuns { get ; set; }
  
  public Collection<IRunConflictInsertion>? RunConflictInsertions { get ; set; }
  
  public Collection<IRunConflictDeletion>? RunConflictDeletions { get ; set; }
  
  public Collection<DocumentModel.Math.IParagraph>? Paragraphs { get ; set; }
  
  public Collection<DocumentModel.Math.IOfficeMath>? OfficeMaths { get ; set; }
  
  public Collection<DocumentModel.Math.IAccent>? Accents { get ; set; }
  
  public Collection<DocumentModel.Math.IBar>? Bars { get ; set; }
  
  public Collection<DocumentModel.Math.IBox>? Boxs { get ; set; }
  
  public Collection<DocumentModel.Math.IBorderBox>? BorderBoxs { get ; set; }
  
  public Collection<DocumentModel.Math.IDelimiter>? Delimiters { get ; set; }
  
  public Collection<DocumentModel.Math.IEquationArray>? EquationArraies { get ; set; }
  
  public Collection<DocumentModel.Math.IFraction>? Fractions { get ; set; }
  
  public Collection<DocumentModel.Math.IMathFunction>? MathFunctions { get ; set; }
  
  public Collection<DocumentModel.Math.IGroupChar>? GroupChars { get ; set; }
  
  public Collection<DocumentModel.Math.ILimitLower>? LimitLowers { get ; set; }
  
  public Collection<DocumentModel.Math.ILimitUpper>? LimitUppers { get ; set; }
  
  public Collection<DocumentModel.Math.IMatrix>? Matrixs { get ; set; }
  
  public Collection<DocumentModel.Math.INary>? Naries { get ; set; }
  
  public Collection<DocumentModel.Math.IPhantom>? Phantoms { get ; set; }
  
  public Collection<DocumentModel.Math.IRadical>? Radicals { get ; set; }
  
  public Collection<DocumentModel.Math.IPreSubSuper>? PreSubSupers { get ; set; }
  
  public Collection<DocumentModel.Math.ISubscript>? Subscripts { get ; set; }
  
  public Collection<DocumentModel.Math.ISubSuperscript>? SubSuperscripts { get ; set; }
  
  public Collection<DocumentModel.Math.ISuperscript>? Superscripts { get ; set; }
  
  public Collection<DocumentModel.Math.IRun>? Runs { get ; set; }
  
  public Collection<IBidirectionalOverride>? BidirectionalOverrides { get ; set; }
  
  public Collection<IBidirectionalEmbedding>? BidirectionalEmbeddings { get ; set; }
  
  public Collection<IRelationshipType>? SubDocumentReferences { get ; set; }
  
}
