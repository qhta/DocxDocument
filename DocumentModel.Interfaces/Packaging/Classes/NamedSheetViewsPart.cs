namespace DocumentModel.Packaging;

/// <summary>
///   Defines the NamedSheetViewsPart
/// </summary>
public interface NamedSheetViewsPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}