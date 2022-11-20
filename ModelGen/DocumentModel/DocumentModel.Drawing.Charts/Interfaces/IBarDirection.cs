namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Bar Direction.
/// </summary>
public interface IBarDirection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Bar Direction Value
  /// </summary>
  public BarDirectionValues? Val { get ; set; }
  
}
