namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the NumberingFormat Class.
/// </summary>
public interface INumberingFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Number Format Code
  /// </summary>
  public string? FormatCode { get ; set; }
  
  /// <summary>
  /// Linked to Source
  /// </summary>
  public bool? SourceLinked { get ; set; }
  
}
