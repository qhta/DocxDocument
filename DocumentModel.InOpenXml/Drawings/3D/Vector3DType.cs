namespace DocumentModel.Drawings;
/// <summary>
///   Represents a 3D vector with distances along the X, Y, and Z axes.
/// </summary>
[OpenXmlType(typeof(DXD.Vector3DType))]
public partial class Vector3DType : ModelElement<DXD.Vector3DType>
{
 /// <summary>
 ///   Distance along the X-axis in 3D space.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Vector3DType.Dx))]
 public Int64? Dx { get => _Dx; set => UpdateField(ref _Dx, value, nameof(Dx)); }
 private Int64? _Dx;
 /// <summary>
 ///   Distance along the Y-axis in 3D space.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Vector3DType.Dy))]
 public Int64? Dy { get => _Dy; set => UpdateField(ref _Dy, value, nameof(Dy)); }
 private Int64? _Dy;
 /// <summary>
 ///   Distance along the Z-axis in 3D space.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Vector3DType.Dz))]
 public Int64? Dz { get => _Dz; set => UpdateField(ref _Dz, value, nameof(Dz)); }
 private Int64? _Dz;
}