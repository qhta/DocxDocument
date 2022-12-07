namespace DocumentModel.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
public class DrawingImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Drawing>, Drawing
{
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.Anchor? Anchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawings.Inline? Inline
  {
    get;
    set;
  }
  
}
