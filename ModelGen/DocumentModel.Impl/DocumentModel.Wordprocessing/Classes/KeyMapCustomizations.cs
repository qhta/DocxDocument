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
  
  public KeyMapCustomizationsImpl(): base() {}
  
  public KeyMapCustomizationsImpl(DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<KeyMapEntry>? KeyMapEntries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
