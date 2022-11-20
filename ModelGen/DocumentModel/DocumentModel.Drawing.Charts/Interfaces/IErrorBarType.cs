namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Error Bar Type.
/// </summary>
public interface IErrorBarType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Error Bar Type Value
  /// </summary>
  public ErrorBarValues? Val { get ; set; }
  
}
