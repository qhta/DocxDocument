namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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