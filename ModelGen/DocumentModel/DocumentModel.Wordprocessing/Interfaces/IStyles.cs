namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Styles.
/// </summary>
public interface IStyles // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the StylesPart associated with this element, it could either be a StyleDefinitionsPart or a StylesWithEffectsPart.
  /// </summary>
  public IStylesPart? StylesPart { get ; set; }
  
  /// <summary>
  /// Document Default Paragraph and Run Properties.
  /// </summary>
  public IDocDefaults? DocDefaults { get ; set; }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  public ILatentStyles? LatentStyles { get ; set; }
  
}
