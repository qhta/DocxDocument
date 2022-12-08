namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Base Text.
/// </summary>
public class RubyBaseImpl: ModelElementImpl, RubyBase
{
  public DocumentFormat.OpenXml.Wordprocessing.RubyBase? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RubyBase?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<CustomXmlRuby>? CustomXmlRubies
  {
    get;
    set;
  }
  
  public Collection<SimpleFieldRuby>? SimpleFieldRubies
  {
    get;
    set;
  }
  
  public Collection<HyperlinkRuby>? HyperlinkRubies
  {
    get;
    set;
  }
  
  public Collection<Run>? Runs
  {
    get;
    set;
  }
  
  public Collection<SdtRunRuby>? SdtRunRubies
  {
    get;
    set;
  }
  
  public Collection<ProofError>? ProofErrors
  {
    get;
    set;
  }
  
  public Collection<PermStart>? PermStarts
  {
    get;
    set;
  }
  
  public Collection<PermEnd>? PermEnds
  {
    get;
    set;
  }
  
  public Collection<BookmarkStart>? BookmarkStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupRangeType>? BookmarkEnds
  {
    get;
    set;
  }
  
  public Collection<MarkupRangeType>? CommentRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupRangeType>? CommentRangeEnds
  {
    get;
    set;
  }
  
  public Collection<MoveBookmarkType>? MoveFromRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupRangeType>? MoveFromRangeEnds
  {
    get;
    set;
  }
  
  public Collection<MoveBookmarkType>? MoveToRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupRangeType>? MoveToRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlInsRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlInsRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlDelRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlDelRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlMoveFromRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlMoveFromRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlMoveToRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlMoveToRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlConflictInsertionRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlConflictInsertionRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlConflictDeletionRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlConflictDeletionRangeEnds
  {
    get;
    set;
  }
  
  public Collection<InsertedRun>? InsertedRuns
  {
    get;
    set;
  }
  
  public Collection<DeletedRun>? DeletedRuns
  {
    get;
    set;
  }
  
  public Collection<MoveFromRun>? MoveFromRuns
  {
    get;
    set;
  }
  
  public Collection<MoveToRun>? MoveToRuns
  {
    get;
    set;
  }
  
  public Collection<RunConflictInsertion>? RunConflictInsertions
  {
    get;
    set;
  }
  
  public Collection<RunConflictDeletion>? RunConflictDeletions
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Paragraph>? Paragraphs
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.OfficeMath>? OfficeMaths
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Accent>? Accents
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Bar>? Bars
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Box>? Boxs
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.BorderBox>? BorderBoxs
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Delimiter>? Delimiters
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.EquationArray>? EquationArraies
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Fraction>? Fractions
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.MathFunction>? MathFunctions
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.GroupChar>? GroupChars
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.LimitLower>? LimitLowers
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.LimitUpper>? LimitUppers
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Matrix>? Matrixs
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Nary>? Naries
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Phantom>? Phantoms
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Radical>? Radicals
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.PreSubSuper>? PreSubSupers
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Subscript>? Subscripts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.SubSuperscript>? SubSuperscripts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Math.Superscript>? Superscripts
  {
    get;
    set;
  }
  
}
