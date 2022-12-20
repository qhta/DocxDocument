namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MismatchedKeyMapCustomization Class.
/// </summary>
public partial interface MismatchedKeyMapCustomization
{
  public Collection<DocumentModel.Wordprocessing.KeyMapEntry>? KeyMapEntries { get; set; }
  
}
