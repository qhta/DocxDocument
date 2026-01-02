namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the set of row-level properties applied to the current table row. 
///   Each unique property is specified by a child element of this element. 
///   These properties affect the appearance of all cells in the current row within the parent table, 
///   but can be overridden by individual cell-level properties, as defined by each property.
/// </summary>
public class TableRowProperties: BaseTableRowProperties
{
  /// <summary>
  /// Specifies that the parent table row shall be treated as an inserted row whose insertion has been tracked as a revision. 
  /// This setting shall not imply any revision state about the table cells in this row or their contents 
  /// (which shall be revision marked independently), and shall only affect the table row itself. 
  /// </summary>
  public TrackChangeType? Inserted { get; set; }
  /// <summary>
  /// Specifies that the parent table row shall be treated as a deleted row whose deletion has been tracked as a revision. 
  /// This setting shall not imply any revision state about the table cells in this row or their contents 
  /// (which shall be revision marked independently), and shall only affect the table row itself. 
  /// </summary>
  public TrackChangeType? Deleted { get; set; }
  /// <summary>
  /// Specifies the details about a single revision to a set of table row properties in a WordprocessingML document.
  /// </summary>
  public TableRowPropertiesChange? TableRowPropertiesChange { get; set; }
  /// <summary>
  /// Specifies that the parent object has been inserted in conflict with edits made by other users.
  /// </summary>
  public TrackChangeType2? ConflictInsertion { get; set; }
  /// <summary>
  /// /Specifies that the parent object has been deleted in conflict with edits made by other users.
  /// </summary>
  public TrackChangeType2? ConflictDeletion { get; set; }
}