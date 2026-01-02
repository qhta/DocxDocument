namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PivotTablePart
/// </summary>
public class PivotTablePart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}