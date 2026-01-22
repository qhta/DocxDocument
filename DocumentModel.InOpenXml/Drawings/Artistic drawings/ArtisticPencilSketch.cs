namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic pencil sketch effect, which simulates a pencil sketch style with adjustable transparency and pressure.
/// </summary>
public partial class ArtisticPencilSketch : ModelElement<DXO10D.ArtisticPencilSketch>
{
    /// <summary>
    /// Transparency level of the pencil sketch effect.
    /// </summary>
    public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

    private Int32? _Transparency;
    /// <summary>
    /// Pressure applied in the pencil sketch effect, influencing the intensity and darkness of the strokes.
    /// </summary>
    public Int32? Pressure { get; set; }
}