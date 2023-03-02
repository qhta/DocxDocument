namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ShapePropertiesExtensionList Class.
/// </summary>
public record ShapePropertiesExtensionList
{
  public Collection<ShapePropertiesExtension>? ShapePropertiesExtensions { get; set; }
}