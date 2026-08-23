namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents extended latent style exception information for a Wordprocessing document.
/// This class provides properties for the primary style name and alternate style names, enabling advanced management and customization of latent styles. Implements property change notification Interop.
/// </summary>
public partial class LatentStyle
{
  /// <summary>
  /// Primary style name associated with the latent style exception.
  /// </summary>
  public string? StyleName { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Alternate style names associated with the latent style exception.
  /// </summary>
  public List<String>? Aliases { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
