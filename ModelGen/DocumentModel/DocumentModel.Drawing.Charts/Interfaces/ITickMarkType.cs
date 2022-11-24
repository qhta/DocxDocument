namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the TickMarkType Class.
/// </summary>
public interface ITickMarkType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Tick Mark Value
  /// </summary>
  public TickMarkValues? Val { get ; set; }
  
}
