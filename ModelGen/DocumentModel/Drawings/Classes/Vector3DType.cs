namespace DocumentModel.Drawings;


/// <summary>
///   Defines the Vector3DType Class.
/// </summary>
public partial class Vector3DType
{
  
  /// <summary>
  ///   Distance along X-axis in 3D
  /// </summary>
  [SchemaAttr("dx")]
  public Int64? Dx { get; set; }
  
  
  /// <summary>
  ///   Distance along Y-axis in 3D
  /// </summary>
  [SchemaAttr("dy")]
  public Int64? Dy { get; set; }
  
  
  /// <summary>
  ///   Distance along Z-axis in 3D
  /// </summary>
  [SchemaAttr("dz")]
  public Int64? Dz { get; set; }
  
}
