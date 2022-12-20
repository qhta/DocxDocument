namespace DocumentModel.Drawings;

/// <summary>
/// Text Line Break.
/// </summary>
public partial interface Break
{
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  public DocumentModel.Drawings.RunProperties? RunProperties { get; set; }
  
}
