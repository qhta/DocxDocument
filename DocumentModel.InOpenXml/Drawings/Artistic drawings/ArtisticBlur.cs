namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic blur effect, which applies a blur to an image or shape with a specified radius.
/// </summary>
[OpenXmlType(typeof(DXO10D.ArtisticBlur))]
public partial class ArtisticBlur : ModelElement<DXO10D.ArtisticBlur>
{
 /// <summary>
 /// Radius of the artistic blur effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ArtisticBlur.Radius))]
 [OpenXmlElement(typeof(DXO10D.ArtisticBlur))]
 public Int32? Radius { get => _Radius; set => UpdateField(ref _Radius, value, nameof(Radius)); }

 private Int32? _Radius;
}