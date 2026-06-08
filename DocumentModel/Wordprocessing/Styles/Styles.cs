namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines IStyles.
/// </summary>
public partial class IStyles
{
  /// <summary>
  ///   IDocument Default IParagraph and Run Properties.
  /// </summary>
  public DocDefaults? DocDefaults { get; set; }

  /// <summary>
  ///   Latent IStyle Information.
  /// </summary>
  public LatentStyles? LatentStyles { get; set; }


}
