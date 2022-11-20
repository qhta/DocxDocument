namespace DocumentModel.Spreadsheet;

/// <summary>
/// Number Formats.
/// </summary>
public interface INumberingFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Number Format Id
  /// </summary>
  public uint? NumberFormatId { get ; set; }
  
  /// <summary>
  /// Number Format Code
  /// </summary>
  public string? FormatCode { get ; set; }
  
}
