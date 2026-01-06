namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic cement effect, which simulates a cement texture with adjustable transparency and crack spacing.
/// </summary>
public interface ArtisticCement
{
  /// <summary>
  /// Transparency level of the cement effect.
  /// </summary>
  public Int32? Transparency { get; set; }

  /// <summary>
  /// Spacing between cracks in the cement effect.
  /// </summary>
  public Int32? CrackSpacing { get; set; }
}