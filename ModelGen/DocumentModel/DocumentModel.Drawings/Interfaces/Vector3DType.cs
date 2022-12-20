namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Vector3DType Class.
/// </summary>
public partial interface Vector3DType
{
  /// <summary>
  /// Distance along X-axis in 3D
  /// </summary>
  public Int64? Dx { get; set; }
  
  /// <summary>
  /// Distance along Y-axis in 3D
  /// </summary>
  public Int64? Dy { get; set; }
  
  /// <summary>
  /// Distance along Z-axis in 3D
  /// </summary>
  public Int64? Dz { get; set; }
  
}
