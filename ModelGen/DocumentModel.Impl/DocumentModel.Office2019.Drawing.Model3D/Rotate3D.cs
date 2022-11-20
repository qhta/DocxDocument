namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the Rotate3D Class.
/// </summary>
public class Rotate3D: IRotate3D
{
  /// <summary>
  /// ax, this property is only available in Office 2019 and later.
  /// </summary>
  public int? Ax
  {
    get;
    set;
  }
  
  /// <summary>
  /// ay, this property is only available in Office 2019 and later.
  /// </summary>
  public int? Ay
  {
    get;
    set;
  }
  
  /// <summary>
  /// az, this property is only available in Office 2019 and later.
  /// </summary>
  public int? Az
  {
    get;
    set;
  }
  
}
