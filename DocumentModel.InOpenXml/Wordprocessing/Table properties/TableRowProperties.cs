namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the set of row-level properties applied to the current table row.
/// Each unique property is specified by a child element. These properties affect the appearance of all cells in the current row within the parent table, but can be overridden by individual cell-level properties as defined by each property.
/// </summary>
public partial class TableRowProperties : BaseTableRowProperties
{
  /// <summary>
  /// Indicates that the parent table row is treated as an inserted row whose insertion has been tracked as a revision. This only affects the table row itself, not its cells or contents.
  /// </summary>
  public TrackChangeType? Inserted { get; set; }
  /// <summary>
  /// Indicates that the parent table row is treated as a deleted row whose deletion has been tracked as a revision. This only affects the table row itself, not its cells or contents.
  /// </summary>
  public TrackChangeType? Deleted { get; set; }
  /// <summary>
  /// Details about a single revision to a set of table row properties in a WordprocessingML document.
  /// </summary>
  public TableRowPropertiesChange? TableRowPropertiesChange { get; set; }
  /// <summary>
  /// Indicates that the parent object has been inserted in conflict with edits made by other users.
  /// </summary>
  public TrackChangeType? ConflictInsertion { get; set; }
  /// <summary>
  /// Indicates that the parent object has been deleted in conflict with edits made by other users.
  /// </summary>
  public TrackChangeType? ConflictDeletion { get; set; }
}