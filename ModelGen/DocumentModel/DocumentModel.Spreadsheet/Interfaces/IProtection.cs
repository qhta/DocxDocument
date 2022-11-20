namespace DocumentModel.Spreadsheet;

/// <summary>
/// Protection.
/// </summary>
public interface IProtection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Cell Locked
  /// </summary>
  public bool? Locked { get ; set; }
  
  /// <summary>
  /// Hidden Cell
  /// </summary>
  public bool? Hidden { get ; set; }
  
}
