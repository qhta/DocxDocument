namespace DocumentModel.Packaging;

/// <summary>
/// Defines the UserDefinedTagsPart
/// </summary>
public partial interface UserDefinedTagsPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
