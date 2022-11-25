namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Styles.
/// </summary>
public interface IStyles // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Document Default Paragraph and Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IDocDefaults? DocDefaults { get ; set; }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  public DocumentModel.Wordprocessing.ILatentStyles? LatentStyles { get ; set; }
  
}
