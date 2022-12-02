namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Position.
/// </summary>
public interface IPosition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  public Int64? X { get ; set; }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  public Int64? Y { get ; set; }
  
}
