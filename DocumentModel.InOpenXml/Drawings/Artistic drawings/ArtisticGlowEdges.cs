namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic glow edges effect, which simulates glowing edges with adjustable transparency and smoothness.
/// </summary>
public partial class ArtisticGlowEdges : ModelElement<DXO10D.ArtisticGlowEdges>
{
    /// <summary>
    /// Transparency level of the glow edges effect.
    /// </summary>
    public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

    private Int32? _Transparency;
    /// <summary>
    /// Smoothness of the glow edges effect, influencing the softness of the glow.
    /// </summary>
    public Int32? Smoothness { get; set; }
}