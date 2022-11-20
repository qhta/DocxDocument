namespace DocumentModel.Drawing;

/// <summary>
/// Normal.
/// </summary>
public interface INormal // : DocumentFormat.OpenXml.Drawing.Vector3DType
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
