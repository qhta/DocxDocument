namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic pencil sketch effect, which simulates a pencil sketch style with adjustable transparency and pressure.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticPencilSketch))]
[XmlRoot("ArtisticPencilSketch", Namespace = "DocumentModel.Drawings")]
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
 [OpenXmlProperty(nameof(DXO10D.ArtisticPencilSketch.Pressure))]
 public Int32? Pressure { get => _Pressure; set => UpdateField(ref _Pressure, value, nameof(Pressure)); }

 private Int32? _Pressure;
}