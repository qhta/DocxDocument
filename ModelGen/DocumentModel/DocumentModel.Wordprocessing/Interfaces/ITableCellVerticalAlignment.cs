namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellVerticalAlignment Class.
/// </summary>
public interface ITableCellVerticalAlignment // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val
  /// </summary>
  public TableVerticalAlignmentValues? Val { get ; set; }
  
}
