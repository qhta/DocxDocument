namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Error Bar Value Type.
/// </summary>
public interface IErrorBarValueType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Error Bar Type Value
  /// </summary>
  public Error? Val { get ; set; }
  
}
