namespace DocumentModel.Packaging;

/// <summary>
///   Defines the QuickAccessToolbarCustomizationsPart
/// </summary>
public interface QuickAccessToolbarCustomizationsPart:
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}