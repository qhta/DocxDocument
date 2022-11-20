namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Watch Item.
/// </summary>
public interface ICellWatch // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? CellReference { get ; set; }
  
}
