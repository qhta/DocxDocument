namespace DocumentModel.Drawings;
/// <summary>
///   Represents rotation parameters, including latitude, longitude, and revolution values.
/// </summary>
[OpenXmlType(typeof(DXD.Rotation))]
[DataContract]
[XmlRoot("Rotation", Namespace = "DocumentModel.Drawings")]
public partial class Rotation : ModelElement<DXD.Rotation>
{
 /// <summary>
 ///   Latitude value for the rotation.
 /// </summary>
 public Int32? Latitude { get => _Latitude; set => UpdateField(ref _Latitude, value, nameof(Latitude)); }
 private Int32? _Latitude;

 /// <summary>
 ///   Longitude value for the rotation.
 /// </summary>
 public Int32? Longitude { get => _Longitude; set => UpdateField(ref _Longitude, value, nameof(Longitude)); }
 private Int32? _Longitude;

 /// <summary>
 ///   Revolution value for the rotation.
 /// </summary>
 public Int32? Revolution { get => _Revolution; set => UpdateField(ref _Revolution, value, nameof(Revolution)); }
 private Int32? _Revolution;
}