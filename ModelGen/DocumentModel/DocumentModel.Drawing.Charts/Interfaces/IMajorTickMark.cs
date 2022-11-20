namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Major Tick Mark.
/// </summary>
public interface IMajorTickMark // : DocumentFormat.OpenXml.Drawing.Charts.TickMarkType
{
  /// <summary>
  /// Tick Mark Value
  /// </summary>
  public TickMarkValues? Val { get ; set; }
  
}
