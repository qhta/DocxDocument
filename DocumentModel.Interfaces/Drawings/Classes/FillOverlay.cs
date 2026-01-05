namespace DocumentModel.Drawings;

/// <summary>
///   Fill Overlay Effect.
/// </summary>
public interface FillOverlay:
{
  /// <summary>
  ///   Blend
  /// </summary>
  public BlendMode? Blend { get; set; }
  /// <summary>
  ///   NoFill.
  /// </summary>
  public Fill? Fill { get; set; }
}