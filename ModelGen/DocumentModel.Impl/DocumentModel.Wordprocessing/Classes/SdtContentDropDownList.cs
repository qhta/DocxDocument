namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDropDownList Class.
/// </summary>
public class SdtContentDropDownListImpl: ModelElementImpl, SdtContentDropDownList
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Drop-down List Last Saved Value
  /// </summary>
  public String? LastValue
  {
    get;
    set;
  }
  
  public Collection<ListItem>? ListItems
  {
    get;
    set;
  }
  
}
