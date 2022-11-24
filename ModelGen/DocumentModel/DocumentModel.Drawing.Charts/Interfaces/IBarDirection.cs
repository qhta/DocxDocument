namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Bar Direction.
/// </summary>
public interface IBarDirection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Bar Direction Value
  /// </summary>
  public BarDirectionValues? Val { get ; set; }
  
}
