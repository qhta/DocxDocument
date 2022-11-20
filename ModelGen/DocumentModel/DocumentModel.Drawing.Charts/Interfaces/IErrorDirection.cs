namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Error Bar Direction.
/// </summary>
public interface IErrorDirection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Error Bar Direction Value
  /// </summary>
  public ErrorBarDirectionValues? Val { get ; set; }
  
}
