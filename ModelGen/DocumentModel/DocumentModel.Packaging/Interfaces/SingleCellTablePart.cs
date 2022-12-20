namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SingleCellTablePart
/// </summary>
public partial interface SingleCellTablePart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
