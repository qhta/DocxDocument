namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentTasksPart
/// </summary>
public interface DocumentTasksPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Tasks? Tasks { get ; set; }
  
}
