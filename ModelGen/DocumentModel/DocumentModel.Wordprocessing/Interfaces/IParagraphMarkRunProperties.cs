namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties for the Paragraph Mark.
/// </summary>
public interface IParagraphMarkRunProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Inserted Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.ITrackChangeType? Inserted { get ; set; }
  
  /// <summary>
  /// Deleted Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.ITrackChangeType? Deleted { get ; set; }
  
  /// <summary>
  /// Move Source Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.ITrackChangeType? MoveFrom { get ; set; }
  
  /// <summary>
  /// Move Destination Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.ITrackChangeType? MoveTo { get ; set; }
  
}
