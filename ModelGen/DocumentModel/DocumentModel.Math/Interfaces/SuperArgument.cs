namespace DocumentModel.Math;

/// <summary>
/// Upper limit (n-ary).
/// </summary>
public interface SuperArgument // : DocumentModel.Math.OfficeMathArgumentType
{
  public ArgumentProperties? ArgumentProperties { get ; set; }
  
  public Collection<Accent>? Accents { get ; set; }
  
  public Collection<Bar>? Bars { get ; set; }
  
  public Collection<Box>? Boxs { get ; set; }
  
  public Collection<BorderBox>? BorderBoxs { get ; set; }
  
  public Collection<Delimiter>? Delimiters { get ; set; }
  
  public Collection<EquationArray>? EquationArraies { get ; set; }
  
  public Collection<Fraction>? Fractions { get ; set; }
  
  public Collection<MathFunction>? MathFunctions { get ; set; }
  
  public Collection<GroupChar>? GroupChars { get ; set; }
  
  public Collection<LimitLower>? LimitLowers { get ; set; }
  
  public Collection<LimitUpper>? LimitUppers { get ; set; }
  
  public Collection<Matrix>? Matrixs { get ; set; }
  
  public Collection<Nary>? Naries { get ; set; }
  
  public Collection<Phantom>? Phantoms { get ; set; }
  
  public Collection<Radical>? Radicals { get ; set; }
  
  public Collection<PreSubSuper>? PreSubSupers { get ; set; }
  
  public Collection<Subscript>? Subscripts { get ; set; }
  
  public Collection<SubSuperscript>? SubSuperscripts { get ; set; }
  
  public Collection<Superscript>? Superscripts { get ; set; }
  
  public Collection<Run>? Runs { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.CustomXmlRun>? CustomXmlRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.SimpleField>? SimpleFields { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Hyperlink>? Hyperlinks { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.SdtRun>? SdtRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ProofError>? ProofErrors { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.PermStart>? PermStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.PermEnd>? PermEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.BookmarkStart>? BookmarkStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupRangeType>? BookmarkEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupRangeType>? CommentRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupRangeType>? CommentRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MoveBookmarkType>? MoveFromRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupRangeType>? MoveFromRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MoveBookmarkType>? MoveToRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupRangeType>? MoveToRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlInsRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlInsRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlDelRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlDelRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlMoveFromRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlMoveFromRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlMoveToRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlMoveToRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlConflictInsertionRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlConflictInsertionRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlConflictDeletionRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlConflictDeletionRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.InsertedRun>? InsertedRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.DeletedRun>? DeletedRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MoveFromRun>? MoveFromRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MoveToRun>? MoveToRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.RunConflictInsertion>? RunConflictInsertions { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.RunConflictDeletion>? RunConflictDeletions { get ; set; }
  
  public Collection<Paragraph>? Paragraphs { get ; set; }
  
  public Collection<OfficeMath>? OfficeMaths { get ; set; }
  
  public ControlProperties? ControlProperties { get ; set; }
  
}
