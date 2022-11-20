namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Major Tick Mark.
/// </summary>
public class MajorTickMark: IMajorTickMark
{
  /// <summary>
  /// Tick Mark Value
  /// </summary>
  public TickMarkValues? Val
  {
    get;
    set;
  }
  
}
