namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Position.
/// </summary>
public interface Position // : System.Boolean
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
