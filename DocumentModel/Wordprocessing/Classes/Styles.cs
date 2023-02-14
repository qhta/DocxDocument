namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines Styles.
/// </summary>
public partial class Styles
{
  /// <summary>
  ///   Document Default Paragraph and Run Properties.
  /// </summary>
  public DocDefaults? DocDefaults { get; set; }

  /// <summary>
  ///   Latent Style Information.
  /// </summary>
  public LatentStyles? LatentStyles { get; set; }

  /// <summary>
  /// Defines Styles.
  /// </summary>
  public DefinedStyles DefinedStyles { get; set; } = new DefinedStyles();
}