namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PtExtensionList Class.
/// </summary>
public interface PtExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<PtExtension>? PtExtensions { get ; set; }
  
}
