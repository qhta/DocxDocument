namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualDrawingPropertiesExtensionList interface.
/// </summary>
public interface NonVisualDrawingPropertiesExtensionList:
{
  public Collection<NonVisualDrawingPropertiesExtension>? NonVisualDrawingPropertiesExtensions { get; set; }
}