namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ShapePropertiesExtensionList Class.
/// </summary>
public class ShapePropertiesExtensionList: ModelElement
{
  public Collection<ShapePropertiesExtension>? ShapePropertiesExtensions { get; set; }
}
