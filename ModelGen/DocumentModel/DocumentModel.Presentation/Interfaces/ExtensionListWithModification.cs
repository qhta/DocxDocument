namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ExtensionListWithModification Class.
/// </summary>
public interface ExtensionListWithModification // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Modify
  /// </summary>
  public Boolean? Modify { get ; set; }
  
  public Collection<Extension>? Extensions { get ; set; }
  
}
