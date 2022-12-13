namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTablePart
/// </summary>
public interface PivotTablePart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
