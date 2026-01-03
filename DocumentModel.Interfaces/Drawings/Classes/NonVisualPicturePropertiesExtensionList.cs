namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualPicturePropertiesExtensionList interface.
/// </summary>
public interface NonVisualPicturePropertiesExtensionList: IModelElement
{
  public Collection<NonVisualPicturePropertiesExtension>? NonVisualPicturePropertiesExtensions { get; set; }
}