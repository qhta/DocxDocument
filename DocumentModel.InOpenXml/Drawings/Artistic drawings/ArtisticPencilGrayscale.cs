namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic pencil grayscale effect, which simulates a pencil sketch in grayscale with adjustable transparency and brush size.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticPencilGrayscale))]
public partial class ArtisticPencilGrayscale : ModelElement<DXO10D.ArtisticPencilGrayscale>
{
 /// <summary>
 /// Transparency level of the pencil grayscale effect.
 /// </summary>
 public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }
 private Int32? _Transparency;
 /// <summary>
 /// Size of the brush used in the pencil grayscale effect, influencing the thickness and coverage of the strokes.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticPencilGrayscale.BrushSize))]
 public Int32? BrushSize { get => _BrushSize; set => UpdateField(ref _BrushSize, value, nameof(BrushSize)); }
 private Int32? _BrushSize;
}