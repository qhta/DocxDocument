namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MismatchedKeyMapCustomization Class.
/// </summary>
public interface MismatchedKeyMapCustomization // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<KeyMapEntry>? KeyMapEntries { get ; set; }
  
}
