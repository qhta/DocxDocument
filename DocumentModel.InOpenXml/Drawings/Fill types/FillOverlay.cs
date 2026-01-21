namespace DocumentModel.Drawings;
/// <summary>
///   Fill Overlay Effect.
/// </summary>
public partial class FillOverlay : ModelElement<DXD.FillOverlay>
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