namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the KeyMapCustomizations Class.
/// </summary>
public interface IKeyMapCustomizations // : DocumentModel.Office.Word.IKeymapsType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Word.IKeyMapEntry>? KeyMapEntries { get ; set; }
  
}
