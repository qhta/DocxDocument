namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SingleCellTablePart
/// </summary>
public interface SingleCellTablePart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}