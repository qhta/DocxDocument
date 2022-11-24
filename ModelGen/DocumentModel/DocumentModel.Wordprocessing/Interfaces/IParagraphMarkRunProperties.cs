namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties for the Paragraph Mark.
/// </summary>
public interface IParagraphMarkRunProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Inserted Paragraph.
  /// </summary>
  public Inserted? Inserted { get ; set; }
  
  /// <summary>
  /// Deleted Paragraph.
  /// </summary>
  public IDeleted? Deleted { get ; set; }
  
  /// <summary>
  /// Move Source Paragraph.
  /// </summary>
  public IMoveFrom? MoveFrom { get ; set; }
  
  /// <summary>
  /// Move Destination Paragraph.
  /// </summary>
  public IMoveTo? MoveTo { get ; set; }
  
}
