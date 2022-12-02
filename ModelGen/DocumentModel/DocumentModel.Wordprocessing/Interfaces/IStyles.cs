namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Styles.
/// </summary>
public interface IStyles // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Document Default Paragraph and Run Properties.
  /// </summary>
  public IDocDefaults? DocDefaults { get ; set; }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  public ILatentStyles? LatentStyles { get ; set; }
  
  public Collection<IStyle>? Styles { get ; set; }
  
}
