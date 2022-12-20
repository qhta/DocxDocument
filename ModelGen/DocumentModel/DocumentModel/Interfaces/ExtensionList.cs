namespace DocumentModel;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public partial interface ExtensionList
{
  public Collection<DocumentModel.Extension>? Extensions { get; set; }
  
}
