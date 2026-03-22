namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic pastels smooth effect, which simulates a smooth pastel drawing style with adjustable transparency and brush size.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticPastelsSmooth))]
public partial class ArtisticPastelsSmooth : ModelElement<DXO10D.ArtisticPastelsSmooth>
{
 /// <summary>
 /// Transparency level of the pastels smooth effect.
 /// </summary>
 public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }
 private Int32? _Transparency;
 /// <summary>
 /// Size of the brush used in the pastels smooth effect, influencing the smoothness and coverage of the strokes.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticPastelsSmooth.BrushSize))]
 public Int32? BrushSize { get => _BrushSize; set => UpdateField(ref _BrushSize, value, nameof(BrushSize)); }
 private Int32? _BrushSize;
}