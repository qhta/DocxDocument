namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic glass effect, which simulates a glass-like appearance with adjustable transparency and scaling.
/// </summary>
public partial class ArtisticGlass : ModelElement<DXO10D.ArtisticGlass>
{
    /// <summary>
    /// Transparency level of the glass effect.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.ArtisticGlass))]
    public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

    private Int32? _Transparency;
    /// <summary>
    /// Scaling factor for the glass effect, influencing the distortion and texture.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ArtisticGlass.Scaling))]
    /// <summary>
    /// Scaling factor for the glass effect, influencing the distortion and texture.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.ArtisticGlass))]
    public Int32? Scaling { get => _Scaling; set => UpdateField(ref _Scaling, value, nameof(Scaling)); }

    private Int32? _Scaling;
}