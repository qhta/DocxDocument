namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ExtensionListModify Class.
/// </summary>
public interface ExtensionListModify // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Modify
  /// </summary>
  public Boolean? Modify { get ; set; }
  
  public Collection<Extension>? Extensions { get ; set; }
  
}
