namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MismatchedKeyMapCustomization Class.
/// </summary>
public interface IMismatchedKeyMapCustomization // : DocumentModel.Wordprocessing.IKeymapsType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IKeyMapEntry>? KeyMapEntries { get ; set; }
  
}
