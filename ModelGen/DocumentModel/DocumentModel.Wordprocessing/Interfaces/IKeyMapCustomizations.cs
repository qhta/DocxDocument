namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapCustomizations Class.
/// </summary>
public interface IKeyMapCustomizations // : DocumentModel.Wordprocessing.IKeymapsType
{
  public Collection<IKeyMapEntry>? KeyMapEntries { get ; set; }
  
}
