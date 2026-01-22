namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic mosaic bubbles effect, which simulates a mosaic pattern with bubble-like textures and adjustable transparency and pressure.
/// </summary>
public partial class ArtisticMosaicBubbles : ModelElement<DXO10D.ArtisticMosaicBubbles>
{
    /// <summary>
    /// Transparency level of the mosaic bubbles effect.
    /// </summary>
    public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

    private Int32? _Transparency;
    /// <summary>
    /// Pressure applied in the mosaic bubbles effect, influencing the intensity and appearance of the bubbles.
    /// </summary>
    public Int32? Pressure { get; set; }
}