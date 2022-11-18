namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the PreTransVector3D Class.
/// </summary>
public interface IPreTransVector3D // : DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Vector3DType
{
  /// <summary>
  /// Distance along X-axis in 3D
  /// </summary>
  public long? Dx { get ; set; }
  
  /// <summary>
  /// Distance along Y-axis in 3D
  /// </summary>
  public long? Dy { get ; set; }
  
  /// <summary>
  /// Distance along Z-axis in 3D
  /// </summary>
  public long? Dz { get ; set; }
  
}
