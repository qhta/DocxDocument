namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CustomXmlPart
/// </summary>
public interface CustomXmlPart: IModelElement
{
  public string? RelationshipType { get; set; }
}