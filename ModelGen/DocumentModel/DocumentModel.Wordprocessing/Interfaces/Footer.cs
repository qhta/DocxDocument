namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footer.
/// </summary>
public interface Footer
{
  public Collection<AltChunk>? AltChunks { get ; set; }
  
  public Collection<CustomXmlBlock>? CustomXmlBlocks { get ; set; }
  
  public Collection<SdtBlock>? SdtBlocks { get ; set; }
  
  public Collection<Paragraph>? Paragraphs { get ; set; }
  
  public Collection<Table>? Tables { get ; set; }
  
  public Collection<ProofError>? ProofErrors { get ; set; }
  
  public Collection<PermStart>? PermStarts { get ; set; }
  
  public Collection<PermEnd>? PermEnds { get ; set; }
  
  public Collection<BookmarkStart>? BookmarkStarts { get ; set; }
  
  public Collection<MarkupRangeType>? BookmarkEnds { get ; set; }
  
  public Collection<MarkupRangeType>? CommentRangeStarts { get ; set; }
  
  public Collection<MarkupRangeType>? CommentRangeEnds { get ; set; }
  
  public Collection<MoveBookmarkType>? MoveFromRangeStarts { get ; set; }
  
  public Collection<MarkupRangeType>? MoveFromRangeEnds { get ; set; }
  
  public Collection<MoveBookmarkType>? MoveToRangeStarts { get ; set; }
  
  public Collection<MarkupRangeType>? MoveToRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlInsRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlInsRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlDelRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlDelRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlMoveFromRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlMoveFromRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlMoveToRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlMoveToRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlConflictInsertionRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlConflictInsertionRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlConflictDeletionRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlConflictDeletionRangeEnds { get ; set; }
  
  public Collection<InsertedRun>? InsertedRuns { get ; set; }
  
  public Collection<DeletedRun>? DeletedRuns { get ; set; }
  
  public Collection<MoveFromRun>? MoveFromRuns { get ; set; }
  
  public Collection<MoveToRun>? MoveToRuns { get ; set; }
  
  public Collection<RunConflictInsertion>? RunConflictInsertions { get ; set; }
  
  public Collection<RunConflictDeletion>? RunConflictDeletions { get ; set; }
  
}
