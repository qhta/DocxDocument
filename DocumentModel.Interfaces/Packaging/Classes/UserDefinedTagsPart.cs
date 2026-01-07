namespace DocumentModel.Packaging;

/// <summary>
///   Defines the UserDefinedTagsPart
/// </summary>
public interface UserDefinedTagsPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}