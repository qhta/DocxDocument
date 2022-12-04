namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Styles.
/// </summary>
public class Styles
{
  /// <summary>
  /// Document Default Paragraph and Run Properties.
  /// </summary>
  public DocDefaults? DocDefaults
  {
    get;
    set;
  }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  public LatentStyles? LatentStyles
  {
    get;
    set;
  }
  
}
