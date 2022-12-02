namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MismatchedKeyMapCustomization Class.
/// </summary>
public interface IMismatchedKeyMapCustomization // : DocumentModel.Wordprocessing.IKeymapsType
{
  public Collection<IKeyMapEntry>? KeyMapEntries { get ; set; }
  
}
