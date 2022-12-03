namespace DocumentModel;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public interface ExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Extension>? Extensions { get ; set; }
  
}
