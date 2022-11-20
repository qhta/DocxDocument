namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the LookAtPoint3D Class.
/// </summary>
public interface ILookAtPoint3D // : DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OpenXmlPoint3DElement
{
  /// <summary>
  /// X-Coordinate in 3D
  /// </summary>
  public long? X { get ; set; }
  
  /// <summary>
  /// Y-Coordinate in 3D
  /// </summary>
  public long? Y { get ; set; }
  
  /// <summary>
  /// Z-Coordinate in 3D
  /// </summary>
  public long? Z { get ; set; }
  
}
