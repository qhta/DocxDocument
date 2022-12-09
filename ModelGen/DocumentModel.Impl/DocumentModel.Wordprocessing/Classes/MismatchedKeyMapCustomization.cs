namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MismatchedKeyMapCustomization Class.
/// </summary>
public class MismatchedKeyMapCustomizationImpl: ModelElementImpl, MismatchedKeyMapCustomization
{
  public DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<KeyMapEntry>? KeyMapEntries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
