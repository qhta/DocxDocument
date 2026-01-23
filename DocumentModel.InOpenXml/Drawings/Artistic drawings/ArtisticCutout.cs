namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic cutout effect, which simulates a cutout style with adjustable transparency and number of shades.
/// </summary>
public partial class ArtisticCutout : ModelElement<DXO10D.ArtisticCutout>
{
    /// <summary>
    /// Transparency level of the cutout effect.
    /// </summary>
    public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

    private Int32? _Transparency;
    /// <summary>
    /// Number of shades used in the cutout effect, influencing the visual depth and contrast.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ArtisticCutout.NumberOfShades))]
    public Int32? NumberOfShades { get => _NumberOfShades; set => UpdateField(ref _NumberOfShades, value, nameof(NumberOfShades)); }

    private Int32? _NumberOfShades;
}