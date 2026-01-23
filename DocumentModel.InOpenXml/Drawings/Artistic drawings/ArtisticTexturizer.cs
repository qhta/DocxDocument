namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic texturizer effect, which simulates a textured appearance with adjustable transparency and scaling.
/// </summary>
public partial class ArtisticTexturizer : ModelElement<DXO10D.ArtisticTexturizer>
{
    /// <summary>
    /// Transparency level of the texturizer effect.
    /// </summary>
    public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

    private Int32? _Transparency;
    /// <summary>
    /// Scaling factor for the texturizer effect, influencing the size and intensity of the texture.
    /// </summary>
    public Int32? Scaling { get => _Scaling; set => UpdateField(ref _Scaling, value, nameof(Scaling)); }

    private Int32? _Scaling;
}