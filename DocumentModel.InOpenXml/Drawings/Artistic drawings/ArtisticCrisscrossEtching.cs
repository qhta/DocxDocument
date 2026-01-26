namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic crisscross etching effect, which simulates a textured etching with adjustable transparency and pressure.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticCrisscrossEtching))]
public partial class ArtisticCrisscrossEtching : ModelElement<DXO10D.ArtisticCrisscrossEtching>
{
 /// <summary>
 /// Transparency level of the crisscross etching effect.
 /// </summary>
 [OpenXmlElement(typeof(DXO10D.ArtisticCrisscrossEtching))]
 public Int32? Transparency { get => _Transparency; set => UpdateField(ref _Transparency, value, nameof(Transparency)); }

 private Int32? _Transparency;
 /// <summary>
 /// Pressure applied in the crisscross etching effect, influencing the intensity of the etched lines.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticCrisscrossEtching.Pressure))]
 [OpenXmlElement(typeof(DXO10D.ArtisticCrisscrossEtching))]
 public Int32? Pressure { get => _Pressure; set => UpdateField(ref _Pressure, value, nameof(Pressure)); }

 private Int32? _Pressure;
}