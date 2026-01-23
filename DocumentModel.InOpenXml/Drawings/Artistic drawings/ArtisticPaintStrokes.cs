namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic paint strokes effect, which simulates painted strokes with adjustable transparency and intensity.
/// </summary>
public partial class ArtisticPaintStrokes : ModelElement<DXO10D.ArtisticPaintStrokes>
{
    /// <summary>
    /// Transparency level of the paint strokes effect.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.ArtisticPaintStrokes))]
    public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

    private Int32? _Transparency;
    /// <summary>
    /// Intensity of the paint strokes effect, influencing the strength and visibility of the strokes.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ArtisticPaintStrokes.Intensity))]
    /// <summary>
    /// Intensity of the paint strokes effect, influencing the strength and visibility of the strokes.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.ArtisticPaintStrokes))]
    public Int32? Intensity { get => _Intensity; set => UpdateField(ref _Intensity, value, nameof(Intensity)); }

    private Int32? _Intensity;
}