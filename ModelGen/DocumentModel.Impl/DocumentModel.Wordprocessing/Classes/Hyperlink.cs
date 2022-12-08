namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Hyperlink Class.
/// </summary>
public class HyperlinkImpl: ModelElementImpl, Hyperlink
{
  public DocumentFormat.OpenXml.Wordprocessing.Hyperlink? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Hyperlink?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Hyperlink Target Frame
  /// </summary>
  public String? TargetFrame
  {
    get;
    set;
  }
  
  /// <summary>
  /// Associated String
  /// </summary>
  public String? Tooltip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Location in Target Document
  /// </summary>
  public String? DocLocation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Add To Viewed Hyperlinks
  /// </summary>
  public Boolean? History
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hyperlink Anchor
  /// </summary>
  public String? Anchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  public Collection<CustomXmlRun>? CustomXmlRuns
  {
    get;
    set;
  }
  
  public Collection<SimpleField>? SimpleFields
  {
    get;
    set;
  }
  
  public Collection<Hyperlink>? Hyperlinks
  {
    get;
    set;
  }
  
  public Collection<SdtRun>? SdtRuns
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
  
  public Collection<DocumentModel.Math.Run>? Runs
  {
    get;
    set;
  }
  
  public Collection<BidirectionalOverride>? BidirectionalOverrides
  {
    get;
    set;
  }
  
  public Collection<BidirectionalEmbedding>? BidirectionalEmbeddings
  {
    get;
    set;
  }
  
  public Collection<RelationshipType>? SubDocumentReferences
  {
    get;
    set;
  }
  
}
