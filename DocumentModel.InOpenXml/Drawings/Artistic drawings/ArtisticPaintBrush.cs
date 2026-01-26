namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic paint brush effect, which simulates a paint brush style with adjustable transparency and brush size.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticPaintBrush))]
public partial class ArtisticPaintBrush : ModelElement<DXO10D.ArtisticPaintBrush>
{
 /// <summary>
 /// Transparency level of the paint brush effect.
 /// </summary>
 [OpenXmlElement(typeof(DXO10D.ArtisticPaintBrush))]
 public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

 private Int32? _Transparency;
 /// <summary>
 /// Size of the brush used in the paint brush effect, influencing the thickness and coverage of the strokes.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticPaintBrush.BrushSize))]
 [OpenXmlElement(typeof(DXO10D.ArtisticPaintBrush))]
 public Int32? BrushSize { get => _BrushSize; set => UpdateField(ref _BrushSize, value, nameof(BrushSize)); }

 private Int32? _BrushSize;
}