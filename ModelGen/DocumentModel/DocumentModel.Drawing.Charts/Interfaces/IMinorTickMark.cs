namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Minor Tick Mark.
/// </summary>
public interface IMinorTickMark // : DocumentFormat.OpenXml.Drawing.Charts.TickMarkType
{
  /// <summary>
  /// Tick Mark Value
  /// </summary>
  public TickMarkValues? Val { get ; set; }
  
}
