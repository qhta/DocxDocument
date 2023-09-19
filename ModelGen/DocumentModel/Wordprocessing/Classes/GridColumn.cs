namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence and details about a single grid column within a table grid. A grid column is a logical column in a table used to specify the presence of a shared vertical edge in the table. When table cells are then added to this table, these shared edges (or grid columns, looking at the column between those shared edges) determine how table cells are placed into the table grid.
/// </summary>
public partial class GridColumn
{
  
  /// <summary>
  ///   Grid Column Width
  /// </summary>
  [SchemaAttr("w:w")]
  public String? Width { get; set; }
  
}
