namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of row-level properties applied to the current table row. Each unique property is specified by a child element of this element. These properties affect the appearance of all cells in the current row within the parent table but can be overridden by individual cell-level properties, as defined by each property.
/// </summary>
public partial class TableRowProperties
{
  public DMW.Inserted? Inserted { get; set; }
  
  public DMW.Deleted? Deleted { get; set; }
  
  public DMW.TableRowPropertiesChange? TableRowPropertiesChange { get; set; }
  
  public DMW10.ConflictInsertion? ConflictInsertion { get; set; }
  
  public DMW10.ConflictDeletion? ConflictDeletion { get; set; }
  
}
