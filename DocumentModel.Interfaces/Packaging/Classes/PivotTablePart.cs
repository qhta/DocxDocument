namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PivotTablePart
/// </summary>
public interface PivotTablePart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}