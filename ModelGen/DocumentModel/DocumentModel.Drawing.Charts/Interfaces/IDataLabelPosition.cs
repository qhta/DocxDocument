namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Data Label Position.
/// </summary>
public interface IDataLabelPosition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Data Label Position Value
  /// </summary>
  public DataLabelPositionValues? Val { get ; set; }
  
}
