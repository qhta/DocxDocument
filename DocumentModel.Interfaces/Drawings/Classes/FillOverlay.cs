namespace DocumentModel.Drawings;

/// <summary>
///   Fill Overlay Effect.
/// </summary>
public class FillOverlay: ModelElement
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