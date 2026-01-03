namespace DocumentModel.Packaging;

/// <summary>
///   Defines the QuickAccessToolbarCustomizationsPart
/// </summary>
public interface QuickAccessToolbarCustomizationsPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}