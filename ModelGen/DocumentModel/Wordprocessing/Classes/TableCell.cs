namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single cell in a table row, which contains the table’s content. Table cells in WordprocessingML are analogous to HTML td elements.
/// </summary>
public partial class TableCell
{
  
  /// <summary>
  ///   Table Cell Properties.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Wordprocessing.TableCellProperties? TableCellProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
