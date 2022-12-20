namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NamedSheetViewsPart
/// </summary>
public partial interface NamedSheetViewsPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
