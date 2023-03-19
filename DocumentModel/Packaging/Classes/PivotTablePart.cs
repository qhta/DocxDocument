namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PivotTablePart
/// </summary>
public class PivotTablePart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}