namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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


}