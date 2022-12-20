namespace DocumentModel.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
public partial interface Drawing
{
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.Anchor? Anchor { get; set; }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.Inline? Inline { get; set; }
  
}
