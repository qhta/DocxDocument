namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic mosaic bubbles effect, which simulates a mosaic pattern with bubble-like textures and adjustable transparency and pressure.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticMosaicBubbles))]
public partial class ArtisticMosaicBubbles : ModelElement<DXO10D.ArtisticMosaicBubbles>
{
 /// <summary>
 /// Transparency level of the mosaic bubbles effect.
 /// </summary>
 [OpenXmlElement(typeof(DXO10D.ArtisticMosaicBubbles))]
 public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

 private Int32? _Transparency;
 /// <summary>
 /// Pressure applied in the mosaic bubbles effect, influencing the intensity and appearance of the bubbles.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticMosaicBubbles.Pressure))]
 /// <summary>
 /// Pressure applied in the mosaic bubbles effect, influencing the intensity and appearance of the bubbles.
 /// </summary>
 [OpenXmlElement(typeof(DXO10D.ArtisticMosaicBubbles))]
 public Int32? Pressure { get => _Pressure; set => UpdateField(ref _Pressure, value, nameof(Pressure)); }

 private Int32? _Pressure;
}