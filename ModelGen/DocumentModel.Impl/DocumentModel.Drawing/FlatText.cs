namespace DocumentModel.Drawing;

/// <summary>
/// No text in 3D scene.
/// </summary>
public class FlatText: IFlatText
{
  /// <summary>
  /// Z Coordinate
  /// </summary>
  public long? Z
  {
    get;
    set;
  }
  
}
