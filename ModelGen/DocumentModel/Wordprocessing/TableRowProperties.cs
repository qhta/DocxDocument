namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of row-level properties applied to the current table row. Each unique property is specified by a child element of this element. These properties affect the appearance of all cells in the current row within the parent table but can be overridden by individual cell-level properties, as defined by each property.
/// </summary>
public partial class TableRowProperties
{
  public DocumentModel.Wordprocessing.Inserted? Inserted { get; set; }
  
  public DocumentModel.Wordprocessing.Deleted? Deleted { get; set; }
  
  public DocumentModel.Wordprocessing.TableRowPropertiesChange? TableRowPropertiesChange { get; set; }
  
  public DocumentModel.Wordprocessing.ConflictInsertion? ConflictInsertion { get; set; }
  
  public DocumentModel.Wordprocessing.ConflictDeletion? ConflictDeletion { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
