namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapCustomizations Class.
/// </summary>
public partial interface KeyMapCustomizations
{
  public Collection<DocumentModel.Wordprocessing.KeyMapEntry>? KeyMapEntries { get; set; }
  
}
