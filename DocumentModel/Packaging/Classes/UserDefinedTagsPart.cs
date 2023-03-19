namespace DocumentModel.Packaging;

/// <summary>
///   Defines the UserDefinedTagsPart
/// </summary>
public class UserDefinedTagsPart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}