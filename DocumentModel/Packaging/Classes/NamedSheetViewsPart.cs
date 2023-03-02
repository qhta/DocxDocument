namespace DocumentModel.Packaging;

/// <summary>
///   Defines the NamedSheetViewsPart
/// </summary>
public record NamedSheetViewsPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}