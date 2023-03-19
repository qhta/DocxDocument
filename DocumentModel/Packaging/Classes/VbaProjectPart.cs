namespace DocumentModel.Packaging;

/// <summary>
///   Defines the VbaProjectPart
/// </summary>
public class VbaProjectPart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}