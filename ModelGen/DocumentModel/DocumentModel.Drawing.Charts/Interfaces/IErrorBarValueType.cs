namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Error Bar Value Type.
/// </summary>
public interface IErrorBarValueType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Error Bar Type Value
  /// </summary>
  public ErrorValues? Val { get ; set; }
  
}
