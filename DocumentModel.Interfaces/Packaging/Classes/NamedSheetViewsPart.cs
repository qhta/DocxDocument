namespace DocumentModel.Packaging;

/// <summary>
///   Defines the NamedSheetViewsPart
/// </summary>
public interface NamedSheetViewsPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}