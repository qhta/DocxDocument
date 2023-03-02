namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public record NonVisualPicturePropertiesExtensionList
{
  public Collection<NonVisualPicturePropertiesExtension>? NonVisualPicturePropertiesExtensions { get; set; }
}