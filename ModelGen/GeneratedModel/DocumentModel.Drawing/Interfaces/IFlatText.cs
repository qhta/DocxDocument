namespace DocumentModel.Drawing;

/// <summary>
/// No text in 3D scene.
/// </summary>
public interface IFlatText // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Z Coordinate
  /// </summary>
  public long? Z { get ; set; }
  
}
