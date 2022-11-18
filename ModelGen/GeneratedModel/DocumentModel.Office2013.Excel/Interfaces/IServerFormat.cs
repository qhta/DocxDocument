namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the ServerFormat Class.
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
