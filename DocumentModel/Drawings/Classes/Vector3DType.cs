namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Vector3DType Class.
/// </summary>
public class Vector3DType: ModelElement
{
  /// <summary>
  ///   Distance along X-axis in 3D
  /// </summary>
  public Int64? Dx { get; set; }

  /// <summary>
  ///   Distance along Y-axis in 3D
  /// </summary>
  public Int64? Dy { get; set; }

  /// <summary>
  ///   Distance along Z-axis in 3D
  /// </summary>
  public Int64? Dz { get; set; }
}