namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtensionList Class.
/// </summary>
public interface ShapePropertiesExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ShapePropertiesExtension>? ShapePropertiesExtensions { get ; set; }
  
}
