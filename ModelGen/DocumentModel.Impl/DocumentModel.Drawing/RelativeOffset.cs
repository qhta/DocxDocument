namespace DocumentModel.Drawing;

/// <summary>
/// Relative Offset Effect.
/// </summary>
public class RelativeOffset: IRelativeOffset
{
  /// <summary>
  /// Offset X
  /// </summary>
  public int? OffsetX
  {
    get;
    set;
  }
  
  /// <summary>
  /// Offset Y
  /// </summary>
  public int? OffsetY
  {
    get;
    set;
  }
  
}
