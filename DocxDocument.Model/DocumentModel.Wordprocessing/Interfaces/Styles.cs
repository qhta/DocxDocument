namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Styles.
/// </summary>
public partial interface Styles
{
  /// <summary>
  /// Gets the StylesPart associated with this element, it could either be a StyleDefinitionsPart or a StylesWithEffectsPart.
  /// </summary>
  public DocumentModel.Packaging.StylesPart? StylesPart { get; set; }
  
  /// <summary>
  /// Document Default Paragraph and Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.DocDefaults? DocDefaults { get; set; }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  public DocumentModel.Wordprocessing.LatentStyles? LatentStyles { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.Style>? Items { get; set; }
  
}
