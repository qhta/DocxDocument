namespace DocumentModel.Spreadsheet;

/// <summary>
/// Server Format.
/// </summary>
public interface IServerFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Culture
  /// </summary>
  public string? Culture { get ; set; }
  
  /// <summary>
  /// Format
  /// </summary>
  public string? Format { get ; set; }
  
}
