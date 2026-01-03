namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualDrawingPropertiesExtensionList interface.
/// </summary>
public interface NonVisualDrawingPropertiesExtensionList: IModelElement
{
  public Collection<NonVisualDrawingPropertiesExtension>? NonVisualDrawingPropertiesExtensions { get; set; }
}