namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the PostTransVector3D Class.
/// </summary>
public class PostTransVector3D: IPostTransVector3D
{
  /// <summary>
  /// Distance along X-axis in 3D
  /// </summary>
  public long? Dx
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance along Y-axis in 3D
  /// </summary>
  public long? Dy
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance along Z-axis in 3D
  /// </summary>
  public long? Dz
  {
    get;
    set;
  }
  
}
