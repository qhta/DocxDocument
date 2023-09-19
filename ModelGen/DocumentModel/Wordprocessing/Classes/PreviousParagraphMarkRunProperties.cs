namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of run properties applied to the glyph used to represent the physical location of the paragraph mark for this paragraph. This paragraph mark, being a physical character in the document, can be formatted, and therefore shall be capable of representing this formatting like any other character in the document.
/// </summary>
public partial class PreviousParagraphMarkRunProperties
{
  
  /// <summary>
  ///   Inserted Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.TrackChangeType? Inserted { get; set; }
  
  
  /// <summary>
  ///   Deleted Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.TrackChangeType? Deleted { get; set; }
  
  
  /// <summary>
  ///   Move Source Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.TrackChangeType? MoveFrom { get; set; }
  
  
  /// <summary>
  ///   Move Destination Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.TrackChangeType? MoveTo { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? ConflictInsertion { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? ConflictDeletion { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
