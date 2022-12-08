namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapCustomizations Class.
/// </summary>
public class KeyMapCustomizationsImpl: ModelElementImpl, KeyMapCustomizations
{
  public DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<KeyMapEntry>? KeyMapEntries
  {
    get;
    set;
  }
  
}
