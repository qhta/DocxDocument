namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell.
/// </summary>
public class TableCellImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TableCell>, TableCell
{
  /// <summary>
  /// Table Cell Properties.
  /// </summary>
  public TableCellProperties? TableCellProperties
  {
    get;
    set;
  }
  
}
