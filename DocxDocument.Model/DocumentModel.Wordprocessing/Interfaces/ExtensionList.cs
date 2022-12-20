namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public partial interface ExtensionList
{
  public Collection<DocumentModel.Wordprocessing.Extension>? Extensions { get; set; }
  
}
