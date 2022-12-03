namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartSpaceExtensionList Class.
/// </summary>
public interface ChartSpaceExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ChartSpaceExtension>? ChartSpaceExtensions { get ; set; }
  
}
