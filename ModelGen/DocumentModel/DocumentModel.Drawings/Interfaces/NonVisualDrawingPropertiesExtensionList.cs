namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtensionList Class.
/// </summary>
public interface NonVisualDrawingPropertiesExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<NonVisualDrawingPropertiesExtension>? NonVisualDrawingPropertiesExtensions { get ; set; }
  
}
