namespace DocumentModel.Spreadsheet;

/// <summary>
/// Server Format.
/// </summary>
public interface IServerFormat // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Culture
  /// </summary>
  public String? Culture { get ; set; }
  
  /// <summary>
  /// Format
  /// </summary>
  public String? Format { get ; set; }
  
}
