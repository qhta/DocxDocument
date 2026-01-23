namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the table grid configuration for a table in a Wordprocessing document.
/// This class provides access to grid definitions and change tracking, enabling management of column structure and historical grid revisions.
/// </summary>
public partial class TableGrid : BaseTableGrid<DXW.TableGrid>
{
  /// <summary>
  /// Change interface for the previous table grid, enabling tracking and management of grid revisions.
  /// </summary>
  public TableGridChange? TableGridChange { get; set; }
}