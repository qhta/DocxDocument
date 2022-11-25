namespace DocumentModel.Spreadsheet;

/// <summary>
/// Protection.
/// </summary>
public interface IProtection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Cell Locked
  /// </summary>
  public System.Boolean? Locked { get ; set; }
  
  /// <summary>
  /// Hidden Cell
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
}
