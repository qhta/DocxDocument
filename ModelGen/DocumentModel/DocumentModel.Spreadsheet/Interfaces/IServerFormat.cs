namespace DocumentModel.Spreadsheet;

/// <summary>
/// Server Format.
/// </summary>
public interface IServerFormat // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Culture
  /// </summary>
  public System.String? Culture { get ; set; }
  
  /// <summary>
  /// Format
  /// </summary>
  public System.String? Format { get ; set; }
  
}
