namespace DocumentModel.Wordprocessing;

/// <summary>
/// Rich Text Box Content Container.
/// </summary>
public interface ITextBoxContent // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IAltChunk>? AltChunks { get ; set; }
  
  public Collection<ICustomXmlBlock>? CustomXmlBlocks { get ; set; }
  
  public Collection<ISdtBlock>? SdtBlocks { get ; set; }
  
  public Collection<IParagraph>? Paragraphs { get ; set; }
  
  public Collection<ITable>? Tables { get ; set; }
  
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
  
}
