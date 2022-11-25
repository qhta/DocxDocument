namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Watch Item.
/// </summary>
public interface ICellWatch // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public System.String? CellReference { get ; set; }
  
}
