namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapCustomizations Class.
/// </summary>
public interface IKeyMapCustomizations // : DocumentModel.Wordprocessing.IKeymapsType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IKeyMapEntry>? KeyMapEntries { get ; set; }
  
}
