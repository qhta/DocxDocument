namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic watercolor sponge effect, which simulates a watercolor texture with adjustable transparency and brush size.
/// </summary>
public partial class ArtisticWatercolorSponge : ModelElement<DXO10D.ArtisticWatercolorSponge>
{
    /// <summary>
    /// Transparency level of the watercolor sponge effect.
    /// </summary>
    public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

    private Int32? _Transparency;
    /// <summary>
    /// Size of the brush used in the watercolor sponge effect, influencing the coverage and texture.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ArtisticWatercolorSponge.BrushSize))]
    public Int32? BrushSize { get => _BrushSize; set => UpdateField(ref _BrushSize, value, nameof(BrushSize)); }

    private Int32? _BrushSize;
}