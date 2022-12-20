namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PowerPointCommentPart
/// </summary>
public partial interface PowerPointCommentPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
