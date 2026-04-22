namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents spherical coordinates for positioning or orienting elements in a 3D space within a Wordprocessing document.
/// This class provides properties for latitude, longitude, and revolution, enabling precise control over 3D placement and rotation.
/// </summary>
[OpenXmlType(typeof(DXO10W.SphereCoordinates))]
[XmlRoot("SphereCoordinates", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class SphereCoordinates : ModelElement<DXO10W.SphereCoordinates>
{
 /// <summary>
 /// The latitude value, specifying the north-south position in the spherical coordinate system.
 /// </summary>
 public Int32? Latitude { get => _Latitude; set => UpdateField(ref _Latitude, value, nameof(Latitude)); }
 private Int32? _Latitude;

 /// <summary>
 /// The longitude value, specifying the east-west position in the spherical coordinate system.
 /// </summary>
 public Int32? Longitude { get => _Longitude; set => UpdateField(ref _Longitude, value, nameof(Longitude)); }
 private Int32? _Longitude;

 /// <summary>
 /// The revolution value, specifying the rotation around the sphere's axis.
 /// </summary>
 public Int32? Revolution { get => _Revolution; set => UpdateField(ref _Revolution, value, nameof(Revolution)); }
 private Int32? _Revolution;
}