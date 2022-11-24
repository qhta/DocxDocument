namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Error Bar Type.
/// </summary>
public interface IErrorBarType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Error Bar Type Value
  /// </summary>
  public ErrorBarValues? Val { get ; set; }
  
}
