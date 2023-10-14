namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of run properties applied to the glyph used to represent the physical location of the paragraph mark for this paragraph. This paragraph mark, being a physical character in the document, can be formatted, and therefore shall be capable of representing this formatting like any other character in the document.
/// </summary>
public partial class PreviousParagraphMarkRunProperties
{
  
  /// <summary>
  ///   Inserted Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.Inserted? Inserted { get; set; }
  
  
  /// <summary>
  ///   Deleted Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.Deleted? Deleted { get; set; }
  
  
  /// <summary>
  ///   Move Source Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.MoveFrom? MoveFrom { get; set; }
  
  
  /// <summary>
  ///   Move Destination Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.MoveTo? MoveTo { get; set; }
  
  public DocumentModel.Wordprocessing.ConflictInsertion? ConflictInsertion { get; set; }
  
  public DocumentModel.Wordprocessing.ConflictDeletion? ConflictDeletion { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
