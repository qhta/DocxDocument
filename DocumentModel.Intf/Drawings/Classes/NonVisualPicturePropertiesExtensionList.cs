namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NonVisualPicturePropertiesExtensionList Class.
/// </summary>
public class NonVisualPicturePropertiesExtensionList: ModelElement
{
  public Collection<NonVisualPicturePropertiesExtension>? NonVisualPicturePropertiesExtensions { get; set; }
}