namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ShapePropertiesExtensionList interface.
/// </summary>
public interface ShapePropertiesExtensionList: IModelElement
{
  public Collection<ShapePropertiesExtension>? ShapePropertiesExtensions { get; set; }
}