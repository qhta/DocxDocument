namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public class NonVisualDrawingPropertiesExtensionList: ModelElement
{
  public Collection<NonVisualDrawingPropertiesExtension>? NonVisualDrawingPropertiesExtensions { get; set; }
}