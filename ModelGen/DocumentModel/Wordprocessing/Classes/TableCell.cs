namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single cell in a table row, which contains the table’s content. Table cells in WordprocessingML are analogous to HTML td elements.
/// </summary>
public partial class TableCell
{
  
  /// <summary>
  ///   Table Cell Properties.
  /// </summary>
  public TableCellProperties? TableCellProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
