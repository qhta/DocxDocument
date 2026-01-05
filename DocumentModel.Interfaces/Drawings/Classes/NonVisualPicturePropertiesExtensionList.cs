namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualPicturePropertiesExtensionList interface.
/// </summary>
public interface NonVisualPicturePropertiesExtensionList:
{
  public Collection<NonVisualPicturePropertiesExtension>? NonVisualPicturePropertiesExtensions { get; set; }
}