namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic chalk sketch effect, which simulates a chalk drawing with adjustable transparency and pressure.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticChalkSketch))]
[DataContract]
[XmlRoot("ArtisticChalkSketch", Namespace = "DocumentModel.Drawings")]
public partial class ArtisticChalkSketch : ModelElement<DXO10D.ArtisticChalkSketch>
{
 /// <summary>
 /// Transparency level of the chalk sketch effect.
 /// </summary>
 public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }
 private Int32? _Transparency;

 /// <summary>
 /// Pressure applied in the chalk sketch effect, influencing the intensity of the strokes.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticChalkSketch.Pressure))]
 public Int32? Pressure { get => _Pressure; set => UpdateField(ref _Pressure, value, nameof(Pressure)); }
 private Int32? _Pressure;
}