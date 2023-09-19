namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the table grid for the current table. The table grid is a definition of the set of grid columns which define all of the shared vertical edges of the table, as well as default widths for each of these grid columns. These grid column widths are then used to determine the size of the table based on the table layout algorithm used.
/// </summary>
public partial class TableGrid
{
  public DocumentModel.Wordprocessing.TableGridChange? TableGridChange { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.GridColumn>? Items { get; set; }
  
}
