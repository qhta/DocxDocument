namespace DocumentModel.Drawings;

/// <summary>
/// Text Line Break.
/// </summary>
public interface Break
{
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  public DocumentModel.Drawings.RunProperties? RunProperties { get ; set; }
  
}
