namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of row-level properties applied to the current table row. Each unique property is specified by a child element of this element. These properties affect the appearance of all cells in the current row within the parent table but can be overridden by individual cell-level properties, as defined by each property.
/// </summary>
public partial class TableRowProperties
{
  public DocumentModel.Wordprocessing.TrackChangeType? Inserted { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? Deleted { get; set; }
  
  public DocumentModel.Wordprocessing.TableRowPropertiesChange? TableRowPropertiesChange { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? ConflictInsertion { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? ConflictDeletion { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
