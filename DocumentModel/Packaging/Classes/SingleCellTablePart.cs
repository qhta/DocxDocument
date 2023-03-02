namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SingleCellTablePart
/// </summary>
public record SingleCellTablePart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}