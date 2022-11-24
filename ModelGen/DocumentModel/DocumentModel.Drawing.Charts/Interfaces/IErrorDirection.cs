namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Error Bar Direction.
/// </summary>
public interface IErrorDirection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Error Bar Direction Value
  /// </summary>
  public ErrorBarDirectionValues? Val { get ; set; }
  
}
