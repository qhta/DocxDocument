namespace DocumentModel.Drawings;

/// <summary>
///   Represents a tint effect, allowing adjustment of hue and amount for color modification.
/// </summary>
public interface TintEffect
{
  /// <summary>
  ///   Hue adjustment value for the tint effect.
  /// </summary>
  public Int32? Hue { get; set; }

  /// <summary>
  ///   Amount of tint to apply.
  /// </summary>
  public Int32? Amount { get; set; }
}