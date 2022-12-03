namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapCustomizations Class.
/// </summary>
public interface KeyMapCustomizations // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<KeyMapEntry>? KeyMapEntries { get ; set; }
  
}
