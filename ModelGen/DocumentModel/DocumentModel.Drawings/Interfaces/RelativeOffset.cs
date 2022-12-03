namespace DocumentModel.Drawings;

/// <summary>
/// Relative Offset Effect.
/// </summary>
public interface RelativeOffset // : System.Boolean
{
  /// <summary>
  /// Offset X
  /// </summary>
  public Int32? OffsetX { get ; set; }
  
  /// <summary>
  /// Offset Y
  /// </summary>
  public Int32? OffsetY { get ; set; }
  
}
