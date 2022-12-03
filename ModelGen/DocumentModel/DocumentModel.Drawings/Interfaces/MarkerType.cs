namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public interface MarkerType // : DocumentModel.BaseTypes.ModelElement
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
