namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AdjustPoint2DType Class.
/// </summary>
public interface IAdjustPoint2DType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// X-Coordinate
  /// </summary>
  public String? X { get ; set; }
  
  /// <summary>
  /// Y-Coordinate
  /// </summary>
  public String? Y { get ; set; }
  
}
