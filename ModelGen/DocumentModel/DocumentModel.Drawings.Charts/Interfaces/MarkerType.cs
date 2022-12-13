namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public interface MarkerType
{
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  public String? XPosition { get ; set; }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  public String? YPosition { get ; set; }
  
}
