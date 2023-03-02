namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public record NonVisualDrawingPropertiesExtensionList
{
  public Collection<NonVisualDrawingPropertiesExtension>? NonVisualDrawingPropertiesExtensions { get; set; }
}