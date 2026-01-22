namespace DocumentModel.Drawings;
/// <summary>
///   Fill Overlay Effect.
/// </summary>
public partial class FillOverlay : ModelElement<DXD.FillOverlay>
{
    /// <summary>
    ///   Blend
    /// </summary>
    public BlendMode? Blend { get => _Blend; set => UpdateField(ref _Blend, value, nameof(Blend)); }

    private BlendMode? _Blend;
    /// <summary>
    ///   NoFill.
    /// </summary>
    public Fill? Fill { get; set; }
}