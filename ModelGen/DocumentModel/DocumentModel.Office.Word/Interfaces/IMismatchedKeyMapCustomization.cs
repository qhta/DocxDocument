namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the MismatchedKeyMapCustomization Class.
/// </summary>
public interface IMismatchedKeyMapCustomization // : DocumentModel.Office.Word.IKeymapsType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Word.IKeyMapEntry>? KeyMapEntries { get ; set; }
  
}
