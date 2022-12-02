namespace DocumentModel.Drawing;

/// <summary>
/// No text in 3D scene.
/// </summary>
public interface IFlatText // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Z Coordinate
  /// </summary>
  public Int64? Z { get ; set; }
  
}
