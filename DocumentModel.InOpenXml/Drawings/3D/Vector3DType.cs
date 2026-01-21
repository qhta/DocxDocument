namespace DocumentModel.Drawings;
/// <summary>
///   Represents a 3D vector with distances along the X, Y, and Z axes.
/// </summary>
public partial class Vector3DType : ModelElement<DXD.Vector3DType>
{
  /// <summary>
  ///   Distance along the X-axis in 3D space.
  /// </summary>
  public Int64? Dx { get; set; }
  /// <summary>
  ///   Distance along the Y-axis in 3D space.
  /// </summary>
  public Int64? Dy { get; set; }
  /// <summary>
  ///   Distance along the Z-axis in 3D space.
  /// </summary>
  public Int64? Dz { get; set; }
}