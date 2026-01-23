namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic line drawing effect, which simulates a hand-drawn line style with adjustable transparency and pencil size.
/// </summary>
public partial class ArtisticLineDrawing : ModelElement<DXO10D.ArtisticLineDrawing>
{
    /// <summary>
    /// Transparency level of the line drawing effect.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.ArtisticLineDrawing))]
    public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

    private Int32? _Transparency;
    /// <summary>
    /// Size of the pencil used in the line drawing effect, influencing the thickness of the lines.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ArtisticLineDrawing.PencilSize))]
    /// <summary>
    /// Size of the pencil used in the line drawing effect, influencing the thickness of the lines.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.ArtisticLineDrawing))]
    public Int32? PencilSize { get => _PencilSize; set => UpdateField(ref _PencilSize, value, nameof(PencilSize)); }

    private Int32? _PencilSize;
}