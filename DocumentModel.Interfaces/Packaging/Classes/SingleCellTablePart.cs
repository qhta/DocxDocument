namespace DocumentModel.Packaging;

/// <summary>
///   Defines the SingleCellTablePart
/// </summary>
public interface SingleCellTablePart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}