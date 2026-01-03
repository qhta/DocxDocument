namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PowerPointCommentPart
/// </summary>
public interface PowerPointCommentPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}