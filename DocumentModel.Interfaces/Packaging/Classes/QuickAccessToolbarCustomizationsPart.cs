namespace DocumentModel.Packaging;

/// <summary>
///   Defines the QuickAccessToolbarCustomizationsPart
/// </summary>
public interface QuickAccessToolbarCustomizationsPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}