namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comment Content.
/// </summary>
public interface IComment // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// initials
  /// </summary>
  public System.String? Initials { get ; set; }
  
  /// <summary>
  /// author
  /// </summary>
  public System.String? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public System.DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IAltChunk>? AltChunks { get ; set; }
  
  public DocumentModel.Wordprocessing.ICustomXmlBlock? CustomXmlBlock { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtBlock? SdtBlock { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IParagraph>? Paragraphs { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ITable>? Tables { get ; set; }
  
  public DocumentModel.Wordprocessing.IProofError? ProofError { get ; set; }
  
  public DocumentModel.Wordprocessing.IPermStart? PermStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IPermEnd? PermEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IBookmarkStart? BookmarkStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? BookmarkEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? CommentRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? CommentRangeEnd { get ; set; }
  
}
